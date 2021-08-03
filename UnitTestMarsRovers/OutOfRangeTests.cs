using Microsoft.VisualStudio.TestTools.UnitTesting;

using MarsRovers;
using MarsRovers.Interfaces;
using MarsRovers.Exceptions;

namespace UnitTestMarsRovers
{
    [TestClass]
    public class OutOfRangeTests
    {
        // To test cases when the rover try to move out of the region limits

        [TestMethod]
        public void SimpleOutOfRangeTest()
        {
            IMarsRover myRover = new MarsRover(new RoverRegion(1,1), new RoverPosition(1,1, 'N'), "M");
            myRover.Displace();

            RoverOutOfRegionException outOfRegionEx = new RoverOutOfRegionException();
            Assert.AreEqual(myRover.ErrorMessage, outOfRegionEx.Message);

        }

    }
}
