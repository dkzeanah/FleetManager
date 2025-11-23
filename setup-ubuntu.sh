#!/bin/bash

# Guild Manager - Ubuntu Production Setup Script

echo -e "\033[0;32mGuild Manager - Ubuntu Production Setup\033[0m"
echo "========================================="
echo ""

# Check if .NET SDK is installed
echo -e "\033[0;33mChecking .NET SDK...\033[0m"
if ! command -v dotnet &> /dev/null; then
    echo -e "\033[0;31mERROR: .NET SDK not found. Installing .NET 8...\033[0m"
    wget https://packages.microsoft.com/config/ubuntu/$(lsb_release -rs)/packages-microsoft-prod.deb -O packages-microsoft-prod.deb
    sudo dpkg -i packages-microsoft-prod.deb
    rm packages-microsoft-prod.deb
    sudo apt-get update
    sudo apt-get install -y dotnet-sdk-8.0
else
    echo -e "\033[0;32m✓ .NET SDK version: $(dotnet --version)\033[0m"
fi

# Check if PostgreSQL is installed
echo -e "\033[0;33mChecking PostgreSQL...\033[0m"
if ! command -v psql &> /dev/null; then
    echo -e "\033[0;31mPostgreSQL not found. Installing...\033[0m"
    sudo apt-get install -y postgresql postgresql-contrib
    sudo systemctl start postgresql
    sudo systemctl enable postgresql
else
    echo -e "\033[0;32m✓ PostgreSQL is installed\033[0m"
fi

# Create database and user
echo ""
echo -e "\033[0;33mSetting up PostgreSQL database...\033[0m"
sudo -u postgres psql -c "CREATE DATABASE guildmanager;" 2>/dev/null || echo "Database already exists"
sudo -u postgres psql -c "CREATE USER guilduser WITH PASSWORD 'CHANGE_THIS_PASSWORD';" 2>/dev/null || echo "User already exists"
sudo -u postgres psql -c "GRANT ALL PRIVILEGES ON DATABASE guildmanager TO guilduser;" 2>/dev/null
echo -e "\033[0;32m✓ Database configured\033[0m"

# Install EF Core tools
echo ""
echo -e "\033[0;33mInstalling EF Core tools...\033[0m"
dotnet tool install --global dotnet-ef
dotnet tool update --global dotnet-ef
export PATH="$PATH:$HOME/.dotnet/tools"

# Restore NuGet packages
echo ""
echo -e "\033[0;33mRestoring NuGet packages...\033[0m"
dotnet restore

# Update appsettings.Production.json with actual password
echo ""
echo -e "\033[0;33mIMPORTANT: Update the PostgreSQL password in appsettings.Production.json\033[0m"
echo "Edit the file and change 'CHANGE_THIS_PASSWORD' to your actual password"

# Create migration
echo ""
echo -e "\033[0;33mCreating database migration...\033[0m"
dotnet ef migrations add InitialGuildSchema --context GuildDbContext --output-dir Data/Migrations/Guild

# Apply migration
echo ""
echo -e "\033[0;33mApplying database migration...\033[0m"
export ASPNETCORE_ENVIRONMENT=Production
dotnet ef database update --context GuildDbContext

# Build React frontend
echo ""
echo -e "\033[0;33mBuilding React frontend...\033[0m"
cd ClientApp
npm install
npm run build
cd ..

# Build .NET application
echo ""
echo -e "\033[0;33mBuilding .NET application...\033[0m"
dotnet build -c Release

echo ""
echo "========================================="
echo -e "\033[0;32mSetup complete!\033[0m"
echo ""
echo -e "\033[0;36mTo run the application:\033[0m"
echo -e "  dotnet run --environment=Production"
echo ""
echo -e "\033[0;36mOr publish and run:\033[0m"
echo -e "  dotnet publish -c Release -o /var/www/guildmanager"
echo -e "  cd /var/www/guildmanager && dotnet BlazorApp1.dll"
echo ""
