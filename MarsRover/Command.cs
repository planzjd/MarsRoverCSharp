using System;
namespace MarsRover
{
    public class Command
    {
        public string CommandType { get; set; }
        public int NewPosition { get; set; }
        public string NewMode { get; set; }
        //public string ReceiveMessage { get; set; }


        public Command() { }
        //New Mode
        public Command(string commandType)
        {
            CommandType = commandType;
            if (String.IsNullOrEmpty(commandType))
            {
                throw new ArgumentNullException(commandType, "Command type required.");
            }
        }
        //New Position 
        public Command(string commandType, int value)
        {
            CommandType = commandType;
            if (String.IsNullOrEmpty(commandType))
            {
                throw new ArgumentNullException(commandType, "Command type required.");
            }
            NewPosition = value;
        }
        public Command(string commandType, string newMode)
        {
            CommandType = commandType;
            if (String.IsNullOrEmpty(commandType))
            {
                throw new ArgumentNullException(commandType, "Command type required.");
            }
             NewMode = newMode;
            if (String.IsNullOrEmpty(newMode))
            {
                throw new ArgumentNullException(commandType, "Command type required.");
            }
        }


    }
}
