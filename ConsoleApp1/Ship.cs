using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Ship
    {
        public int Speed { get; set; }
        public int Length { get; set; }
        public double MinDist { get; set; }

        public Ship(int speed, int length) 
        { 
            Speed = speed; Length = length;
        }


        public override string ToString()
        {
            
            return ($"Speed is {Speed}, length is {Length}, minimal distance from center is {MinDist}. ");

        }
    }
}
