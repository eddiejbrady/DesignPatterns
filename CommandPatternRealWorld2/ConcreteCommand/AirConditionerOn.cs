using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CommandPatternRealWorld2.AbstractCommand;
using CommandPatternRealWorld2.Receiver;

namespace CommandPatternRealWorld2.ConcreteCommand
{
    class AirConditionerOn: ICommand
    {
        AirConditioner ac;

        public AirConditionerOn(AirConditioner ac)
        {
            this.ac = ac;
        }

        //MACRO!
        public void Execute()
        {
            ac.TurnOn();
            ac.IncreaseTemp();
            //...
        }
    }
}
