using MarsRover.Core.Domain;
using MarsRover.Core.Enums;

namespace MarsRover.Core.Contracts
{
    public interface IRover
    {
        Coordinate Coordinate { get; set; }
        Direction Direction { get; set; }
    }
}