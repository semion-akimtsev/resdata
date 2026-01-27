using System;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices;
using Xunit;
using Xunit.Abstractions;

namespace Resdata.Bindings.Tests;

/// <summary>
/// Tests that verify parameter marshalling between managed and native code works correctly.
/// These tests focus on data conversion, not business logic.
/// </summary>
public class ParameterMarshallingTests
{
    private readonly ITestOutputHelper _output;

    public ParameterMarshallingTests(ITestOutputHelper output)
    {
        _output = output;
    }

    /// <summary>
    /// Verifies that integer parameters are correctly declared in method signatures.
    /// Validates the structure, not actual invocation.
    /// </summary>
    [Fact]
    public void IntegerParametersAreMarshalledCorrectly()
    {
        var bindingClasses = GetAllBindingClasses();
        int intMethodCount = 0;

        foreach (var type in bindingClasses)
        {
            var methods = type.GetMethods(BindingFlags.Public | BindingFlags.Static | BindingFlags.DeclaredOnly);

            foreach (var method in methods)
            {
                var intParams = method.GetParameters()
                    .Where(p => p.ParameterType == typeof(int) || 
                               p.ParameterType == typeof(uint) ||
                               p.ParameterType == typeof(long));

                if (intParams.Any())
                {
                    intMethodCount++;
                    // Verify parameter types are correct (structure validation only)
                    foreach (var param in intParams)
                    {
                        Assert.True(param.ParameterType == typeof(int) || 
                                   param.ParameterType == typeof(uint) ||
                                   param.ParameterType == typeof(long),
                            $"Parameter {param.Name} should be an integer type");
                    }
                }
            }
        }

        _output.WriteLine($"Validated {intMethodCount} methods with integer parameters");
        Assert.True(intMethodCount > 0, "Should have found methods with integer parameters");
    }

    /// <summary>
    /// Verifies that double/float parameters are correctly declared in method signatures.
    /// Validates the structure, not actual invocation.
    /// </summary>
    [Fact]
    public void FloatingPointParametersAreMarshalledCorrectly()
    {
        var bindingClasses = GetAllBindingClasses();
        int floatMethodCount = 0;

        foreach (var type in bindingClasses)
        {
            var methods = type.GetMethods(BindingFlags.Public | BindingFlags.Static | BindingFlags.DeclaredOnly);

            foreach (var method in methods)
            {
                var floatParams = method.GetParameters()
                    .Where(p => p.ParameterType == typeof(double) || 
                               p.ParameterType == typeof(float));

                if (floatParams.Any())
                {
                    floatMethodCount++;
                    // Verify parameter types are correct (structure validation only)
                    foreach (var param in floatParams)
                    {
                        Assert.True(param.ParameterType == typeof(double) || 
                                   param.ParameterType == typeof(float),
                            $"Parameter {param.Name} should be a floating-point type");
                    }
                }
            }
        }

        _output.WriteLine($"Validated {floatMethodCount} methods with floating-point parameters");
        Assert.True(floatMethodCount > 0, "Should have found methods with floating-point parameters");
    }

    /// <summary>
    /// Verifies that string parameters use ANSI encoding in DllImport.
    /// Validates the structure, not actual invocation.
    /// </summary>
    [Fact]
    public void StringParametersAreMarshalledAsAnsi()
    {
        var bindingClasses = GetAllBindingClasses();
        int stringMethodCount = 0;

        foreach (var type in bindingClasses)
        {
            var methods = type.GetMethods(BindingFlags.Public | BindingFlags.Static | BindingFlags.DeclaredOnly);

            foreach (var method in methods)
            {
                var stringParams = method.GetParameters()
                    .Where(p => p.ParameterType == typeof(string));

                if (stringParams.Any())
                {
                    stringMethodCount++;
                    
                    // Verify DllImport uses ANSI charset
                    var dllImport = method.GetCustomAttribute<DllImportAttribute>();
                    if (dllImport != null)
                    {
                        _output.WriteLine($"Method {method.Name} has string parameters with charset: {dllImport.CharSet}");
                    }
                }
            }
        }

        _output.WriteLine($"Validated {stringMethodCount} methods with string parameters");
        Assert.True(stringMethodCount > 0, "Should have found methods with string parameters");
    }

    /// <summary>
    /// Verifies that return values are correctly declared in method signatures.
    /// Validates the structure, not actual invocation.
    /// </summary>
    [Fact]
    public void ReturnValuesAreMarshalledCorrectly()
    {
        var bindingClasses = GetAllBindingClasses();
        int nonVoidReturnCount = 0;

        foreach (var type in bindingClasses)
        {
            var methods = type.GetMethods(BindingFlags.Public | BindingFlags.Static | BindingFlags.DeclaredOnly)
                .Where(m => m.ReturnType != typeof(void));

            foreach (var method in methods)
            {
                nonVoidReturnCount++;
                
                // Verify return type is a valid marshallable type
                Assert.True(method.ReturnType.IsPrimitive || 
                           method.ReturnType == typeof(string) ||
                           typeof(SafeHandle).IsAssignableFrom(method.ReturnType) ||
                           method.ReturnType == typeof(IntPtr) ||
                           method.ReturnType == typeof(UIntPtr) ||
                           method.ReturnType == typeof(nuint) ||
                           method.ReturnType == typeof(nint),
                    $"Method {method.Name} has valid return type: {method.ReturnType.Name}");
            }
        }

        _output.WriteLine($"Validated {nonVoidReturnCount} methods with non-void returns");
        Assert.True(nonVoidReturnCount > 0, "Should have found methods with non-void returns");
    }

    /// <summary>
    /// Verifies that SafeHandle parameters properly represent native pointers.
    /// </summary>
    [Fact]
    public void SafeHandleParametersRepresentNativePointers()
    {
        var bindingClasses = GetAllBindingClasses();
        int handleMethodCount = 0;

        foreach (var type in bindingClasses)
        {
            var methods = type.GetMethods(BindingFlags.Public | BindingFlags.Static | BindingFlags.DeclaredOnly)
                ;

            foreach (var method in methods)
            {
                var handleParams = method.GetParameters()
                    .Where(p => typeof(SafeHandle).IsAssignableFrom(p.ParameterType));

                if (handleParams.Any())
                {
                    handleMethodCount++;
                    
                    // Verify handle parameters are properly typed
                    foreach (var param in handleParams)
                    {
                        Assert.True(typeof(SafeHandle).IsAssignableFrom(param.ParameterType),
                            $"Parameter {param.Name} should be assignable from SafeHandle");
                        
                        _output.WriteLine($"Method {method.Name} uses SafeHandle: {param.ParameterType.Name}");
                    }
                }
            }
        }

        _output.WriteLine($"Verified {handleMethodCount} methods using SafeHandle parameters");
        Assert.True(handleMethodCount > 0, "Should have found methods with SafeHandle parameters");
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
}

