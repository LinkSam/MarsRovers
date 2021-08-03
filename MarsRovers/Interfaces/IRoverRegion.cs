
namespace MarsRovers.Interfaces
{
    public interface IRoverRegion
    {
        int Width { get; set; }
        int Height { get; set; }

        bool IsWithinRegion(int x, int y);
    }
}
