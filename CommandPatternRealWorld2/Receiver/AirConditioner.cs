using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CommandPatternRealWorld2.Receiver
{
    public class AirConditioner
    {
        public void TurnOn()
        {
            Console.WriteLine("Air Conditioner is on!");
        }

        public void TurnOff()
        {
            Console.WriteLine("Air Conditioner is off!");
        }

        public void IncreaseTemp()
        {
            Console.WriteLine("Increasing Temperature");
        }

        public void DecreaseTemp()
        {
            Console.WriteLine("Decreasing Temperature");
        }
    }
}
