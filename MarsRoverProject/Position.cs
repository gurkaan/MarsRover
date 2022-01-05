using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarsRoverProject
{
    public class Position
    {
        public int X { get; set; }
        public int Y { get; set; }

        public Position(int a, int b)
        {
            X = a;
            Y = b;
        }
    }
}
