using System;

namespace MarsRovers.Interfaces
{
    public interface IMarsRover
    {
        String Instructions { get; set; }
        IRoverPosition Position { get; set; }

        IRoverRegion Region { set; get; }

        String Status { get; set; }

        String ErrorMessage { get; set; }

        void Displace();
    }
}
