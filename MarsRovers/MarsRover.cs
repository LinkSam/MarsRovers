using System;

using MarsRovers.Interfaces;
using MarsRovers.Exceptions;

namespace MarsRovers
{
    public class MarsRover : IMarsRover
    {
		public String Instructions { get; set; }

		public IRoverPosition Position { get; set; }

		public IRoverRegion Region { get; set; }

		public String Status { get; set; }

		public String ErrorMessage { get; set; }


		/// <summary>
		/// Constructor for the class
		/// </summary>
		/// <param name="region"></param>
		/// <param name="startPosition"></param>
		/// <param name="instructions"></param>
		public MarsRover(IRoverRegion region, IRoverPosition startPosition, String instructions)
		{
			if (region.IsWithinRegion(startPosition.X, startPosition.Y))
			{
				Region = region;
				Position = startPosition;
				Instructions = instructions;

				Status = "Ready";
				ErrorMessage = "";
			}
			// handles a bad Rover Start Position initialization
			else
			{
				throw new RoverStartPositionBadInitializationException();
			}
		}

		/// <summary>
		/// Handles the displacement of the rover within the region defined
		/// </summary>
		public void Displace()
		{
			// process each instruction
			for (int i = 0; i < Instructions.Length; i++)
			{
				switch (Instructions[i].ToString().ToUpper())
				{
					case "M":
						
						try
						{
							Position.MoveForward(Region);
						}
						// catch if the rover goes out of limit...
						catch (RoverOutOfRegionException ex) {
							ErrorMessage = ex.Message;
							this.Status = "Failed";

							// if so, breaks the processing of remaining instructions
							return;
						}

						break;
					case "L":
						Position.TurnLeft();
						break;
					case "R":
						Position.TurnRight();
						break;
					default:
						// other instructions are simply ignored
						break;
				}
			}

			this.Status = "Success";
		}

	}
}
