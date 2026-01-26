#!/bin/bash
# Script to generate bindings and run tests

set -e  # Exit on error

SCRIPT_DIR="$(cd "$(dirname "${BASH_SOURCE[0]}")" && pwd)"
REPO_ROOT="$(cd "$SCRIPT_DIR/.." && pwd)"

echo "=== .NET Bindings Test Runner ==="
echo

# Step 1: Generate bindings
echo "Step 1: Generating .NET bindings..."
cd "$REPO_ROOT"
python tools/generate_dotnet_bindings.py
echo "✓ Bindings generated"
echo

# Step 2: Run tests
echo "Step 2: Running tests..."
cd "$SCRIPT_DIR"

if [ "$1" == "--coverage-only" ]; then
    echo "Running coverage tests only (no native library required)..."
    dotnet test --filter "FullyQualifiedName~Coverage" --verbosity normal
elif [ "$1" == "--structure-only" ]; then
    echo "Running structure tests only (no native library required)..."
    dotnet test --filter "FullyQualifiedName~BindingInvocationTests.AllBindingClassesAreStatic|FullyQualifiedName~BindingInvocationTests.AllBindingMethodsHaveDllImportAttribute|FullyQualifiedName~Coverage" --verbosity normal
else
    echo "Running all tests..."
    dotnet test --verbosity normal
fi

echo
echo "=== Tests Complete ==="
