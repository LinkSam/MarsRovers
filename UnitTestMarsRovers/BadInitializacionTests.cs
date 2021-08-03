using Microsoft.VisualStudio.TestTools.UnitTesting;

using MarsRovers;
using MarsRovers.Interfaces;
using MarsRovers.Exceptions;
using System;

namespace UnitTestMarsRovers
{
    [TestClass]
    public class BadInitializacionTests
    {
        // To test cases when the rover try to initialize some properties with wrong values.

        [TestMethod]
        public void BadRegionInitializacionTest()
        {
            try
            {
                IMarsRover myRover = new MarsRover(new RoverRegion(-1, -1), new RoverPosition(0, 0, 'N'), "M");
            }
            catch (Exception ex) {
                RoverRegionBadInitializationException badInitEx = new RoverRegionBadInitializationException();
                Assert.AreEqual(ex.Message, badInitEx.Message);
            }


        }

        [TestMethod]
        public void BadStartPositionInitializacionTest1()
        {
            try
            {
                IMarsRover myRover = new MarsRover(new RoverRegion(5, 5), new RoverPosition(-1, -1, 'N'), "M");
            }
            catch (Exception ex)
            {
                RoverStartPositionBadInitializationException badInitEx = new RoverStartPositionBadInitializationException();
                Assert.AreEqual(ex.Message, badInitEx.Message);
            }


        }

        [TestMethod]
        public void BadStartPositionInitializacionTest2()
        {
            try
            {
                IMarsRover myRover = new MarsRover(new RoverRegion(5, 5), new RoverPosition(0, -1, 'N'), "M");
            }
            catch (Exception ex)
            {
                RoverStartPositionBadInitializationException badInitEx = new RoverStartPositionBadInitializationException();
                Assert.AreEqual(ex.Message, badInitEx.Message);
            }


        }

        [TestMethod]
        public void BadStartPositionInitializacionTest3()
        {
            try
            {
                IMarsRover myRover = new MarsRover(new RoverRegion(5, 5), new RoverPosition(-1, 0, 'N'), "M");
            }
            catch (Exception ex)
            {
                RoverStartPositionBadInitializationException badInitEx = new RoverStartPositionBadInitializationException();
                Assert.AreEqual(ex.Message, badInitEx.Message);
            }


        }

    }
}
