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

namespace Inheritance
{
    //Create a system for modeling vehicles of different types, such as cars, motorcycles, and trucks.
    //Design the system to capture unique characteristics and functionalities of each vehicle type.
    //Implement features for simulating vehicle operations like acceleration, braking, and steering
    //Implement a system for managing inventory levels, stock replenishment, and product tracking.Abstract the intricacies of inventory management processes, providing an intuitive interface for users to manage inventory efficiently.
    //Develop a transportation management system for managing different modes of transportation such as buses, trains, and airplanes.Utilize abstraction to define a common TransportationMode interface with methods for booking tickets, checking schedules, and calculating fares.Implement concrete classes for each transportation mode that implement the TransportationMode interface.
   
  
    public  class vechile
    {
        public  virtual void Acceleration()
        {
            
        }
        public virtual void steering()
        {
            
        }
        
    }
    public class cars : vechile
    {
        public override void Acceleration()
        {
            base.Acceleration();
            Console.WriteLine("car ace");

        }

    }
    public class motor : vechile
    {
        public override void steering()
        {
            base.steering();
            Console.WriteLine("ram");
        }
    }
    public class solution
    {
        static void Main(string[] args)
        {
            vechile vechile = new cars();
            vechile.Acceleration();
            vechile vechile1 = new motor();
            vechile1.steering();
            vechiles v=new car();
            v.rent();
        }
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
            Console.WriteLine(amount+1);
        }
    }
    public class motor1 : vechiles
    {
        public override void rent()
        {
            base.rent();
            Console.WriteLine(amount+2);
        }
    }
    
}
