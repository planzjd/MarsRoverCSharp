using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MarsRover;

namespace MarsRoverTests
{
    //TEST5******
    [TestClass]
    public class MessageTests
    {
        Command[] commands = { new Command("foo", 0), new Command("bar", 20) };

        [TestMethod]
        public void ArgumentNullExceptionThrownIfNameNotPassedToConstructor()
        {
            try
            {
                new Message("New Rover", commands);
            }
            catch (ArgumentNullException ex)
            {
                Assert.AreEqual("Message required.", ex.Message);
            }
        }

        //TEST6******
        [TestMethod]
        public void ConstructorSetsName()
        {
            Message message1 = new Message("Josh", commands);

            Assert.IsTrue("Josh" == message1.Name);

            Assert.AreEqual("Josh", message1.Name);
        }

        //TEST7******
        [TestMethod]
        public void ConstructorSetsCommandsField()
        {
            Message message1 = new Message("Josh", commands);

            Assert.AreEqual(commands, message1.Commands);
        }
    }

}