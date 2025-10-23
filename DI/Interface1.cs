using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DI
{
    public  interface Message 
    {
        void Send(string msg);
    }
    public class EmailMessage : Message
    {
        public void Send(string msg)
        {
            Console.WriteLine("Email Message Sent: " + msg);
        }
    }

    public class SMSMessage : Message
    {
        public void Send(string msg)
        {
            Console.WriteLine("SMS Message Sent: " + msg);
        }
    }
}
