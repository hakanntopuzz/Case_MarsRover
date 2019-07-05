using MarsRover.Core.Contracts;
using MarsRover.Core.Enums;

namespace MarsRover.Core.Domain
{
    public class Rover : IRover
    {

        public Rover(Coordinate coordinate, Direction direction)
        {
            Coordinate = coordinate;
            this.Direction = direction;
        }

        public Coordinate Coordinate { get; set; }
        public Direction Direction { get; set; }
    }
}
