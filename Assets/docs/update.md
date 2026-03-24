Update & Upgrade Guide

This document provides step-by-step instructions for safely updating the School Accidents Simulator project in a production environment.

1. Pre-Update Preparation

Before starting the update process, ensure the environment is ready.

1.1 Verify Access
Ensure you have access to:
Production server
Source repository
Configuration files
Database (if used)
1.2 Check Current Version

Identify the currently deployed version:

cat /opt/school-simulator/version.txt
1.3 Review Changes
Check release notes / commits
Identify:
Breaking changes
Database updates
Config changes
2. Backup

Before any update, create backups.

2.1 Backup Application Files
cp -r /opt/school-simulator /opt/school-simulator_backup
2.2 Backup Database (if used)

PostgreSQL example:

pg_dump school_simulator > backup.sql
2.3 Verify Backup

Ensure backup files exist and are not empty.

3. Compatibility Check

Before deployment:

Verify OS compatibility
Verify Unity build version matches runtime
Check required dependencies:
.NET version
External libraries
4. Downtime Planning

If update requires stopping the application:

Schedule update during low-usage period
Notify stakeholders (if applicable)
Estimated downtime: 5–15 minutes
5. Update Process
   5.1 Stop Application

Stop the running application:

pkill SchoolAccidentsSimulator

or manually close the process.

5.2 Deploy New Build

Copy new build to server:

scp -r build/ user@server:/opt/school-simulator/

Replace old files if needed.

5.3 Data Migration (if required)

If database schema changed:

psql school_simulator < migration.sql
5.4 Update Configuration

Update config files if needed:

/opt/school-simulator/config/

Check:

Database credentials
Paths
Environment variables
5.5 Start Application
cd /opt/school-simulator/build
./SchoolAccidentsSimulator.exe
6. Post-Update Verification
   6.1 Basic Check
   Application starts successfully
   No critical errors in console/logs
   Main scene loads correctly
   6.2 Functional Check
   Start simulation
   Trigger interaction (accident scenario)
   Verify UI and logic work correctly
   6.3 Log Check
   /opt/school-simulator/logs/

Look for:

Errors
Exceptions
Missing assets
7. Rollback (if needed)

If update fails:

7.1 Stop Application
pkill SchoolAccidentsSimulator
7.2 Restore Backup
rm -rf /opt/school-simulator
mv /opt/school-simulator_backup /opt/school-simulator
7.3 Restore Database
psql school_simulator < backup.sql
7.4 Restart Application
cd /opt/school-simulator/build
./SchoolAccidentsSimulator.exe
8. Common Issues
   Application does not start
   Check logs
   Verify correct build version
   Database errors
   Check migration scripts
   Verify schema compatibility
   Missing files/assets
   Ensure full build was deployed
9. Update Summary
   Prepare environment
   Create backups
   Verify compatibility
   Stop application
   Deploy new build
   Apply migrations
   Update configs
   Start application
   Verify functionality
   
10. Notes
   Always backup before updating
   Use versioned builds
   Keep rollback plan ready
   Test update in staging environment if possible
   🔗 Related Documentation
   docs/deployment.md — initial deployment guide