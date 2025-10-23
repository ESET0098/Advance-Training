using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simple1
{
    internal interface Interface1
    { void show();
        void clas();
        
    }
    class A : Interface1
    {
        public void show()
        {
            Console.WriteLine("A show");
        }
        public void clas()
        {
            Console.WriteLine("A class");
        }
    }
    class B : Interface1
    {
        public  void show()
        {
            Console.WriteLine("B show");
        }

        public void clas()
        {
            Console.WriteLine("B class");
        }
    }
}
