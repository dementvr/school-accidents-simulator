Production Deployment Guide

This document provides instructions for deploying the School Accidents Simulator project in a production environment.

1. Hardware Requirements
   Minimum Requirements
   Architecture: x64 (64-bit)
   CPU: 4 cores (Intel i5 / Ryzen 5 or equivalent)
   RAM: 8 GB
   Storage: 10 GB free space (SSD recommended)
   GPU: Integrated GPU (for basic rendering)
   Recommended Requirements
   CPU: 6–8 cores (Intel i7 / Ryzen 7)
   RAM: 16 GB
   Storage: SSD with 20+ GB free space
   GPU: Dedicated GPU (for better performance)
2. Software Requirements

The following software must be installed on the target machine:

Operating System:
Windows 10/11 (64-bit) or Linux (if supported build)
Unity Runtime Build
Build created via Unity Editor (no need to install Unity on production machine)
.NET Runtime (if required by build)
.NET 6 or higher
Database (optional):
PostgreSQL / SQLite / H2 (if used in project)
3. Network Configuration

If the application uses networking or external services:

Open required ports (example):
8080 — backend API (if used)
443 — HTTPS (recommended)
Ensure:
Stable internet connection
Firewall allows inbound/outbound traffic for the application
4. Server Configuration
   Directory Structure (example)
   /opt/school-simulator/
   ├── build/
   ├── config/
   ├── logs/
   └── data/
   Environment Variables (if required)
   APP_ENV=production
   LOG_LEVEL=info
5. Database Setup (if required)
   5.1 Install Database

Example (PostgreSQL):

sudo apt install postgresql
5.2 Create Database
CREATE DATABASE school_simulator;
5.3 Import Data
psql school_simulator < dump.sql
5.4 Configure Connection

Update configuration file:

/config/db_config.json

Example:

{
"host": "localhost",
"port": 5432,
"database": "school_simulator",
"user": "postgres",
"password": "password"
}
6. Build and Deployment
   6.1 Build Project (on developer machine)

In Unity:

Open project
Go to:
File → Build Settings
Select target platform (Windows/Linux)
Click Build
Output folder: /build/
6.2 Transfer Build to Server
scp -r build/ user@server:/opt/school-simulator/
6.3 Run Application
cd /opt/school-simulator/build
./SchoolAccidentsSimulator.exe

(or equivalent binary for your OS)

7. Health Check (Verification)

After deployment, verify the application is working correctly.

Basic Checks
Application starts without errors
Main scene loads successfully
UI is responsive
No critical errors in logs
Log Monitoring

Check logs:

/opt/school-simulator/logs/

Look for:

Errors
Exceptions
Missing dependencies
Functional Check
Start simulation
Trigger accident scenario
Verify interaction works correctly
Confirm UI feedback appears
8. Troubleshooting
   Application does not start
   Check logs
   Verify correct OS build
   Ensure required runtime is installed
   Missing dependencies
   Rebuild project with correct settings
   Verify all assets included
   Performance issues
   Check hardware requirements
   Reduce graphics settings
9. Notes
   Production build should not include debug logs unless needed
   Keep backups of build and configuration files
   Use versioned builds for rollback
10. Deployment Summary
    Prepare environment
    Install dependencies
    Configure database (if needed)
    Build project
    Transfer build
    Run application
    Verify functionality