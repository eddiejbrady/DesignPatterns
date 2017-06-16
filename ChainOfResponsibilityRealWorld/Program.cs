using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibilityRealWorld
{
    class Program
    {
        /// <summary>
        /// This real-world code demonstrates the Chain of Responsibility pattern in which several linked managers and executives can respond to a purchase request 
        /// or hand it off to a superior.Each position has can have its own set of rules which orders they can approve.
        /// 
        /// MainApp startup class for Real-World 
        /// Chain of Responsibility Design Pattern.
        /// </summary>
        /// <param name="args"></param>
        static void Main()
        {
            // Setup Chain of Responsibility
            Approver larry = new Director();
            Approver sam = new VicePresident();
            Approver tammy = new President();

            larry.SetSuccessor(sam);
            sam.SetSuccessor(tammy);

            // Generate and process purchase requests
            Purchase p = new Purchase(2034, 350.00, "Assets");
            larry.ProcessRequest(p);

            p = new Purchase(2035, 32590.10, "Project X");
            larry.ProcessRequest(p);

            p = new Purchase(2036, 122100.00, "Project Y");
            larry.ProcessRequest(p);

            // Wait for user
            Console.ReadKey();
        }
    }
}
