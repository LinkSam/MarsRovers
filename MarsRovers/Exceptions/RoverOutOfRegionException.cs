using System;

namespace MarsRovers.Exceptions
{
    public class RoverOutOfRegionException: Exception
    {
        
        public RoverOutOfRegionException()
            : base("Rover tried to move out of the region predefined, please review the instructions given to the Rover.")
        {
        }
    }
}
