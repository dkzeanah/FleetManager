# Guild Manager - Local Area Guild & Faction Management Platform

An open-source platform for connecting local people based on shared skills, items, hobbies, and activities. Inspired by RuneScape's guild system, this application automatically connects users through programmatic matching.

## Overview

Guild Manager helps communities organize around shared interests by:
- **Auto-connecting** users based on skills, items owned, and activities
- **Guild formation** - automatically grouping people with similar criteria
- **Quest tracking** - managing activities and progress
- **Item sharing** - facilitating borrowing and trading within guilds
- **Skill progression** - RuneScape-style leveling system

### Example Use Cases

1. **Skill Matching**: You add "Programming" to your skills → System connects you with local programmers
2. **Item Matching**: You add a "Sewing Machine" to your items → System finds others with sewing machines nearby
3. **Quest Collaboration**: You need an item for a quest → System suggests guild members who can lend it

## Tech Stack

### Backend
- **.NET 8** - Blazor Server
- **PostgreSQL** - Production database (Ubuntu deployment)
- **SQLite** - Development database (Windows)
- **Entity Framework Core 8** - ORM

### Frontend
- **React 19** with TypeScript
- **Vite** - Build tool
- **CSS3** - Styling

## Architecture

```
┌─────────────────┐
│  React Frontend │ (Vite dev server on port 5173)
│   (ClientApp)   │
└────────┬────────┘
         │ API Calls
         ▼
┌─────────────────┐
│ Blazor Server   │ (ASP.NET Core on port 7031)
│    (.NET 8)     │
└────────┬────────┘
         │
    ┌────┴────┐
    ▼         ▼
┌────────┐ ┌──────────┐
│ SQLite │ │PostgreSQL│
│  (Dev) │ │  (Prod)  │
└────────┘ └──────────┘
```

## Database Schema

### Core Models
- **Player** - User profiles with location data
- **Skill** - Available skills (Programming, Sewing, etc.)
- **PlayerSkill** - User skills with level & experience
- **Item** - Items users can own (tools, equipment)
- **PlayerItem** - User inventory
- **Quest** - Activities and objectives
- **PlayerQuest** - Quest progress tracking
- **Guild** - Auto-formed groups
- **GuildMember** - Guild membership
- **PlayerConnection** - Programmatic connections between users

## Setup Instructions

### Windows Development Setup

**Prerequisites:**
- .NET 8 SDK
- Node.js 18+
- Git

**Quick Setup:**
```powershell
# Clone the repository
git clone https://github.com/yourusername/FleetManager.git
cd FleetManager

# Run setup script
.\setup-windows.ps1
```

**Manual Setup:**
```powershell
# Install dependencies
dotnet restore
cd ClientApp
npm install
cd ..

# Install EF Core tools
dotnet tool install --global dotnet-ef

# Create database migration
dotnet ef migrations add InitialGuildSchema --context GuildDbContext --output-dir Data/Migrations/Guild

# Create database
dotnet ef database update --context GuildDbContext

# Run the application
# Terminal 1: Backend
dotnet run

# Terminal 2: Frontend
cd ClientApp
npm run dev
```

Access the app at: `https://localhost:7031`

### Ubuntu Production Setup

**Prerequisites:**
- Ubuntu 20.04+ or 22.04+
- PostgreSQL 12+
- .NET 8 SDK
- Node.js 18+

**Quick Setup:**
```bash
# Clone the repository
git clone https://github.com/yourusername/FleetManager.git
cd FleetManager

# Run setup script
chmod +x setup-ubuntu.sh
./setup-ubuntu.sh
```

