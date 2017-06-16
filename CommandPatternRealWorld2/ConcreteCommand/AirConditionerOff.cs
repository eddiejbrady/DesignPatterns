using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CommandPatternRealWorld2.AbstractCommand;
using CommandPatternRealWorld2.Receiver;

namespace CommandPatternRealWorld2.ConcreteCommand
{
    class AirConditionerOff : ICommand
    {
        AirConditioner ac;

        public AirConditionerOff(AirConditioner ac)
        {
            this.ac = ac;
        }

        public void Execute()
        {
            ac.DecreaseTemp();
            ac.TurnOff();
        }
    }
}
