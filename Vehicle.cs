using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week_5
{
    public class Vehicle
    {
        
    public string Brand { get; set; }
        public int Speed { get; set; }

        public Vehicle(string brand, int speed)
        {
            Brand = brand;
            Speed = speed;
        }

        public void Start()
        {
            Console.WriteLine($"{Brand} vehicle started.");
        }

        public void Stop()
        {
            Console.WriteLine($"{Brand} vehicle stopped.");
        }

        public virtual void DisplayInfo()
        {
            Console.WriteLine($"Brand: {Brand}, Speed: {Speed} km/h");
        }
    }
}

