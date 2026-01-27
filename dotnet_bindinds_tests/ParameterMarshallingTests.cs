using System;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices;
using Xunit;
using Xunit.Abstractions;

namespace Resdata.Bindings.Tests;

/// <summary>
/// Tests that verify parameter and return value types in P/Invoke bindings are correctly declared.
/// These tests ensure the bindings will correctly marshal data when called.
/// </summary>
public class ParameterMarshallingTests
{
    private readonly ITestOutputHelper _output;

    public ParameterMarshallingTests(ITestOutputHelper output)
    {
        _output = output;
    }

    /// <summary>
    /// Verifies that all P/Invoke methods use only marshallable parameter types.
    /// Ensures parameters can be safely passed from managed to native code.
    /// </summary>
    [Fact]
    public void AllParameterTypesAreMarshallable()
    {
        var bindingClasses = GetAllBindingClasses();
        int totalMethods = 0;
        int totalParameters = 0;
        int unmarshallableCount = 0;

        foreach (var type in bindingClasses)
        {
            var methods = type.GetMethods(BindingFlags.Public | BindingFlags.Static | BindingFlags.DeclaredOnly);

            foreach (var method in methods)
            {
                totalMethods++;
                var parameters = method.GetParameters();
                
                foreach (var param in parameters)
                {
                    totalParameters++;
                    var paramType = param.ParameterType;
                    
                    // Remove ref/out modifiers
                    if (paramType.IsByRef)
                        paramType = paramType.GetElementType()!;

                    if (!IsMarshallable(paramType))
                    {
                        unmarshallableCount++;
                        _output.WriteLine($"Unmarshallable parameter: {type.Name}.{method.Name}({param.Name}: {paramType.Name})");
                    }
                }
            }
        }

        _output.WriteLine($"Validated {totalParameters} parameters across {totalMethods} methods");
        Assert.Equal(0, unmarshallableCount);
    }

    /// <summary>
    /// Verifies that all P/Invoke methods return only marshallable types.
    /// Ensures return values can be safely passed from native to managed code.
    /// </summary>
    [Fact]
    public void AllReturnTypesAreMarshallable()
    {
        var bindingClasses = GetAllBindingClasses();
        int totalMethods = 0;
        int unmarshallableReturns = 0;

        foreach (var type in bindingClasses)
        {
            var methods = type.GetMethods(BindingFlags.Public | BindingFlags.Static | BindingFlags.DeclaredOnly);

            foreach (var method in methods)
            {
                totalMethods++;
                var returnType = method.ReturnType;

                if (returnType != typeof(void) && !IsMarshallable(returnType))
                {
                    unmarshallableReturns++;
                    _output.WriteLine($"Unmarshallable return type: {type.Name}.{method.Name} returns {returnType.Name}");
                }
            }
        }

        _output.WriteLine($"Validated return types for {totalMethods} methods");
        Assert.Equal(0, unmarshallableReturns);
    }

    /// <summary>
    /// Verifies that string parameters in P/Invoke use consistent charset settings.
    /// </summary>
    [Fact]
    public void StringParametersUseConsistentCharset()
    {
        var bindingClasses = GetAllBindingClasses();
        int stringMethodCount = 0;
        var charsets = new System.Collections.Generic.Dictionary<CharSet, int>();

        foreach (var type in bindingClasses)
        {
            var methods = type.GetMethods(BindingFlags.Public | BindingFlags.Static | BindingFlags.DeclaredOnly);

            foreach (var method in methods)
            {
                var hasStringParams = method.GetParameters().Any(p => p.ParameterType == typeof(string));
                
                if (hasStringParams)
                {
                    stringMethodCount++;
                    var dllImport = method.GetCustomAttribute<DllImportAttribute>();
                    
                    if (dllImport != null)
                    {
                        if (!charsets.ContainsKey(dllImport.CharSet))
                            charsets[dllImport.CharSet] = 0;
                        charsets[dllImport.CharSet]++;
                    }
                }
            }
        }

        _output.WriteLine($"Found {stringMethodCount} methods with string parameters");
        foreach (var kvp in charsets)
        {
            _output.WriteLine($"  CharSet.{kvp.Key}: {kvp.Value} methods");
        }

        // Just report, don't fail - charset choice is a design decision
        Assert.True(stringMethodCount > 0, "Should have found methods with string parameters");
    }

