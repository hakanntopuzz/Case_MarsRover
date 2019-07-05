using System;
using MarsRover.Business;
using MarsRover.Core.Contracts;
using MarsRover.Core.Domain;
using MarsRover.Core.Enums;

namespace MarsRoverFinal
{
    class Program
    {
        static void Main(string[] args)
        {
            IPlato marsPlato = new Plato(new Coordinate(5, 5));

            Rover rover1 = new Rover(new Coordinate(1, 2), Direction.N);
            var rover1Controller = new RoverController(rover1, marsPlato);
           
            Rover rover2 = new Rover(new Coordinate(3, 3), Direction.E);
            var rover2Controller = new RoverController(rover2, marsPlato);

            rover1Controller.SetCommand("LMLMLMLMM");
            rover2Controller.SetCommand("MMRMMRMRRM");

            var roverSquad = new RoverSquad();
            roverSquad.AddRover(rover1Controller);
            roverSquad.AddRover(rover2Controller);

            foreach (var rover in roverSquad.Rovers)
            {
                roverSquad.ExecuteRover(rover);
                Console.WriteLine(rover.GetPosition());
            }

            Console.ReadLine();
        }
    }
}
