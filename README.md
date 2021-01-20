# unity-simulation

## About The Project

This project aims to build tools for numerical simulation with unity (sensors, environment, communication between processes).
Parameterizable components will be available as well as tools that can be quickly integrated according to different manufacturers' specifications (including sensors).These components are intended for use with robotic development platforms such as ROS(2), as well as for testing AI or SLAM algorithms in python or other languages. In order to simplify the export of sensor data from the simulation, it is possible to use the dedicated python server to retrieve the data and then test the developed systems.


## Getting Started

To get a local copy up and running follow these simple steps.

### Prerequisites

* python 3.9 
* unity

### Installation
1. Clone the repo in unity project for the C# script
   ```sh
   git clone https://github.com/github_username/repo_name.git
   ```
2. Add the scripts to your unity objects
2. run python server
   ```sh
   py server.py
   ```
3. Run unity simulation
4. Get data from sensor and start to build things !

## Roadmap

### sensors
- [x] Lidar3D (poc)
- [x] Lidar2D (poc)
- [x] Distance 
- [ ] Depth Camera
- [ ] Camera
- [ ] Constructor specs (RPLidar, velodyne, ouster,intel) 

### Environment
- [ ] Procedural interior environnment
- [ ] Procedural exterior environnment

### Data Visualisation
- [x] Export data sensor in python server 
- [ ] Visualise data sensor 


<!-- LICENSE -->
## License

Distributed under the MIT License. See `LICENSE` for more information.

<!-- CONTACT -->
## Contact
Nicolas Brugie - nicolasbrugie@gmail.com
