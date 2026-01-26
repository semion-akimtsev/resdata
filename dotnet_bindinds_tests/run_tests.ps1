# PowerShell script to generate bindings and run tests

$ErrorActionPreference = "Stop"

$ScriptDir = Split-Path -Parent $MyInvocation.MyCommand.Path
$RepoRoot = Split-Path -Parent $ScriptDir

Write-Host "=== .NET Bindings Test Runner ===" -ForegroundColor Cyan
Write-Host ""

# Step 1: Generate bindings
Write-Host "Step 1: Generating .NET bindings..." -ForegroundColor Yellow
Set-Location $RepoRoot
python tools/generate_dotnet_bindings.py
Write-Host "✓ Bindings generated" -ForegroundColor Green
Write-Host ""

# Step 2: Run tests
Write-Host "Step 2: Running tests..." -ForegroundColor Yellow
Set-Location $ScriptDir

$CoverageOnly = $args -contains "--coverage-only"
$StructureOnly = $args -contains "--structure-only"

if ($CoverageOnly) {
    Write-Host "Running coverage tests only (no native library required)..." -ForegroundColor Cyan
    dotnet test --filter "FullyQualifiedName~Coverage" --verbosity normal
}
elseif ($StructureOnly) {
    Write-Host "Running structure tests only (no native library required)..." -ForegroundColor Cyan
    dotnet test --filter "FullyQualifiedName~BindingInvocationTests.AllBindingClassesAreStatic|FullyQualifiedName~BindingInvocationTests.AllBindingMethodsHaveDllImportAttribute|FullyQualifiedName~Coverage" --verbosity normal
}
else {
    Write-Host "Running all tests..." -ForegroundColor Cyan
    dotnet test --verbosity normal
}

Write-Host ""
Write-Host "=== Tests Complete ===" -ForegroundColor Cyan
