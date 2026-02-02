param (
    [switch]$Force
)

$RepoRoot = Get-Location
$CsharpRoot = Join-Path $RepoRoot "roadmaps/backend/csharp"
$StarterDir = Join-Path $CsharpRoot "_shared/starter-state"

Write-Host "⚠️  WARNING: This will reset all C# labs to their initial state." -ForegroundColor Yellow
Write-Host "    Your progress in src/ and tests/ will be lost." -ForegroundColor Yellow
Write-Host ""

if (-not $Force) {
    $confirmation = Read-Host "Are you sure you want to continue? (y/N)"
    if ($confirmation -ne 'y') {
        Write-Host "Aborted."
        exit
    }
}

Write-Host "🔄 Resetting labs..." -ForegroundColor Green

# Get all module directories in starter state
$modules = Get-ChildItem -Path $StarterDir -Recurse -Directory | Where-Object { Test-Path (Join-Path $_.FullName "src") }

foreach ($module in $modules) {
    # Calculate relative path from starter dir
    $relPath = $module.FullName.Substring($StarterDir.Length + 1)
    $targetPath = Join-Path $CsharpRoot $relPath

    Write-Host "   Restoring $relPath..." -ForegroundColor Gray

    # 1. Clean existing src and tests
    if (Test-Path (Join-Path $targetPath "src")) { Remove-Item -Recurse -Force (Join-Path $targetPath "src") }
    if (Test-Path (Join-Path $targetPath "tests")) { Remove-Item -Recurse -Force (Join-Path $targetPath "tests") }

    # 2. Copy from starter
    Copy-Item -Recurse -Force (Join-Path $module.FullName "src") (Join-Path $targetPath "src")
    Copy-Item -Recurse -Force (Join-Path $module.FullName "tests") (Join-Path $targetPath "tests")
    
    # 3. Restore csproj if missing
    if (Test-Path (Join-Path $module.FullName "Lab.csproj")) {
        Copy-Item -Force (Join-Path $module.FullName "Lab.csproj") (Join-Path $targetPath "Lab.csproj")
    }

    # 4. Clean build artifacts
    if (Test-Path (Join-Path $targetPath "bin")) { Remove-Item -Recurse -Force (Join-Path $targetPath "bin") }
    if (Test-Path (Join-Path $targetPath "obj")) { Remove-Item -Recurse -Force (Join-Path $targetPath "obj") }
    if (Test-Path (Join-Path $targetPath "TestResults")) { Remove-Item -Recurse -Force (Join-Path $targetPath "TestResults") }
}

Write-Host "✅ Reset complete. Happy coding!" -ForegroundColor Green