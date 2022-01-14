using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Combinedship : Ship, ISupport, IFire
    {
        readonly int ActionDist = 3;
        public Combinedship(int speed, int length) : base(speed, length)
        {
        }
    }
}
