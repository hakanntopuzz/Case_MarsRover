namespace MarsRover.Core.Domain
{
    public class Coordinate
    {
        public int CoordinateX { get; set; }
        public int CoordinateY { get; set; }

        public Coordinate(int coordinateX, int coordinateY)
        {
            CoordinateX = coordinateX;
            CoordinateY = coordinateY;
        }
    }
}
