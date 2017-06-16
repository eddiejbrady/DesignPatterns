using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CommandPatternRealWorld2.Receiver;
using CommandPatternRealWorld2.AbstractCommand;

namespace CommandPatternRealWorld2.ConcreteCommand
{
    public class LightOff : ICommand
    {        
        Light light;

        public LightOff(Light light)
        {
            this.light = light;
        }

        public void Execute()
        {
            light.Off();
        }
    }
}
