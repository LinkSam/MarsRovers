using MarsRovers.Interfaces;
using MarsRovers.Exceptions;

namespace MarsRovers
{
    public class RoverRegion : IRoverRegion
    {
        public int Width { get; set; }
        public int Height { get; set; }

        /// <summary>
        /// Constructor of the class
        /// </summary>
        /// <param name="width">Width of the region for the rover</param>
        /// <param name="height">Height of the region for the rover</param>
        public RoverRegion(int width, int height) {
            if (width >= 0 && height >= 0)
            {
                Width = width;
                Height = height;
            }
            // handles a bad Rover Region initialization
            else {
                throw new RoverRegionBadInitializationException();
            }
        }

        /// <summary>
        /// Returns true when the coordinates are within the rover region
        /// </summary>
        /// <param name="x">X coordinate</param>
        /// <param name="y">Y coordinate</param>
        /// <returns></returns>
        public bool IsWithinRegion(int x, int y)
        {
            return (x >= 0 && x <= this.Width) && (y >= 0 && y <= this.Height);
        }
    }
}
