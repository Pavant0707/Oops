using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace Polym
{
    class solution
    {
        static void Main(string[] args)
        {

            vechiles v = new car();
            v.rent();
        }

        //Create a vehicle rental system with classes representing different types of vehicles(e.g., car, motorcycle, truck).
        //Utilize polymorphism to define a common Rent() method in a base Vehicle class and override this method in derived classes to handle specific rental procedures.
        public class vechiles
        {
            public int amount = 1;
            public virtual void rent()
            {
                Console.WriteLine("---------");

            }

        }
        public class car : vechiles
        {
            public override void rent()
            {
                base.rent();
                Console.WriteLine(amount + 1);
            }
        }
        public class motor1 : vechiles
        {
            public override void rent()
            {
                base.rent();
                Console.WriteLine(amount + 2);
            }
        }
    }
}

