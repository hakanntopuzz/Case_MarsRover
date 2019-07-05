using MarsRover.Business;
using MarsRover.Core.Contracts;
using MarsRover.Core.Domain;
using MarsRover.Core.Enums;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MarsRover.Test
{
    [TestClass]
    public class MarsRoverTests
    {
        [TestMethod]
        public void PlatoSizeTest()
        {
            IPlato marsPlato = new Plato(new Coordinate(5, 5));

            Assert.IsTrue(marsPlato.Coordinate.CoordinateY == 5 && marsPlato.Coordinate.CoordinateX == 5);
        }

        [TestMethod]
        public void RoverCoordinateTest1()
        {
            IPlato marsPlato = new Plato(new Coordinate(5, 5));
            Rover rover1 = new Rover(new Coordinate(1, 2), Direction.N);
            var rover1Controller = new RoverController(rover1, marsPlato);
            rover1Controller.SetCommand("LMLMLMLMM");

            var roverSquad = new RoverSquad();
            roverSquad.AddRover(rover1Controller);

            roverSquad.ExecuteRoverCommand(rover1Controller);

            Assert.IsTrue(rover1.Coordinate.CoordinateX == 1 && rover1.Coordinate.CoordinateY == 3);
        }

        [TestMethod]
        public void RoverDirectionTest1()
        {
            IPlato marsPlato = new Plato(new Coordinate(5, 5));
            Rover rover1 = new Rover(new Coordinate(1, 2), Direction.N);
            var rover1Controller = new RoverController(rover1, marsPlato);
            rover1Controller.SetCommand("LMLMLMLMM");

            var roverSquad = new RoverSquad();
            roverSquad.AddRover(rover1Controller);

            roverSquad.ExecuteRoverCommand(rover1Controller);

            Assert.IsTrue(rover1.Direction == Direction.N);
        }

        [TestMethod]
        public void RoverCoordinateTest2()
        {
            IPlato marsPlato = new Plato(new Coordinate(5, 5));
            Rover rover2= new Rover(new Coordinate(3, 3), Direction.E);
            var rover2Controller = new RoverController(rover2, marsPlato);
            rover2Controller.SetCommand("MMRMMRMRRM");

            var roverSquad = new RoverSquad();
            roverSquad.AddRover(rover2Controller);

            roverSquad.ExecuteRoverCommand(rover2Controller);

            Assert.IsTrue(rover2.Coordinate.CoordinateX == 5 && rover2.Coordinate.CoordinateY == 1);
        }

        [TestMethod]
        public void RoverDirectionTest2()
        {
            IPlato marsPlato = new Plato(new Coordinate(5, 5));
            Rover rover2 = new Rover(new Coordinate(3, 3), Direction.E);
            var rover2Controller = new RoverController(rover2, marsPlato);
            rover2Controller.SetCommand("MMRMMRMRRM");

            var roverSquad = new RoverSquad();
            roverSquad.AddRover(rover2Controller);

            roverSquad.ExecuteRoverCommand(rover2Controller);

            Assert.IsTrue(rover2.Direction == Direction.E);
        }


    }
}
