using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPS
{
    interface IDriveable
    {
        void Drive();
    }
    class Car : IDriveable
    {
        public void Drive()
        {
            Console.WriteLine("Car is Driving");
        }
    }

    class Bike : IDriveable {

        public void Drive()
        {
            Console.WriteLine("Bike");
        }
    }

        

    internal class Program
    {
        static void Main(string[] args)
        {
            Bike bike = new Bike();
            bike.Drive();
        }
    }
}
