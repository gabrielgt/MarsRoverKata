using System.Drawing;

namespace Kata
{
    public readonly struct Status
    {
        public Status(Point coordinate, Orientation orientation)
        {
            Coordinate = coordinate;
            Orientation = orientation;
        }


        public Point Coordinate{ get; }
        public Orientation Orientation { get; }
    }
}