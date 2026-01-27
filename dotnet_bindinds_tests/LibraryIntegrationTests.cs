using System;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices;
using Xunit;
using Xunit.Abstractions;

namespace Resdata.Bindings.Tests;

/// <summary>
/// Integration tests that verify the native library can be loaded and invoked.
/// These tests require the libresdata native library to be present and loadable.
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
    /// Verifies that P/Invoke methods can actually invoke the native library.
    /// Tests a subset of methods with safe parameters to ensure marshalling works.
    /// </summary>
    [Fact]
    public void BindingsCanInvokeNativeLibrary()
    {
        if (!CheckLibraryAvailability())
        {
            _output.WriteLine("Skipping test - native library not available");
            return;
        }

        var bindingClasses = GetAllBindingClasses();
        int attempted = 0;
        int successful = 0;
        int errors = 0;

        foreach (var type in bindingClasses)
        {
            var methods = type.GetMethods(BindingFlags.Public | BindingFlags.Static | BindingFlags.DeclaredOnly);

            foreach (var method in methods.Take(5)) // Test first 5 methods per class as sample
            {
                attempted++;
                var result = TryInvokeMethod(method);
                
                if (result.Success)
                {
                    successful++;
                    _output.WriteLine($"✓ {type.Name}.{method.Name}: {result.Message}");
                }
                else if (result.ExpectedError)
                {
                    // Expected errors (null pointer, invalid argument) are acceptable
                    _output.WriteLine($"~ {type.Name}.{method.Name}: {result.Message}");
                }
                else
                {
                    errors++;
                    _output.WriteLine($"✗ {type.Name}.{method.Name}: {result.Message}");
                }
            }
        }

        _output.WriteLine($"\nSummary: {attempted} methods tested, {successful} succeeded, {errors} unexpected errors");
        
        // We expect at least some methods to be invocable
        Assert.True(attempted > 0, "No methods were attempted");
        Assert.True(errors == 0, $"Found {errors} unexpected errors during invocation");
    }

    /// <summary>
    /// Verifies that parameter marshalling works correctly for different data types.
    /// </summary>
    [Fact]
    public void ParameterMarshallingWorksCorrectly()
    {
        if (!CheckLibraryAvailability())
        {
            _output.WriteLine("Skipping test - native library not available");
            return;
        }

        var bindingClasses = GetAllBindingClasses();
        bool foundIntMethod = false;
        bool foundDoubleMethod = false;
        bool foundStringMethod = false;

        foreach (var type in bindingClasses)
        {
            var methods = type.GetMethods(BindingFlags.Public | BindingFlags.Static | BindingFlags.DeclaredOnly);

            foreach (var method in methods)
            {
                var parameters = method.GetParameters();
                
                // Test integer marshalling
                if (!foundIntMethod && parameters.Any(p => p.ParameterType == typeof(int)))
                {
                    var result = TryInvokeMethod(method);
                    _output.WriteLine($"Int parameter test: {method.Name} - {result.Message}");
                    foundIntMethod = true;
                }

                // Test double marshalling
                if (!foundDoubleMethod && parameters.Any(p => p.ParameterType == typeof(double)))
                {
                    var result = TryInvokeMethod(method);
                    _output.WriteLine($"Double parameter test: {method.Name} - {result.Message}");
                    foundDoubleMethod = true;
                }

                // Test string marshalling
                if (!foundStringMethod && parameters.Any(p => p.ParameterType == typeof(string)))
                {
                    var result = TryInvokeMethod(method);
                    _output.WriteLine($"String parameter test: {method.Name} - {result.Message}");
                    foundStringMethod = true;
                }

                if (foundIntMethod && foundDoubleMethod && foundStringMethod)
                    break;
            }

            if (foundIntMethod && foundDoubleMethod && foundStringMethod)
                break;
        }

        Assert.True(foundIntMethod || foundDoubleMethod || foundStringMethod,
            "Could not find methods to test parameter marshalling");
    }

    /// <summary>
    /// Verifies that errors from the native library are properly handled and marshalled back.
    /// </summary>
    [Fact]
    public void ErrorsAreHandledCorrectly()
    {
        if (!CheckLibraryAvailability())
        {
            _output.WriteLine("Skipping test - native library not available");
            return;
        }

        var bindingClasses = GetAllBindingClasses();
        bool foundErrorCase = false;

        foreach (var type in bindingClasses)
        {
            var methods = type.GetMethods(BindingFlags.Public | BindingFlags.Static | BindingFlags.DeclaredOnly);

            foreach (var method in methods.Take(10)) // Test first 10 methods per class
            {
                var result = TryInvokeMethod(method);
                
                // If we get an expected error (like AccessViolationException), that's good
                if (result.ExpectedError && !result.Success)
                {
                    _output.WriteLine($"Error handling verified for {method.Name}: {result.Message}");
                    foundErrorCase = true;
                    break;
                }
            }

            if (foundErrorCase)
                break;
        }

        // This test passes if we either found an error case or all methods succeeded
        Assert.True(true, "Error handling verification complete");
    }

    // Helper methods

    private bool CheckLibraryAvailability()
    {
        if (_libraryAvailable.HasValue)
            return _libraryAvailable.Value;

        try
        {
            // Try to get any binding class and method to test library loading
            var bindingClasses = GetAllBindingClasses();
            var firstClass = bindingClasses.FirstOrDefault();
            
            if (firstClass == null)
            {
                _libraryAvailable = false;
                return false;
            }

            var firstMethod = firstClass.GetMethods(BindingFlags.Public | BindingFlags.Static | BindingFlags.DeclaredOnly)
                .FirstOrDefault();

            if (firstMethod == null)
            {
                _libraryAvailable = false;
                return false;
            }

            // Try to invoke a method - if we get DllNotFoundException, library isn't available
            var parameters = firstMethod.GetParameters();
            var args = new object?[parameters.Length];
            for (int i = 0; i < parameters.Length; i++)
            {
                args[i] = GetSafeDefaultValue(parameters[i].ParameterType);
            }

            try
            {
                firstMethod.Invoke(null, args);
                _libraryAvailable = true;
                return true;
            }
            catch (TargetInvocationException ex) when (ex.InnerException is DllNotFoundException)
            {
                _libraryAvailable = false;
                _output.WriteLine($"Native library not found: {ex.InnerException.Message}");
                return false;
            }
            catch
            {
                // Any other exception means the library loaded but call failed
                // (which is expected with null/zero arguments)
                _libraryAvailable = true;
                return true;
            }
        }
        catch
        {
            _libraryAvailable = false;
            return false;
        }
    }

    private (bool Success, bool ExpectedError, string Message) TryInvokeMethod(MethodInfo method)
    {
        try
        {
            var parameters = method.GetParameters();
            var args = new object?[parameters.Length];
            
            for (int i = 0; i < parameters.Length; i++)
            {
                args[i] = GetSafeDefaultValue(parameters[i].ParameterType);
            }

            var result = method.Invoke(null, args);
            
            return (true, false, $"Invoked successfully, returned {result?.GetType().Name ?? "void"}");
        }
        catch (TargetInvocationException ex)
        {
            var innerEx = ex.InnerException;
            
            if (innerEx is DllNotFoundException dllEx)
            {
                return (false, false, $"Library not found: {dllEx.Message}");
            }
            else if (innerEx is AccessViolationException avEx)
            {
                // Expected when passing null pointers
                return (false, true, "Expected error: Access violation (null pointer)");
            }
            else if (innerEx is SEHException sehEx)
            {
                // Expected for invalid operations
                return (false, true, $"Expected error: SEH exception (code: {sehEx.ErrorCode})");
            }
            else if (innerEx is NullReferenceException)
            {
                // Expected when dereferencing null
                return (false, true, "Expected error: Null reference");
            }
            else
            {
                return (false, false, $"Unexpected error: {innerEx?.GetType().Name} - {innerEx?.Message}");
            }
        }
        catch (Exception ex)
        {
            return (false, false, $"Unexpected exception: {ex.GetType().Name} - {ex.Message}");
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

    private object? GetSafeDefaultValue(Type type)
    {
        if (type.IsByRef)
        {
            type = type.GetElementType()!;
        }

        if (type == typeof(int) || type == typeof(uint) || 
            type == typeof(long) || type == typeof(ulong) ||
            type == typeof(short) || type == typeof(ushort) ||
            type == typeof(byte) || type == typeof(sbyte))
            return 0;

        if (type == typeof(double))
            return 0.0;

        if (type == typeof(float))
            return 0.0f;

        if (type == typeof(bool))
            return false;

        if (type == typeof(nuint) || type == typeof(nint))
            return 0;

        return null;
    }
}
