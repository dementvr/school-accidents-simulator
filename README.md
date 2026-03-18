# School Accidents Simulator
**School Accidents Simulator** is an interactive simulation project built with Unity. It is designed to model, visualize, and analyze potential safety hazards and emergency scenarios within a school environment. The project serves as an educational tool to train users on safety protocols and emergency response.

---

## Project Overview

This simulator provides a virtual environment where users can navigate school premises and interact with various "accident" scenarios. It aims to bridge the gap between theoretical safety knowledge and practical decision-making.

### Key Features:
* **Realistic Environments:** Detailed 3D models of classrooms, laboratories, and hallways.
* **Hazard Identification:** Interactive triggers that simulate common accidents (e.g., trips, spills, electrical faults).
* **Decision-Based Logic:** Users must choose the correct course of action to mitigate risks or provide first aid.
* **Educational Feedback:** Real-time analysis of the user's performance during an emergency.

---

## Repository Structure

The project follows the standard Unity directory structure:

* **`Assets/`** – The core of the project, containing scripts (C#), 3D models, textures, sounds, and scenes.
* **`ProjectSettings/`** – Global project configurations (Input, Physics, Graphics, Tags, etc.).
* **`Packages/`** – External dependencies and Unity-managed modules.
* **`UserSettings/`** – Local editor preferences.
* **`Logs/`** – Debugging information and system logs.

---

## Getting Started

To run the project locally, follow these steps:

1.  **Clone the Repository:**
    ```bash
    git clone [https://github.com/dementvr/school-accidents-simulator.git](https://github.com/dementvr/school-accidents-simulator.git)
    ```
2.  **Open with Unity Hub:**
    * Click **Add**.
    * Select the folder where you cloned the repository.
3.  **Unity Version:** Ensure you have the appropriate Unity version installed (Project was built with Unity 2021.3+ recommended).
4.  **Launch:** Once the project loads, navigate to `Assets/Scenes` and open the **Main** or **Startup** scene.

---

## Tech Stack

| Technology | Use Case |
| :--- | :--- |
| **Unity Engine** | Core simulation and rendering |
| **C#** | Scripting, logic, and UI management |
| **Git** | Version control |

---

## Code Documentation Guidelines

To ensure the project remains maintainable and understandable for all contributors, the project follows a consistent code documentation standard.

Documentation Standard
This project uses C# XML Documentation Comments (///) to document scripts, classes, and methods.
Documentation allows automatic generation of technical documentation and improves code readability for other developers.

---

## Required XML Tags

When writing documentation, use the following tags:
Tag -> Purpose
<summary> -> Short description of the class or method
<param> -> Description of method parameters
<returns> -> Description of returned value (if applicable)
<remarks> -> Additional explanation about behavior or logic

---

## Documentation Rules

When contributing new code:

- Every script must contain a <summary> description
- Public methods must document parameters and purpose
- Complex logic should include additional remarks
- Documentation must be updated whenever code behavior changes

Following these rules ensures consistent documentation across the project and makes it easier for new developers to understand the system.

---

## Contributing

Contributions are welcome! If you want to add new scenarios or improve the physics:
1.  **Fork** the project.
2.  Create your **Feature Branch** (`git checkout -b feature/AmazingFeature`).
3.  **Commit** your changes (`git commit -m 'Add some AmazingFeature'`).
4.  **Push** to the branch (`git push origin feature/AmazingFeature`).
5.  Open a **Pull Request**.

---

**Developer:** [dementvr](https://github.com/dementvr)  
**Status:** Work in Progress (Active Development)
