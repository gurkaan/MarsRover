using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarsRoverProject
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Test Input:\n");
            Console.WriteLine("5 5");
            Console.WriteLine("1 2 N");
            Console.WriteLine("LMLMLMLMM");
            Console.WriteLine();
            Console.WriteLine("3 3 E");
            Console.WriteLine("MMRMMRMRRM");
            Console.WriteLine();

            Plateau plateau = new Plateau(new Position(5, 5)); //(5,5) Rectangle Plateau

            Rover firstRover = new Rover(plateau, new Position(1, 2), CompassDirections.N); //First rover
            firstRover.Operation("LMLMLMLMM");

            Rover secondRover = new Rover(plateau, new Position(3, 3), CompassDirections.E); //Second rover
            secondRover.Operation("MMRMMRMRRM");

            Console.WriteLine("Expected Output:\n");
            Console.WriteLine(firstRover.ToString());
            Console.WriteLine(secondRover.ToString());
            Console.WriteLine();

            Console.ReadLine();

        }
    }
}
