using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgePattern
{
    /// <summary>
    /// The 'Implementor' abstract class
    /// This is the "Bridge"
    /// The Bridge defines the parts of the Abstraction that might vary between the concrete implementations.
    /// 
    /// defines the interface for implementation classes. 
    /// This interface doesn't have to correspond exactly to Abstraction's interface; in fact the two interfaces 
    /// can be quite different. Typically the Implementation interface provides only primitive operations, 
    /// and Abstraction defines higher-level operations based on these primitives.
    /// </summary>
    abstract class Implementor
    {
        public abstract void Operation();
    }
}
