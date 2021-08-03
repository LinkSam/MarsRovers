# MarsRovers

Design and Assumptions
		Solution proposed was design using OOP and tried to follow SOLID principles.
		Solution proposed leave the processing of each rover to the class MarsRover. 
		The processing of a set of rovers sharing the same region is done through the iteration of such set executing the appropriate methods defined.
		Defined a couple of custom exceptions to handle some errors that might appear.
		
		Solution was developed using Visual Studio 2019 targeting .NET Framework 4.5
		Solution is composed by three projects:
		
			* A class Library with the core clases to solve the problem
			* A web site to ease the input for customized tests.
			* A unit testing project with few unit tests to ensure 
		
		Some assumptions related to the problem:
			* The region for rover operation should be at least (0,0) [a region with an are of zero]
			* A region definition with negative values should not be allowed
			* Start point should be within the region defined
			* A start point definition with negative values should not be allowed
			* Rover should not go outside of the region
			* N,S,W,E are the only possible values for Heading (case insensitive)
			* Only allowed instructions are M (Move forward), L (turn left) and R (turn right)
			* An empty list of instructions is allowed, that is the rover is left at its start position.
			* Even it might no be physically possible that two rovers can be at the same position at the same time within the same region, this behavior is not prevented by the solution proposed.
	
	Custom input
		A single-page web site is provided to easy the input of custom tests.
		UI is quite simple and could be improved but tried to make it as usable and simple as possible.
		To use it for custom tests it is only required to run the solution and the web site will be shown.
		There is no need to to have IIS installed.
		This UI was built using MVC, JQuery and a little of bootstrap
		
		NOTE: It might require to accept the use of a custom SSL certificate even it is not used within the solution. It is due to a default setting on the VS template used.
		
		Package Restore
		
		Due to the fact that all exe and dll files were removed it is necessary to execute the following command to restore the missing packages
			
			update-package Microsoft.CodeDom.Providers.DotNetCompilerPlatform
			
		to do so, open the Nuget Packages Manager CLI at Tools menu