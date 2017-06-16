using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgePattern
{
    /// <summary>
    /// The 'ConcreteImplementorB' class
    /// Implementation of the bridge interface
    /// 
    /// implements the Implementor interface and defines its concrete implementation.
    /// </summary>
    class ConcreteImplementorB : Implementor
    {
        public override void Operation()
        {
            Console.WriteLine("ConcreteImplementorB Operation");
        }
    }
}
