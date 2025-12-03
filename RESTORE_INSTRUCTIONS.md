# Project Restoration Instructions

This document outlines the steps to complete the restoration of the FleetManager project to a working state.

## Completed Steps

✅ Created solution file (`FleetManager.sln`)
✅ Installed Node.js dependencies in `ClientApp/` folder
✅ Created Migration directory structure (`Data/Migrations/Guild/`)

## Remaining Steps (Requires Network Access)

Due to proxy authentication issues in the current environment, the following steps need to be completed in an environment with proper network access:

### 1. Install .NET EF Core Tools

```bash
dotnet tool install --global dotnet-ef
# OR update if already installed
dotnet tool update --global dotnet-ef
```

### 2. Restore NuGet Packages

```bash
dotnet restore BlazorApp1.csproj
```

### 3. Create Database Migrations

For **Development (SQLite)**:
```bash
dotnet ef migrations add InitialGuildSchema \
    --context GuildDbContext \
    --output-dir Data/Migrations/Guild
```

For **Production (PostgreSQL)**, ensure you set the environment variable first:
```bash
export ASPNETCORE_ENVIRONMENT=Production
dotnet ef migrations add InitialGuildSchema \
    --context GuildDbContext \
    --output-dir Data/Migrations/Guild
```

### 4. Apply Migrations

For **Development**:
```bash
dotnet ef database update --context GuildDbContext
```

This will create `GuildManager.db` in the project root.

For **Production**:
```bash
export ASPNETCORE_ENVIRONMENT=Production
dotnet ef database update --context GuildDbContext
```

### 5. Build and Run

**Development Mode:**
```bash
# Terminal 1: Backend
dotnet run

# Terminal 2: Frontend (in another terminal)
cd ClientApp
npm run dev
```

Access at: `https://localhost:7031`

**Production Mode:**
```bash
# Build frontend first
cd ClientApp && npm run build && cd ..

# Run in production
dotnet run --environment=Production
```

## Quick Setup Script

Alternatively, you can use the provided setup scripts:

**Windows:**
```powershell
.\setup-windows.ps1
```

**Linux/Mac:**
```bash
chmod +x setup-ubuntu.sh
./setup-ubuntu.sh
```

## Files Restored

- **FleetManager.sln** - Solution file for Visual Studio/Rider
- **ClientApp/node_modules/** - React dependencies (installed)
- **Data/Migrations/Guild/** - Directory for EF migrations (to be generated)

## Expected Generated Files

After running migrations, you should see:
- `Data/Migrations/Guild/[Timestamp]_InitialGuildSchema.cs`
- `Data/Migrations/Guild/[Timestamp]_InitialGuildSchema.Designer.cs`
- `Data/Migrations/Guild/GuildDbContextModelSnapshot.cs`
- `GuildManager.db` (if using SQLite in development)

## Database Schema

The migrations will create tables for:
- Players (user profiles)
- Skills (available skills in the system)
- PlayerSkills (user skills with levels)
- Items (shareable items)
- PlayerItems (user inventory)
- Quests (activities)
- PlayerQuests (quest progress)
- QuestSteps (quest requirements)
- QuestRequirements (items/skills needed for quests)
- Guilds (auto-formed groups)
- GuildMembers (guild membership)
- PlayerConnections (relationships between players)

## Troubleshooting

### "dotnet command not found"
Install .NET 8 SDK from: https://dotnet.microsoft.com/download/dotnet/8.0

### "Unable to load service index for NuGet"
Check your internet connection and proxy settings. If behind a corporate proxy:
```bash
export http_proxy=http://your-proxy:port
export https_proxy=http://your-proxy:port
```

### "Migration already exists"
If migrations already exist, you can remove them:
```bash
dotnet ef migrations remove --context GuildDbContext
```

Then recreate them with the commands above.

## Notes

- The `.gitignore` excludes `*.db` files, so local SQLite databases won't be committed
- The project uses SQLite for development and PostgreSQL for production
- Database provider is determined by `ASPNETCORE_ENVIRONMENT` variable
