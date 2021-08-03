using Microsoft.VisualStudio.TestTools.UnitTesting;

using MarsRovers;
using MarsRovers.Interfaces;

namespace UnitTestMarsRovers
{
    [TestClass]
    public class InvalidInstructionsTests
    {
        // To test instructions that are not valid
        // only valid instructions are M, L and R
        // rover should ignore invalid instructions

        [TestMethod]
        public void InvInstTest1()
        {
            IMarsRover myRover = new MarsRover(new RoverRegion(5,5), new RoverPosition(1, 2, 'N'), "CLMLMALMLMMX");
            myRover.Displace();

            Assert.AreEqual("1 3 N", myRover.Position.ToString());
        }

        [TestMethod]
        public void InvInstTest2()
        {
            IMarsRover myRover = new MarsRover(new RoverRegion(5, 5), new RoverPosition(3, 3, 'E'), "XXMMRMAMRMRRCM");
            myRover.Displace();

            Assert.AreEqual("5 1 E", myRover.Position.ToString());
        }
    }
}
