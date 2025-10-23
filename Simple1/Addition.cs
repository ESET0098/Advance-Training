using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simple1
{
    internal class Addition
    {
        public int a; public int b; public int c;

        public virtual int sum(int a, int b, int c)
        {
            return a + b + c;
        }
    }
    class Addi:Addition{

        public override int  sum(int a ,int b,int c)
        {
            return (a + b + c) / 3;
        }


        }

}
