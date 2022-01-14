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

        /*public static void Move(Field f, int index, char Direction)
        {
            var ship = f.Ships[index];
            switch (Direction)
            {
                case 'U': 
                    foreach (Points p in ship.points)
                    {
                        p.Y += ship.Speed;
                    }
                    break;
                case 'D':
                    foreach (Points p in points)
                    {
                        p.Y -= Speed;
                    }
                    break;

                case 'R':
                    foreach (Points p in points)
                    {
                        p.X += Speed;
                    }
                    break;
                case 'L':
                    foreach (Points p in points)
                    {
                        p.X -= Speed;
                    }
                    break;

            }
        }*/

        public override string ToString()
        {
            
            return ($"Speed is {Speed}, length is {Length}, minimal distance from center is {MinDist}. ");

        }
    }
}
