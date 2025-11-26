using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week_5
{
    public class Motorcycle : Vehicle
    {
        public bool HasSideCar { get; set; }

        public Motorcycle(string brand, int speed, bool hasSideCar)
            : base(brand, speed)
        {
            HasSideCar = hasSideCar;
        }

        public override void DisplayInfo()
        {
            base.DisplayInfo();
            Console.WriteLine($"Has Side Car: {HasSideCar}");
        }

    }
}
