using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarsRoverProject
{
    public class Plateau
    {
        public Position Position { get; set; }

        public Plateau(Position position)
        {
            Position = position;
        }
    }
}
