using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp4
{
    class Vehicle
    {
        public string Id { get; set; }
        public string Description { get; set; }
        public string BrandName { get; set; }
        public Brand Brand { get; set; }
        public string ModelName { get; set; }
        public Model Model { get; set; }
        public string City { get; set; }
        public int YearofProduction { get; set; }
        public int Bantype { get; set; }
        public string Colour { get; set; }
        public string EngineVolume { get; set; }
        public int HorsePower { get; set; }
        public string TypeofFuel { get; set; }
        public string Mileage { get; set; }
        public string Gearbox { get; set; }
        public string Transmitter { get; set; }
        public string NewUsed { get; set; }
        public int Price { get; set; }
    }
}
