# SnapLog 2 (C#)

**SnapLog** is a Windows Forms desktop diagnostic utility designed for network engineers and system administrators. It provides rapid system reporting, installed software inventory, real-time network diagnostics (ping, jitter, MOS/ROS VoIP scoring, ICMP traceroute, TCP telnet testing), Citrix/VDI registry inspection, and custom script execution.

> **Note:** This project has been converted from VB.NET to modern C# (.NET Framework 4.5), retaining 100% of the original Windows Forms UI layout, controls, events, and diagnostic functionality. Original VB source files are archived in `archive/vb_original/`.

---

## Features

- **System Diagnostics**:
  - Hardware & OS identification via WMI (`Win32_ComputerSystem`).
  - Active network adapter details (IP, subnet mask, default gateway, DNS servers, MAC address).
  - External IP lookup and PAC / Proxy configuration detection.
  - CPU utilization, memory stats, and system uptime.
  - Comprehensive plain-text report generation with export to local disk or remote UNC paths.

- **Installed Software**:
  - Scans 32-bit and 64-bit Windows registry uninstall keys.
  - Fast search/filter bar.

- **Network Diagnostics & VoIP MOS**:
  - Continuous ping and real-time latency / packet loss charting (`System.Windows.Forms.DataVisualization.Charting`).
  - Jitter, ROS, and MOS (Mean Opinion Score) estimation for codecs (`G.711`, `G.729`, `iLBC`).
  - Asynchronous TCP Telnet port check (`TcpClient.ConnectAsync`).
  - ICMP Traceroute with real-time hop resolution (`ListView`).
  - Target list loader from text files in `remote/`.

- **VDI Inspection**:
  - Citrix / XenDesktop / VMware VDI registry key and session inspection.

- **Script Runner**:
  - Execute predefined administrative maintenance scripts located in `scripts/` (e.g., DNS flush, IP release/renew).

---

## Project Structure

```
SnapLog2/
├── SnapLog.sln                       # Visual Studio Solution
├── archive/
│   └── vb_original/                  # Archived original VB.NET source files
└── SnapLog/
    ├── SnapLog.csproj                # C# WinExe Project File (.NET Framework 4.5)
    ├── App.config                    # Application configuration & user settings
    ├── Program.cs                    # Application entry point ([STAThread])
    ├── AppSettings.cs                # PropertyGrid wrapper for application settings
    ├── Helpers.cs                    # Network helpers, DNS resolution, console runner
    ├── PC.cs                         # System info, network adapters, and report generator
    ├── FormMain.cs                   # Main multi-tab UI and background workers
    ├── FormMain.Designer.cs
    ├── FormMain.resx
    ├── FormTraceRoute.cs             # Traceroute hop-by-hop viewer
    ├── FormLoadURL.cs                # Remote target host selector
    ├── FormHelp.cs                   # User guide viewer (embedded HTML)
    ├── formAbout.cs                  # About dialog with assembly reflection
    ├── formConfig.cs                 # Settings dialog (PropertyGrid)
    ├── NetworkDiagnostics/
    │   ├── NetworkDiagnostics.cs     # Ping, jitter, MOS/ROS formulas, traceroute, telnet
    │   ├── CodecType.cs              # VoIP codec parameters (G.711, G.729, iLBC)
    │   └── PingData.cs               # Ping data transfer object
    ├── Properties/
    │   ├── AssemblyInfo.cs           # Assembly metadata and versioning (v2.0.0.0)
    │   ├── Resources.resx            # 23 embedded icons and bitmaps
    │   ├── Resources.Designer.cs
    │   ├── Settings.settings         # Application settings schema
    │   ├── Settings.Designer.cs
    │   └── app.manifest              # Windows execution manifest
    ├── remote/                       # Pre-configured target lists (*.txt)
    ├── scripts/                      # Pre-configured helper scripts (*.txt)
    └── Resources/                    # PNG/ICO image assets
```

---

## Building and Running

### Prerequisites
- Visual Studio 2017/2019/2022 with **.NET desktop development** workload, or MSBuild Tools with .NET Framework 4.5+ targeting pack.

### Build with Visual Studio
1. Open `SnapLog.sln` in Visual Studio.
2. Select **Debug** or **Release** configuration.
3. Build and run (F5).

### Build with MSBuild CLI
```cmd
msbuild SnapLog.sln /t:Rebuild /p:Configuration=Release
```
The compiled executable will be placed in `SnapLog\bin\Release\SnapLog.exe`.