using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week_5
{
    public class Car : Vehicle
    {
        public int Seats { get; set; }

        public Car(string brand, int speed, int seats)
            : base(brand, speed)
        {
            Seats = seats;
        }

        public override void DisplayInfo()
        {
            base.DisplayInfo();
            Console.WriteLine($"Seats: {Seats}");
        }
    }
}
