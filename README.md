# Speckle for AutoCAD



**IMPORTANT:**


---
## Contents

- [Installation](#installation)
- [Usage](#usage)
- [Custom UserData](#custom-userdata)
- [Bugs and feature requests](#bugs-and-feature-requests)
- [Building Speckle for AutoCAD](#building-speckle-for-AutoCAD)
    - [Requirements](#requirements)
    - [Dev Notes](#dev-notes)
    - [Building Process](#building-process)
    - [Debugging](#debugging)
- [About Speckle](#about-speckle)
- [Credits](#credits)

## Installation



## Usage



## Custom UserData



## Bugs and feature requests

Please submit a new [issue](https://github.com/speckleworks/SpeckleAutoCAD/issues)!

---

## Building Speckle for AutoCAD

### Requirements

- Visual Studio 2017
- .NET Framework 2.0+ installed (it might be missing on Windows 8/10)

### Dev Notes

The SpeckleAutoCAD repo is currently made up by the following projects:

- SpeckleCore - submodule


### Building Process

- Clone/fork the repo
- Restore all Nuget package missing on the solution.
- If SpeckleCore hasn't been cloned, running ` git submodule update --remote` on the command line should clone the submodule along.
- Set SpeckleAutoCAD as start project and rebuild all

### Debugging


## About Speckle

Speckle reimagines the design process from the Internet up: an open source (MIT) initiative for developing an extensible Design & AEC data communication protocol and platform. Contributions are welcome - we can't build this alone!


## Credits

[Dimitrie](https://github.com/didimitrie), [Luis](https://github.com/fraguada), [Matteo](https://github.com/teocomi), [Alvaro](https://github.com/alvpickmans)
