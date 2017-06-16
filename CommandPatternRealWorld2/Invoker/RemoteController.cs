using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CommandPatternRealWorld2.AbstractCommand;

namespace CommandPatternRealWorld2.Invoker
{
    public class RemoteController
    {
        private IList<ICommand> turnOnCommands = new List<ICommand>(); // AC ON, LIGHT ON
        private IList<ICommand> turnOffCommands = new List<ICommand>(); // AC OFF, LIGHT OFF

        public void InsertNewOnCommand(ICommand command)
        {
            turnOnCommands.Add(command);
        }

        public void InsertNewOffCommand(ICommand command)
        {
            turnOffCommands.Add(command);
        }

        public void PressButtonOn(int buttonNumber)
        {
            turnOnCommands[buttonNumber].Execute();
        }

        public void PressButtonOff(int buttonNumber)
        {
            turnOffCommands[buttonNumber].Execute();
        }

    }
}
