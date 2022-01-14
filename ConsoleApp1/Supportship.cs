using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Supportship : Ship, ISupport
    {
        readonly int ActionDist = 6;
        public Supportship(int speed, int length) : base(speed, length)
        {
        }
    }
}
