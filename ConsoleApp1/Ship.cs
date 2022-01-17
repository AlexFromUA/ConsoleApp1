using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public abstract class Ship
    {
        public int Speed { get; set; }
        public int Length { get; set; }
        public double MinDist { get; set; }

        public Ship(int speed, int length) 
        { 
            Speed = speed; 
            Length = length;
        }

        public static bool operator ==(Ship ship1, Ship ship2) 
        {
            return ship1.GetType() == ship2.GetType() && ship1.Speed == ship2.Speed && ship1.Length == ship2.Length;
        }
        public static bool operator !=(Ship ship1, Ship ship2) 
        {
            
            return !(ship1.GetType() == ship2.GetType() && ship1.Length == ship2.Length && ship1.Speed == ship2.Speed);
        }

        public override string ToString()
        {
            
            return ($"Speed is {Speed}, length is {Length}, minimal distance from center is {MinDist}. ");

        }
    }
}
