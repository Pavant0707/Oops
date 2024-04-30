using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface
{
    //Design a training program for employees with different job roles and skill levels.Provide a flexible training interface that can accommodate different training methods, formats, and delivery mechanisms.
   
    public interface ITrainingMethod
    {
        void learn();
    }
    public interface ITrainingFormat
    {
        void learn();
    }
    public class Trine:ITrainingMethod
    {
       public void learn()
        {
            Console.WriteLine("hands on");
        }
    }
    public class Employee:ITrainingFormat
    {
        public void learn()
        {
            Console.WriteLine("fgjg");
        }
    }
    public class sol
    {
        static void Main(string[] args)
        {
             ITrainingFormat f=new Employee();
            f.learn();

        }
    }
}