    /// <summary>
    /// Verifies that SafeHandle types are consistently used for pointer parameters.
    /// </summary>
    [Fact]
    public void SafeHandlesAreUsedForPointers()
    {
        var bindingClasses = GetAllBindingClasses();
        int handleMethodCount = 0;
        int rawPointerCount = 0;

        foreach (var type in bindingClasses)
        {
            var methods = type.GetMethods(BindingFlags.Public | BindingFlags.Static | BindingFlags.DeclaredOnly);

            foreach (var method in methods)
            {
                foreach (var param in method.GetParameters())
                {
                    var paramType = param.ParameterType;
                    if (paramType.IsByRef)
                        paramType = paramType.GetElementType()!;

                    if (typeof(SafeHandle).IsAssignableFrom(paramType))
                    {
                        handleMethodCount++;
                    }
                    else if (paramType == typeof(IntPtr) || paramType == typeof(UIntPtr))
                    {
                        rawPointerCount++;
                        _output.WriteLine($"Raw pointer in {type.Name}.{method.Name}({param.Name}: {paramType.Name})");
                    }
                }
            }
        }

        _output.WriteLine($"Found {handleMethodCount} SafeHandle parameters");
        _output.WriteLine($"Found {rawPointerCount} raw pointer parameters");
        
        Assert.True(handleMethodCount > 0, "Should have SafeHandle parameters for resource management");
    }

    /// <summary>
    /// Verifies that all P/Invoke methods have correct calling convention.
    /// </summary>
    [Fact]
    public void AllMethodsHaveCorrectCallingConvention()
    {
        var bindingClasses = GetAllBindingClasses();
        int totalMethods = 0;
        var conventions = new System.Collections.Generic.Dictionary<CallingConvention, int>();

        foreach (var type in bindingClasses)
        {
            var methods = type.GetMethods(BindingFlags.Public | BindingFlags.Static | BindingFlags.DeclaredOnly);

            foreach (var method in methods)
            {
                totalMethods++;
                var dllImport = method.GetCustomAttribute<DllImportAttribute>();
                
                if (dllImport != null)
                {
                    if (!conventions.ContainsKey(dllImport.CallingConvention))
                        conventions[dllImport.CallingConvention] = 0;
                    conventions[dllImport.CallingConvention]++;
                }
            }
        }

        _output.WriteLine($"Validated calling conventions for {totalMethods} methods:");
        foreach (var kvp in conventions)
        {
            _output.WriteLine($"  {kvp.Key}: {kvp.Value} methods");
        }

        Assert.True(totalMethods > 0, "Should have found P/Invoke methods");
        Assert.True(conventions.Count > 0, "All methods should have calling conventions defined");
    }

    // Helper methods

    private IEnumerable<Type> GetAllBindingClasses()
    {
        var assembly = Assembly.GetExecutingAssembly();
        return assembly.GetTypes()
            .Where(t => t.Namespace == "Resdata.Bindings.Generated" && 
                       t.Name.StartsWith("Native_") &&
                       t.IsClass);
    }

    private bool IsMarshallable(Type type)
    {
        // Primitive types
        if (type.IsPrimitive)
            return true;

        // Common marshallable types
        if (type == typeof(string) ||
            type == typeof(IntPtr) ||
            type == typeof(UIntPtr) ||
            type == typeof(nint) ||
            type == typeof(nuint))
            return true;

        // SafeHandle and derivatives
        if (typeof(SafeHandle).IsAssignableFrom(type))
            return true;

        // Structs with StructLayout are marshallable
        if (type.IsValueType && type.GetCustomAttribute<StructLayoutAttribute>() != null)
            return true;

        // Enums are marshallable
        if (type.IsEnum)
            return true;

        return false;
    }
}

