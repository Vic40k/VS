using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace VS_CRM.Models
{
    public partial class Vehicles
    {
        public string PlateNumber { get; set; }
        public int VehicleType { get; set; }
        public string Name { get; set; }
        public double Width { get; set; }
        public double Length { get; set; }
        public double Height { get; set; }
        public double VolumeWidth { get; set; }
        public double VolumeHeight { get; set; }
        public double VolumeLength { get; set; }
        public double Mass { get; set; }
        public double MassX { get; set; }
        public double MassY { get; set; }
        public double MountX { get; set; }
        public double MountY { get; set; }
        public double Axis1Offset { get; set; }
        public double Axis2Offset { get; set; }
        public double Axis3Offset { get; set; }
        public double Axis4Offset { get; set; }
        public int Axis1Group { get; set; }
        public int Axis2Group { get; set; }
        public int Axis3Group { get; set; }
        public int Axis4Group { get; set; }
        public double Axis1MaxLoad { get; set; }
        public double Axis2MaxLoad { get; set; }
        public double Axis3MaxLoad { get; set; }
        public double Axis4MaxLoad { get; set; }
    }
}
