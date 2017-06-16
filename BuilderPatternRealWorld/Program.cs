using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPatternRealWorld
{
    class Program
    {
        /// <summary>
        /// Entry point into console application.
        /// 
        /// This real-world code demonstates the Builder pattern in which different vehicles are assembled in a step-by-step fashion. 
        /// The Shop uses VehicleBuilders to construct a variety of Vehicles in a series of sequential steps.
        /// 
        /// </summary>
        public static void Main()
        {
            VehicleBuilder builder;

            // Create shop with vehicle builders
            Shop shop = new Shop();

            // Construct and display vehicles
            builder = new ScooterBuilder();
            shop.Construct(builder);
            builder.Vehicle.Show();

            builder = new CarBuilder();
            shop.Construct(builder);
            builder.Vehicle.Show();

            builder = new MotorCycleBuilder();
            shop.Construct(builder);
            builder.Vehicle.Show();

            // Wait for user
            Console.ReadKey();
        }
    }
}
