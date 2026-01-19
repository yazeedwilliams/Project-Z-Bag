# MATCHIFY - 3D Stereoscopic Solar System Explorer

An interactive 3D educational game designed specifically for stereoscopic displays like the HP ZSpace monitor. Explore the planets of our solar system in stunning 3D depth with intuitive spatial interactions.

## 🎮 Overview

This project leverages stereoscopic 3D technology to create an immersive educational experience where users can explore and learn about planets in our solar system. The game takes full advantage of zSpace's head tracking and stylus input to provide natural 3D interactions.

## 🖥️ Hardware Requirements

- **Required**: HP ZSpace or compatible 3D stereoscopic display
- **Operating System**: Windows Desktop
- **Input**: zSpace stylus (included with zSpace systems)

## 🛠️ Technical Specifications

- **Unity Version**: 2022.3 LTS
- **Render Pipeline**: Universal Render Pipeline (URP)
- **Graphics API**: DirectX 11/12
- **Target Platform**: Windows Desktop (x86_64)

## 📦 Key Packages & Dependencies

- **zSpace Core SDK** - Stereoscopic rendering and spatial tracking
- **Universal Render Pipeline (URP)** 14.0.12
- **TextMesh Pro** 3.0.7 - Enhanced UI text rendering
- **Post Processing** 3.4.0
- **SlimUI Modern Menu** - Main menu interface
- **QuickOutline** - Object highlighting system

## 📂 Project Structure
Assets/ ├── Scripts/ # Core game logic ├── Scenes/ # Game scenes (MainMenu, Level1) ├── Materials/ # Material assets ├── Prefabs/ # Reusable game objects ├── Models/ # 3D models ├── Textures/ # Texture assets ├── zSpace/ # zSpace SDK integration └── Planets of the Solar System 3D/ # Planet assets


## 🎯 Core Features

- **3D Stereoscopic Rendering**: Full depth perception on zSpace displays
- **Interactive Planet Exploration**: Select and examine planets with the zSpace stylus
- **Information System**: Learn about each celestial body with detailed cards
- **Spatial UI**: Menu and information panels positioned in 3D space
- **Multiple Skybox Environments**: Various space backgrounds for immersion

## 🚀 Getting Started

### Prerequisites

1. Unity 2022.3 LTS or newer
2. zSpace SDK installed
3. zSpace hardware connected and calibrated

### Setup

1. Clone or download this repository
2. Open the project in Unity 2022.3 LTS
3. Ensure zSpace drivers are installed on your system
4. Open `Assets/Scenes/MainMenu.unity` to start
5. Build and run on your zSpace-enabled system

### Build Instructions

1. Go to **File > Build Settings**
2. Select **Windows** platform
3. Architecture: **x86_64**
4. Click **Build** and choose output location
5. Run the executable on a system with zSpace hardware

## 🎮 Core Scripts

- `GameManager.cs` - Main game state and flow control
- `CardManager.cs` - Manages information cards
- `ItemManager.cs` - Handles selectable planet items
- `InformationBoxManager.cs` - Controls information display
- `SceneLoader.cs` - Scene transition management
- `GameEvents.cs` - Event system for game communication

## 🎨 Assets Attribution

This project uses the following third-party assets:
- Planets of the Solar System 3D
- AllSky Free Skyboxes
- SkySeries Freebie HDRI
- SlimUI Modern Menu 1
- QuickOutline

## 📋 Coding Guidelines

- Self-explanatory naming conventions
- Public methods include comments
- Constants defined as fields, not inline
- New Input System (com.unity.inputsystem) used throughout
- All scripts organized in `/Assets/Scripts`

## 🔧 Development Notes

- Project uses the **new Unity Input System**
- Never manually edit Unity-generated input system files
- All assets must be placed in their corresponding directories
- URP-compatible shaders and materials only

## 🐛 Known Issues

- Requires zSpace hardware for full functionality
- Standard displays will show doubled stereoscopic view
- Stylus input requires zSpace drivers

## 👥 Contributors

- [Abongile Thomas Mlanjeni](linkedin.com/in/abongile-thomas-mlanjeni-9b4a56140)

## 📞 Support

For zSpace hardware support: [zSpace Support](https://support.zspace.com)
For Unity version compatibility: [Unity Documentation](https://docs.unity3d.com/2022.3/Documentation/Manual/)

---

**Note**: This game is optimized for zSpace stereoscopic displays and may not function correctly on standard monitors.
