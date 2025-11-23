# Guild Manager - Windows Development Setup Script

Write-Host "Guild Manager - Windows Development Setup" -ForegroundColor Green
Write-Host "=========================================" -ForegroundColor Green
Write-Host ""

# Check if .NET SDK is installed
Write-Host "Checking .NET SDK..." -ForegroundColor Yellow
$dotnetVersion = dotnet --version 2>$null
if ($LASTEXITCODE -ne 0) {
    Write-Host "ERROR: .NET SDK not found. Please install .NET 8 SDK from https://dotnet.microsoft.com/download" -ForegroundColor Red
    exit 1
}
Write-Host "✓ .NET SDK version: $dotnetVersion" -ForegroundColor Green

# Check if Node.js is installed
Write-Host "Checking Node.js..." -ForegroundColor Yellow
$nodeVersion = node --version 2>$null
if ($LASTEXITCODE -ne 0) {
    Write-Host "ERROR: Node.js not found. Please install from https://nodejs.org/" -ForegroundColor Red
    exit 1
}
Write-Host "✓ Node.js version: $nodeVersion" -ForegroundColor Green

# Install EF Core tools if not already installed
Write-Host ""
Write-Host "Installing/Updating EF Core tools..." -ForegroundColor Yellow
dotnet tool install --global dotnet-ef
dotnet tool update --global dotnet-ef

# Restore NuGet packages
Write-Host ""
Write-Host "Restoring NuGet packages..." -ForegroundColor Yellow
dotnet restore

# Create initial migration
Write-Host ""
Write-Host "Creating database migration..." -ForegroundColor Yellow
dotnet ef migrations add InitialGuildSchema --context GuildDbContext --output-dir Data/Migrations/Guild

# Apply migration to create SQLite database
Write-Host ""
Write-Host "Creating SQLite database..." -ForegroundColor Yellow
dotnet ef database update --context GuildDbContext

# Install React dependencies
Write-Host ""
Write-Host "Installing React dependencies..." -ForegroundColor Yellow
Set-Location ClientApp
npm install
Set-Location ..

Write-Host ""
Write-Host "=========================================" -ForegroundColor Green
Write-Host "Setup complete!" -ForegroundColor Green
Write-Host ""
Write-Host "To run the application:" -ForegroundColor Cyan
Write-Host "  1. Start the backend: dotnet run" -ForegroundColor White
Write-Host "  2. In another terminal, start React: cd ClientApp && npm run dev" -ForegroundColor White
Write-Host ""
Write-Host "Then open: https://localhost:7031" -ForegroundColor Cyan
