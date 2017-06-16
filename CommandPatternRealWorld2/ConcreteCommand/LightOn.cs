using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CommandPatternRealWorld2.AbstractCommand;
using CommandPatternRealWorld2.Receiver;

namespace CommandPatternRealWorld2.ConcreteCommand
{
    public class LightOn : ICommand
    {
        Light light;

        public LightOn(Light light)
        {
            this.light = light;
        }

        public void Execute()
        {
            light.On();
        }
    }
}
