using System;
using System.Collections.Generic;
using MarsRover;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MarsRoverTests
{
    [TestClass]
    public class RoverTests
    {
        //TEST8******
        [TestMethod]
        public void ConstructorSetsDefaultPosition()
        {
            Rover newPosition = new Rover(5);
            Assert.AreEqual(newPosition.Position, 5);

        }
        [TestMethod]
        public void ConstructorSetsDefaultMode()
        {
            Rover newMode = new Rover(5);
            Assert.AreEqual(newMode.Mode, "NORMAL");
        }
        [TestMethod]
        public void ConstructorSetsDefaultGeneratorWatts()
        {
            Rover newWatts = new Rover(5, "LOW_POWER");
            Assert.AreEqual(newWatts.GeneratorWatts, 110);
        }
        [TestMethod]
        public void RespondsCorrectlyToModeChangeCommand()
        {
            Rover newMode = new Rover(5, "LOW_POWER");
            Assert.AreEqual(newMode.Mode, "LOW_POWER");
        }
        [TestMethod]
        public void DoesNotMoveInLowPower()
        {
            Rover myRover = new Rover(5);
            Command[] commands = { new Command("MODE_CHANGE", "LOW_POWER"), new Command("MOVE", 5000) };
            Message newMessage = new Message("Test message with one command", commands);
            myRover.ReceiveMessage(newMessage);
            Assert.AreEqual(myRover.Position, 5);
        }
        [TestMethod]
        public void PositionChangesFromMoveCommand()
        {
            Rover myRover = new Rover(5);
            Command[] commands = { new Command("MOVE", 5000) };
            Message newMessage = new Message("Test message with one command", commands);
            myRover.ReceiveMessage(newMessage);
            Assert.AreEqual(myRover.Position, 5000);
        }



    }

}
