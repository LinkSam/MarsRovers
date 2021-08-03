
namespace MarsRovers.Interfaces
{
    public interface IRoverPosition
    {
        int X { get; set; }
        int Y { get; set; }
        char Heading { get; set; }

        void MoveForward(IRoverRegion region);
        void TurnLeft();
        void TurnRight();
    }
}
