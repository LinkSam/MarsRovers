using System;

namespace MarsRovers.Exceptions
{
    public class RoverStartPositionBadInitializationException : Exception
    {
        
        public RoverStartPositionBadInitializationException()
            : base("Bad rover's start positiion initialization. Start position must be within rover's region defined.")
        {
        }
    }
}
