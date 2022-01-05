using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarsRoverProject
{
    public class Rover
    {
        public Plateau Plateau;
        public Position Position;
        public CompassDirections Direction;

        public Rover(Plateau plateau, Position position, CompassDirections direction)
        {
            Plateau = plateau;
            Position = position;
            Direction = direction;
        }

        public void Operation(string letters)
        {
            foreach(char letter in letters)
            {
                if (letter == 'L')
                    SpinLeft();
                else if (letter == 'R')
                    SpinRight();
                else if (letter == 'M')
                    Move();
            }
        }
        private void SpinLeft()
        {
            if (Direction - 1 < CompassDirections.N)
                Direction = CompassDirections.W;
            else
                Direction--;
        }

        private void SpinRight()
        { 
            if (Direction +1 > CompassDirections.W)
                Direction = CompassDirections.N;
            else
                Direction++;
        }

        private void Move()
        {
            if (Direction == CompassDirections.N)
                Position.Y++;
            else if (Direction == CompassDirections.S)
                Position.Y--;
            else if (Direction == CompassDirections.E)
                Position.X++;
            else if (Direction == CompassDirections.W)
                Position.X--;
        }

        public override string ToString()
        {
            return string.Format("{0} {1} {2}", Position.X, Position.Y, Direction);
        }
    }
}
