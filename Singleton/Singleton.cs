using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton
{
    public sealed class Singleton
    {
        private static Singleton instance = null;

        private Singleton()
        {
        }

        public static Singleton Instance
        {
            get
            {
                // Lazy initialization object creation only when instance is requested for the first time
                if (instance == null)
                {
                   instance =  new Singleton();
                }
                return instance;
            }
        }

        public void showMessage()
        {
            Console.WriteLine("Hello from Singleton!");
        }

        public void add(int a, int b)
        {
            Console.WriteLine("Sum: " + (a + b));
        }
    }
}
