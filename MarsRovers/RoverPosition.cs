using MarsRovers.Interfaces;
using MarsRovers.Exceptions;

namespace MarsRovers
{
	public class RoverPosition : IRoverPosition
	{
		public int X { get; set; }
		public int Y { get; set; }
		public char Heading { get; set; }

		/// <summary>
		/// Constructor for the class
		/// </summary>
		/// <param name="x">X coordinate within the region for the rover</param>
		/// <param name="y">Y corrdinate within the region for the rover</param>
		/// <param name="heading">Heding/direction of the rover</param>
		public RoverPosition(int x, int y, char heading)
		{
			X = x;
			Y = y;
			Heading = heading;
		}

		/// <summary>
		/// Handles the Move Forward instruction for the rover
		/// </summary>
		/// <param name="region"></param>
		public void MoveForward(IRoverRegion region)
		{
			IRoverPosition auxPosition = new RoverPosition(this.X, this.Y, this.Heading);
			
			switch (this.Heading)
			{
				case 'N':
					auxPosition.Y += 1;
					break;
				case 'S':
					auxPosition.Y -= 1;
					break;
				case 'E':
					auxPosition.X += 1;
					break;
				case 'W':
					auxPosition.X -= 1;
					break;
			}

			if (region.IsWithinRegion(auxPosition.X, auxPosition.Y))
			{
				this.X = auxPosition.X;
				this.Y = auxPosition.Y;
			}
			else 
			{
				throw new RoverOutOfRegionException();
			}
		}

		/// <summary>
		/// Handles the Turn Left instruction for the rover
		/// </summary>
		public void TurnLeft()
		{
			switch (this.Heading)
			{
				case 'N':
					this.Heading = 'W';
					break;
				case 'S':
					this.Heading = 'E';
					break;
				case 'E':
					this.Heading = 'N';
					break;
				case 'W':
					this.Heading = 'S';
					break;
			}
		}

		/// <summary>
		/// Handles the Turn Right instruction for the rover
		/// </summary>
		public void TurnRight()
		{
			switch (this.Heading)
			{
				case 'N':
					this.Heading = 'E';
					break;
				case 'S':
					this.Heading = 'W';
					break;
				case 'E':
					this.Heading = 'S';
					break;
				case 'W':
					this.Heading = 'N';
					break;
			}
		}

		/// <summary>
		/// Retuns the String representation of the class
		/// </summary>
		/// <returns></returns>
		public override string ToString()
		{
			return this.X.ToString() + " " + this.Y.ToString() + " " + this.Heading.ToString();
		}
	}

}
