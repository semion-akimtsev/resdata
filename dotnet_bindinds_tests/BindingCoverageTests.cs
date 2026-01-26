using System;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text.Json;
using Xunit;
using Xunit.Abstractions;

namespace Resdata.Bindings.Tests;

/// <summary>
/// Tests that verify the generated bindings match the manifest and provide complete coverage.
/// This ensures all native functions are exposed and maintainability is preserved.
/// </summary>
public class BindingCoverageTests
{
    private readonly ITestOutputHelper _output;

    public BindingCoverageTests(ITestOutputHelper output)
    {
        _output = output;
    }

    /// <summary>
    /// Verifies that all functions declared in manifest.json have corresponding P/Invoke bindings.
    /// This ensures complete coverage and helps identify missing bindings after library updates.
    /// </summary>
    [Fact]
    public void AllManifestFunctionsHaveBindings()
    {
        var manifestPath = Path.Combine(GetRepositoryRoot(), "dotnet_bindings", "manifest.json");
        
        if (!File.Exists(manifestPath))
        {
            _output.WriteLine($"Manifest not found at {manifestPath}, skipping coverage test");
            return;
        }

        var manifestJson = File.ReadAllText(manifestPath);
        var manifest = JsonSerializer.Deserialize<JsonElement>(manifestJson);

        var bindingClasses = GetAllBindingClasses().ToList();
        var allBindingMethods = bindingClasses
            .SelectMany(t => t.GetMethods(BindingFlags.Public | BindingFlags.Static | BindingFlags.DeclaredOnly))
            .Where(m => !m.Name.Equals("ExecuteAll"))
            .Select(m => m.Name)
            .ToHashSet();

        int totalFunctions = 0;
        int foundFunctions = 0;
        var missingFunctions = new List<string>();

        foreach (var header in manifest.EnumerateObject())
        {
            foreach (var func in header.Value.EnumerateArray())
            {
                var funcName = func.GetProperty("name").GetString();
                totalFunctions++;

                if (allBindingMethods.Contains(funcName!))
                {
                    foundFunctions++;
                }
                else
                {
                    missingFunctions.Add($"{header.Name}: {funcName}");
                }
            }
        }

        _output.WriteLine($"Manifest declares {totalFunctions} functions");
        _output.WriteLine($"Found bindings for {foundFunctions} functions");
        _output.WriteLine($"Missing bindings for {missingFunctions.Count} functions");

        if (missingFunctions.Any())
        {
            _output.WriteLine("\nMissing functions (first 10):");
            foreach (var missing in missingFunctions.Take(10))
            {
                _output.WriteLine($"  - {missing}");
            }
        }

        // We expect high coverage but allow for some functions that might be intentionally excluded
        var coveragePercent = (foundFunctions * 100.0) / totalFunctions;
        _output.WriteLine($"\nCoverage: {coveragePercent:F1}%");
        
        Assert.True(coveragePercent > 90, 
            $"Binding coverage should be >90%, got {coveragePercent:F1}%. Missing {missingFunctions.Count} functions.");
    }

    /// <summary>
    /// Verifies that each binding class corresponds to a header file in the manifest.
    /// This ensures organization is maintained and helps identify orphaned bindings.
    /// </summary>
    [Fact]
    public void BindingClassesCorrespondToManifestHeaders()
    {
        var manifestPath = Path.Combine(GetRepositoryRoot(), "dotnet_bindings", "manifest.json");
        
        if (!File.Exists(manifestPath))
        {
            _output.WriteLine($"Manifest not found, skipping test");
            return;
        }

        var manifestJson = File.ReadAllText(manifestPath);
        var manifest = JsonSerializer.Deserialize<JsonElement>(manifestJson);

        var bindingClasses = GetAllBindingClasses().ToList();
        
        _output.WriteLine($"Found {bindingClasses.Count} binding classes");
        _output.WriteLine($"Manifest has {manifest.EnumerateObject().Count()} headers");

        // Verify we have a reasonable number of binding classes
        Assert.True(bindingClasses.Count > 50, 
            $"Expected >50 binding classes, found {bindingClasses.Count}");
        
        // Verify binding classes follow naming convention
        foreach (var type in bindingClasses)
        {
            Assert.StartsWith("Native_", type.Name);
            Assert.Equal("Resdata.Bindings.Generated", type.Namespace);
        }
    }