**Manual Setup:**
```bash
# Install .NET 8
wget https://packages.microsoft.com/config/ubuntu/$(lsb_release -rs)/packages-microsoft-prod.deb
sudo dpkg -i packages-microsoft-prod.deb
sudo apt-get update
sudo apt-get install -y dotnet-sdk-8.0

# Install PostgreSQL
sudo apt-get install -y postgresql postgresql-contrib
sudo systemctl start postgresql
sudo systemctl enable postgresql

# Create database
sudo -u postgres psql
CREATE DATABASE guildmanager;
CREATE USER guilduser WITH PASSWORD 'your_secure_password';
GRANT ALL PRIVILEGES ON DATABASE guildmanager TO guilduser;
\q

# Update appsettings.Production.json with your password
nano appsettings.Production.json

# Install dependencies
dotnet restore
cd ClientApp && npm install && cd ..

# Build frontend
cd ClientApp && npm run build && cd ..

# Apply migrations
export ASPNETCORE_ENVIRONMENT=Production
dotnet ef database update --context GuildDbContext

# Build and run
dotnet build -c Release
dotnet run --environment=Production
```

## Configuration

### Database Configuration

**Windows (Development - SQLite):**
```json
{
  "DatabaseProvider": "Sqlite",
  "ConnectionStrings": {
    "GuildDbSqlite": "Data Source=GuildManager.db"
  }
}
```

**Ubuntu (Production - PostgreSQL):**
```json
{
  "DatabaseProvider": "PostgreSQL",
  "ConnectionStrings": {
    "GuildDbPostgres": "Host=localhost;Database=guildmanager;Username=guilduser;Password=your_password;"
  }
}
```

### Environment Variables

Set `ASPNETCORE_ENVIRONMENT` to switch between configurations:
- `Development` → Uses SQLite
- `Production` → Uses PostgreSQL

## Development

### Project Structure
```
FleetManager/
├── ClientApp/              # React frontend
│   ├── src/
│   │   ├── components/     # React components
│   │   ├── App.tsx         # Main app
│   │   └── ...
│   └── vite.config.ts      # Vite configuration
├── Models/
│   └── Guild/              # Domain models
├── Data/
│   ├── GuildDbContext.cs   # EF Core context
│   ├── DbConfiguration.cs  # DB provider config
│   └── Migrations/         # EF migrations
├── Program.cs              # ASP.NET startup
├── appsettings.json        # Development config
├── appsettings.Production.json  # Production config
└── setup-*.{ps1,sh}        # Setup scripts
```

### Adding Migrations

```bash
# After changing models
dotnet ef migrations add YourMigrationName --context GuildDbContext --output-dir Data/Migrations/Guild

# Apply migrations
dotnet ef database update --context GuildDbContext
```

### Running Tests

```bash
dotnet test
```

## Deployment

### Option 1: Systemd Service (Ubuntu)

Create `/etc/systemd/system/guildmanager.service`:
```ini
[Unit]
Description=Guild Manager Web App
After=network.target

[Service]
WorkingDirectory=/var/www/guildmanager
ExecStart=/usr/bin/dotnet /var/www/guildmanager/BlazorApp1.dll
Restart=always
RestartSec=10
Environment=ASPNETCORE_ENVIRONMENT=Production
User=www-data

[Install]
WantedBy=multi-user.target
```

```bash
sudo systemctl enable guildmanager
sudo systemctl start guildmanager
```

### Option 2: Nginx Reverse Proxy

Install Nginx and configure:
```nginx
server {
    listen 80;
    server_name yourdomain.com;

    location / {
        proxy_pass http://localhost:5000;
        proxy_http_version 1.1;
        proxy_set_header Upgrade $http_upgrade;
        proxy_set_header Connection keep-alive;
        proxy_set_header Host $host;
        proxy_cache_bypass $http_upgrade;
    }
}
```

## Contributing

Contributions welcome! Please:
1. Fork the repository
2. Create a feature branch
3. Make your changes
4. Submit a pull request

## License

MIT License - see LICENSE file

## Features Roadmap

- [x] Core domain models
- [x] Cross-platform database support
- [x] React frontend setup
- [ ] API endpoints for CRUD operations
- [ ] Auto-matching algorithm
- [ ] Location-based filtering
- [ ] Quest system implementation
- [ ] Item borrowing/trading
- [ ] Real-time notifications
- [ ] Mobile responsive design
- [ ] User authentication
- [ ] Guild management dashboard

## Support

For issues and questions, please use the GitHub issue tracker.
