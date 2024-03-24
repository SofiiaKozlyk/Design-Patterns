using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace AbstractFactoryClassLibrary
{
    public abstract class Device
    {
        public string DeviceType { get; set; }
        public string Model { get; set; }
        public string Brand { get; set; }
        public Device(string deviceType, string model, string brand)
        {
            DeviceType = deviceType;
            Model = model;
            Brand = brand;
        }
        public void DisplayInfo()
        {
            Console.WriteLine($"Device Type: {DeviceType}, Model: {Model}, Brand: {Brand}");
        }
    }
}