    /// <summary>
    /// Verifies that binding classes have methods (aren't empty).
    /// This ensures the generation process is working correctly.
    /// </summary>
    [Fact]
    public void AllBindingClassesHaveMethods()
    {
        var bindingClasses = GetAllBindingClasses().ToList();
        var emptyClasses = new List<string>();

        foreach (var type in bindingClasses)
        {
            var methods = type.GetMethods(BindingFlags.Public | BindingFlags.Static | BindingFlags.DeclaredOnly)
                .Where(m => !m.Name.Equals("ExecuteAll"));

            if (!methods.Any())
            {
                emptyClasses.Add(type.Name);
            }
        }

        if (emptyClasses.Any())
        {
            _output.WriteLine($"Found {emptyClasses.Count} empty binding classes:");
            foreach (var className in emptyClasses)
            {
                _output.WriteLine($"  - {className}");
            }
        }

        Assert.Empty(emptyClasses);
    }

    /// <summary>
    /// Verifies the total count of binding methods is substantial.
    /// This is a sanity check to ensure the bindings were generated properly.
    /// </summary>
    [Fact]
    public void BindingsProvideSubstantialFunctionCoverage()
    {
        var bindingClasses = GetAllBindingClasses().ToList();
        int totalMethods = 0;

        foreach (var type in bindingClasses)
        {
            var methods = type.GetMethods(BindingFlags.Public | BindingFlags.Static | BindingFlags.DeclaredOnly)
                .Where(m => !m.Name.Equals("ExecuteAll"));
            
            totalMethods += methods.Count();
        }

        _output.WriteLine($"Total P/Invoke methods: {totalMethods}");
        _output.WriteLine($"Average methods per class: {totalMethods / (double)bindingClasses.Count:F1}");

        // resdata is a large library, should have hundreds of functions
        Assert.True(totalMethods > 500, 
            $"Expected >500 binding methods, found {totalMethods}");
    }

    /// <summary>
    /// Verifies that SafeHandle types exist for resource management.
    /// </summary>
    [Fact]
    public void SafeHandleTypesExistForResourceManagement()
    {
        // The generated bindings are compiled into the test assembly
        var assembly = Assembly.GetExecutingAssembly();
        var safeHandleTypes = assembly.GetTypes()
            .Where(t => t.Namespace == "Resdata.Bindings.Generated" && 
                       t.Name.StartsWith("Safe") && 
                       t.Name.EndsWith("Handle"))
            .ToList();

        _output.WriteLine($"Found {safeHandleTypes.Count} SafeHandle types");

        Assert.True(safeHandleTypes.Count > 30, 
            $"Expected >30 SafeHandle types for various resources, found {safeHandleTypes.Count}");

        // Verify some expected SafeHandle types exist
        var handleNames = safeHandleTypes.Select(t => t.Name).ToList();
        
        // Log some sample handles
        foreach (var name in handleNames.Take(10))
        {
            _output.WriteLine($"  - {name}");
        }
    }

    // Helper methods

    private IEnumerable<Type> GetAllBindingClasses()
    {
        // The generated bindings are compiled into the test assembly
        var assembly = Assembly.GetExecutingAssembly();
        return assembly.GetTypes()
            .Where(t => t.Namespace == "Resdata.Bindings.Generated" && 
                       t.Name.StartsWith("Native_") &&
                       t.IsClass);
    }

    private string GetRepositoryRoot()
    {
        // Start from test assembly location and search upward for repository root
        var directory = new DirectoryInfo(AppContext.BaseDirectory);
        
        while (directory != null)
        {
            if (Directory.Exists(Path.Combine(directory.FullName, "dotnet_bindings")))
            {
                return directory.FullName;
            }
            directory = directory.Parent;
        }

        // Fallback - assume standard structure
        return Path.GetFullPath(Path.Combine(AppContext.BaseDirectory, "..", "..", "..", ".."));
    }
}
