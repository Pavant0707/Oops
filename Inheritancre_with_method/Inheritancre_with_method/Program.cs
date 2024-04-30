using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritancre_with_method
{
    public class Employee
    {
        public int ID {  get; set; }
        public string Name { get; set; }
        public int salary {  get; set; }
       public virtual void Display()
        {
            Console.WriteLine("ID "+ID+" Name "+Name+"salary"+salary);
        }
    }
    public class Manager : Employee
    {
        public override void Display()
        {
            base.Display();
            Console.WriteLine("Manager "+"ID "+ID+" name "+Name);
        }
    }
    public  class Developer: Employee
    {
        public override void Display()
        {
            base.Display();
            Console.WriteLine("Devel "+"Id "+ID+ " name"+Name);
        }
    }
    public class solution
    {
        static void Main(string[] args)
        {
            Manager manager = new Manager
            {
                Name = "Ram",
                 ID = 1,
                 salary=10000,
            };
            manager.Display();
            Developer developer = new Developer()
            {
                Name = "sai",
                ID=2,
                salary=1000000,
            };
            developer.Display();

        }
    }
}
