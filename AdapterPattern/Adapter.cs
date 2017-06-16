using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterPattern
{
    /// <summary>
    /// The 'Adapter' class
    /// The Adapter is the glue between the Adaptee and the Target.
    /// The Adapter inherits the Target's interface and contains an Adaptee instance to call it's methods.
    /// </summary>
    class Adapter : Target
    {
        private Adaptee _adaptee = new Adaptee();

        public override void Request()
        {
            // Possibly do some other work
            //  and then call SpecificRequest
            _adaptee.SpecificRequest();
        }
    }
}
