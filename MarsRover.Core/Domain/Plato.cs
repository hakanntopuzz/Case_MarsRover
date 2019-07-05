using MarsRover.Core.Contracts;

namespace MarsRover.Core.Domain
{
    public class Plato : IPlato
    {
        public Coordinate Coordinate { get; set; }
        public Plato(Coordinate coordinate)
        {
            Coordinate = coordinate;
        }
    }
}
