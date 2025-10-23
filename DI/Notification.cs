using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DI
{
    public  class Notification
    {

        private  Message _message;

        public void setNotificationMethod(Message message)
        {
            _message = message;
        }
        public void SendNotification(string msg)
        {
            _message.Send(msg);
        }
    }
}
