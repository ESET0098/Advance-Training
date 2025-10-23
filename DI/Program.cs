using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DI
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //ReportingService reportingService = new ReportingService(new HtmlReportGenerator());

            //reportingService.CreateReport("Sample Report Data");


            //ReportingService reportingService = new ReportingService();

            //reportingService.ReportGenerator = new PdfReportGenerator();
            //reportingService.CreateCustomerReport("Customer Report Data");


            Notification notification = new Notification();

            //notification.setNotificationMethod(new EmailMessage());

            notification.setNotificationMethod(new SMSMessage());  
            notification.SendNotification("Hello Dependency Injection!");

        }
    }
}
