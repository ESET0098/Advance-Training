using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Simple1
{
    internal class Rectangle
    {
        public int l;
        public int b;
        public int area1;

        public Rectangle()
        {
            l = 0;
            b = 0;
            area1 = 0;
        }
        public Rectangle(int l, int b,int area1)
        {
            this.l = l;
            this.b = b;
            this.area1 = area1;
        }

        public Rectangle(int l, int b)
        {
            this.l = l;
            this.b = b;
            
        }

        public void input()
        {
            Console.WriteLine("length");
            l = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Breath");
            b = Convert.ToInt32(Console.ReadLine());
        }

        public int area()
        {
            return l * b;
        }

        public static int total(Rectangle r1, Rectangle r2)
        {
            return r1.area() + r2.area();
        }

        public Rectangle sumofArea(Rectangle r)
        {
            Rectangle r3 = new Rectangle();
            r3.area1 = r.area() + area();
            return r3;
        }

        public static double operator +(Rectangle r1, Rectangle r2)
        {
            
            return r1.area() + r2.area();
        }

        public static double operator -(Rectangle r1, Rectangle r2)
        {

            return r1.area() - r2.area();
        }

    }
     



    
}