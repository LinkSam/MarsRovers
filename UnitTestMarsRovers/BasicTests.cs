using Microsoft.VisualStudio.TestTools.UnitTesting;

using MarsRovers;
using MarsRovers.Interfaces;

namespace UnitTestMarsRovers
{
    [TestClass]
    public class BasicTests
    {
        [TestMethod]
        public void BasicTest1()
        {
            IMarsRover myRover = new MarsRover(new RoverRegion(5, 5), new RoverPosition(1, 2, 'N'), "LMLMLMLMM");
            myRover.Displace();

            Assert.AreEqual("1 3 N", myRover.Position.ToString());
        }

        [TestMethod]
        public void BasicTest2()
        {
            IMarsRover myRover = new MarsRover(new RoverRegion(5, 5), new RoverPosition(3, 3, 'E'), "MMRMMRMRRM");
            myRover.Displace();

            Assert.AreEqual("5 1 E", myRover.Position.ToString());
        }
    }
}
