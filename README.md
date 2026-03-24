School Accidents Simulator

School Accidents Simulator is an interactive simulation project built with Unity. It is designed to model, visualize, and analyze potential safety hazards and emergency scenarios within a school environment. The project serves as an educational tool to train users on safety protocols and emergency response.

Project Overview

This simulator provides a virtual environment where users can navigate school premises and interact with various accident scenarios. It aims to bridge the gap between theoretical safety knowledge and practical decision-making.

Key Features
Realistic Environments — Detailed 3D models of classrooms, laboratories, and hallways
Hazard Identification — Interactive triggers simulating common accidents (e.g., spills, electrical faults)
Decision-Based Logic — Users choose appropriate actions to mitigate risks or provide first aid
Educational Feedback — Real-time analysis of user decisions during emergencies
Repository Structure

The project follows the standard Unity directory structure:

Assets/ — Core project files (scripts, scenes, models, UI, audio)
ProjectSettings/ — Global Unity settings (Input, Physics, Graphics, etc.)
Packages/ — External dependencies and Unity packages
UserSettings/ — Local editor preferences
Logs/ — Debug logs and runtime information
Tech Stack
Technology	Purpose
Unity Engine	Simulation and rendering
C#	Game logic and scripting
Git	Version control
Code Documentation Guidelines

This project uses C# XML Documentation Comments (///) to ensure code readability and maintainability.

Required XML Tags
Tag	Description
<summary>	Brief description of class or method
<param>	Description of method parameters
<returns>	Description of return value
<remarks>	Additional implementation details
Documentation Rules
Every script must include a <summary>
Public methods must describe parameters and purpose
Complex logic should include <remarks>
Documentation must be updated when code changes
Contributing

Contributions are welcome.

Fork the repository

Create a feature branch

git checkout -b feature/your-feature

Commit your changes

git commit -m "feat: add new feature"

Push to your branch

git push origin feature/your-feature
Open a Pull Request
Getting Started

This section explains how to set up and run the project from scratch on a clean system.

1. Requirements

Install the following software:

Unity Hub
Unity Editor (recommended: Unity 2021.3+ or project-specific version)
Git
IDE:
Rider (recommended)
Visual Studio 2022
2. Install Tools
2.1 Install Git

Download:
https://git-scm.com/downloads

Verify installation:

git --version
2.2 Install Unity Hub

Download:
https://unity.com/download

After installation:

Install required Unity Editor version
Add modules:
Android Build Support (if needed)
2.3 Install IDE

Rider:
https://www.jetbrains.com/rider/

or

Visual Studio:
https://visualstudio.microsoft.com/

3. Clone Repository
git clone https://github.com/dementvr/school-accidents-simulator.git
cd school-accidents-simulator
4. Open Project
Open Unity Hub
Click Add Project
Select project folder
Open the project

First launch may take several minutes due to asset import.

5. Environment Setup
5.1 Select IDE

In Unity:

Edit → Preferences → External Tools → External Script Editor

Select Rider or Visual Studio.

5.2 Check Packages
Window → Package Manager

Ensure installed:

TextMeshPro
Input System
Localization (if used)
DOTween (if used)
5.3 DOTween Setup (if used)
Tools → Demigiant → DOTween Utility Panel → Setup DOTween
6. Database Setup (if required)

If the project uses a database:

Install DBMS:
PostgreSQL / SQLite / H2
Create database:
CREATE DATABASE project_db;
Import dump:
psql project_db < dump.sql
Configure connection:
/Assets/Configs/db_config.json
7. Run the Project

In Unity:

Open scene:
Assets/Scenes/Main.unity
Press Play ▶️
8. Development Mode
Use Unity Editor for testing
Monitor logs in:
Console → Debug.Log
9. Basic Git Commands

Pull latest changes:

git pull

Create a branch:

git checkout -b feature/my-feature

Commit changes:

git add .
git commit -m "feat: description"

Push changes:

git push origin feature/my-feature
10. Common Issues

Project does not open
→ Check Unity version

Package errors
→ Reimport via Package Manager

Input System not working
Enable:

Edit → Project Settings → Player → Active Input Handling → Both
11. Recommendations
Do not commit:
Library/
Temp/
Build/
Follow code style guidelines
Use clear commit messages
Developer

GitHub: https://github.com/dementvr

Status: Work in Progress 🚧
