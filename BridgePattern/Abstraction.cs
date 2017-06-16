using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgePattern
{
    /// <summary>
    /// The 'Abstraction' class
    /// This is the interface that the client sees.
    /// It contains a field/attribute of type "Bridge" and it receives the bridge in it's constructor or
    /// it could be set as a property as in the below example.
    /// 
    /// defines the abstraction's interface.
    /// maintains a reference to an object of type Implementor.
    /// </summary>
    class Abstraction
    {
        protected Implementor implementor;

        //public Abstraction(Bridge implementation)
        //{
        //    implementor = implementation;
        //}

        // Property
        public Implementor Implementor
        {
            set { implementor = value; }
        }

        public virtual void Operation()
        {
            implementor.Operation();
        }
    }
}
