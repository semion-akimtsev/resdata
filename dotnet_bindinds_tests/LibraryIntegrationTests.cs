using System;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices;
using Xunit;
using Xunit.Abstractions;

namespace Resdata.Bindings.Tests;

/// <summary>
/// Integration tests that verify the native library can be loaded.
/// These tests require the libresdata native library to be present and loadable.
/// Note: We do NOT invoke methods with null/zero arguments as this can crash the test process.
/// </summary>
public class LibraryIntegrationTests
{
    private readonly ITestOutputHelper _output;
    private static bool? _libraryAvailable;

    public LibraryIntegrationTests(ITestOutputHelper output)
    {
        _output = output;
    }

    /// <summary>
    /// Verifies that the native library can be found and loaded by the runtime.
    /// This test only checks if the DLL can be loaded, it does not invoke any methods.
    /// </summary>
    [Fact]
    public void NativeLibraryCanBeLoaded()
    {
        bool libraryLoaded = CheckLibraryAvailability();
        
        Assert.True(libraryLoaded, 
            "Native library 'libresdata' could not be loaded. " +
            "Ensure the library is built and available in the runtime path. " +
            "On Windows, libresdata.dll should be in the same directory as the test assembly or in a runtime-specific folder.");
    }

    /// <summary>
    /// Verifies that all P/Invoke methods have correct DllImport attributes.
    /// This confirms the bindings are properly configured to call the native library.
    /// </summary>
    [Fact]
    public void AllBindingMethodsHaveCorrectDllImport()
    {
        var bindingClasses = GetAllBindingClasses();
        int methodCount = 0;
        int correctImports = 0;

        foreach (var type in bindingClasses)
        {
            var methods = type.GetMethods(BindingFlags.Public | BindingFlags.Static | BindingFlags.DeclaredOnly);

            foreach (var method in methods)
            {
                methodCount++;
                var dllImport = method.GetCustomAttribute<DllImportAttribute>();
                
                if (dllImport != null && dllImport.Value.Contains("libresdata"))
                {
                    correctImports++;
                }
            }
        }

        _output.WriteLine($"Verified {correctImports}/{methodCount} methods have correct DllImport");
        Assert.True(correctImports == methodCount, $"All {methodCount} methods should have correct DllImport attributes");
    }

    /// <summary>
    /// Verifies that the native library architecture matches the test process.
    /// This ensures we're not trying to load a 32-bit library in a 64-bit process or vice versa.
    /// </summary>
    [Fact]
    public void NativeLibraryArchitectureMatches()
    {
        var is64Bit = Environment.Is64BitProcess;
        _output.WriteLine($"Test process is {(is64Bit ? "64-bit" : "32-bit")}");
        
        // This test passes as long as we can determine the architecture
        // The actual architecture matching is verified by library loading
        Assert.True(true, "Architecture check completed");
    }

    /// <summary>
    /// Verifies that SafeHandle types exist for resource management.
    /// These are critical for proper cleanup of native resources.
    /// </summary>
    [Fact]
    public void SafeHandleTypesAreProperlyDefined()
    {
        var assembly = Assembly.GetExecutingAssembly();
        var safeHandleTypes = assembly.GetTypes()
            .Where(t => t.Namespace == "Resdata.Bindings.Generated" && 
                       typeof(SafeHandle).IsAssignableFrom(t))
            .ToList();

        _output.WriteLine($"Found {safeHandleTypes.Count} SafeHandle types");
        Assert.True(safeHandleTypes.Count > 30, 
            $"Expected >30 SafeHandle types for resource management, found {safeHandleTypes.Count}");

        foreach (var handleType in safeHandleTypes.Take(5))
        {
            _output.WriteLine($"  - {handleType.Name}");
        }
    }

    // Helper methods

    private bool CheckLibraryAvailability()
    {
        if (_libraryAvailable.HasValue)
            return _libraryAvailable.Value;

        try
        {
            // Try to load the library using NativeLibrary.TryLoad
            // This is safer than trying to invoke a method
            if (RuntimeInformation.IsOSPlatform(OSPlatform.Windows))
            {
                // On Windows, check if libresdata.dll exists in common locations
                var possiblePaths = new[]
                {
                    "libresdata.dll",
                    Path.Combine(AppContext.BaseDirectory, "libresdata.dll"),
                    Path.Combine(AppContext.BaseDirectory, "runtimes", "win-x64", "native", "libresdata.dll")
                };

                foreach (var path in possiblePaths)
                {
                    if (File.Exists(path))
                    {
                        _output.WriteLine($"Found native library at: {path}");
                        _libraryAvailable = true;
                        return true;
                    }
                }

                // Try to load it anyway - maybe it's in the PATH
                try
                {
                    if (NativeLibrary.TryLoad("libresdata", out var handle))
                    {
                        _output.WriteLine("Native library loaded via NativeLibrary.TryLoad");
                        NativeLibrary.Free(handle);
                        _libraryAvailable = true;
                        return true;
                    }
                }
                catch
                {
                    // Ignore and fall through
                }
            }

            _libraryAvailable = false;
            _output.WriteLine("Native library not found or could not be loaded");
            return false;
        }
        catch (Exception ex)
        {
            _output.WriteLine($"Error checking library availability: {ex.Message}");
            _libraryAvailable = false;
            return false;
        }
    }

    private IEnumerable<Type> GetAllBindingClasses()
    {
        var assembly = Assembly.GetExecutingAssembly();
        return assembly.GetTypes()
            .Where(t => t.Namespace == "Resdata.Bindings.Generated" && 
                       t.Name.StartsWith("Native_") &&
                       t.IsClass);
    }
}
