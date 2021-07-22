using System;
namespace MarsRover
{
    public class Rover
    {
        public string Mode { get; set; }
        public int Position { get; set; }
        public int GeneratorWatts { get; set; }

        public Rover(int position, string mode = "NORMAL", int generatorWatts = 110)
        {
            Position = position;
            Mode = mode;
            GeneratorWatts = generatorWatts;
        }

        public void ReceiveMessage(Message message)
        {
            foreach (var item in message.Commands)
            {
                if (item.CommandType == "MOVE")
                {
                    if (this.Mode == "LOW_POWER")
                    {
                        this.Position = this.Position;
                    }
                    else
                    {
                        this.Position = item.NewPosition;
                    }
                }
                else if (item.CommandType == "MODE_CHANGE")
                {
                    this.Mode = item.NewMode;
                }
            }
        }

        public override string ToString()
        {
            return "Position: " + Position + " - Mode: " + Mode + " - GeneratorWatts: " + GeneratorWatts;
        }


        }
}
