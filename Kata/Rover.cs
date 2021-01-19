using System;
using System.Collections.Generic;
using System.Drawing;

namespace Kata
{
    public class Rover
    {
        private readonly Dictionary<string, Action> _commands;
        private Planet _planet;
        private Status _status;

        public Rover()
        {
            _commands = new Dictionary<string, Action>
            {
                ["l"] = CommandTurnLeft,
                ["r"] = CommandTurnRight
            };
        }

        public void Land(Planet planet)
        {
            _planet = planet;
            _status = new Status(new Point(0,0), Orientation.North);
        }

        public Status Command(string parameter)
        {
            if (_commands.TryGetValue(parameter, out var handle))
            {
                handle();
            }

            return _status;
        }

        private void CommandTurnLeft()
        {
            _status = _status = new Status(new Point(0,0), Orientation.West);
        }

        private void CommandTurnRight()
        {
            _status = _status = new Status(new Point(0,0), Orientation.East);
        }
    }
}