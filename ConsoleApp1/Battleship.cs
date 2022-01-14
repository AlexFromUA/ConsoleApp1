using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Battleship : Ship, IFire
    {
        readonly int ActionDist = 6;
        public Battleship(int speed, int length) : base(speed, length)
        {
        }
    }
}
