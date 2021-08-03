using System;

namespace MarsRovers.Exceptions
{
    public class RoverRegionBadInitializationException : Exception
    {
        
        public RoverRegionBadInitializationException()
            : base("Bad rover region initialization. Region must be initialized with positive numbers.")
        {
        }
    }
}
