using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DI
{
    public  class ReportingService
    {

        // Implementation using Constructor Injection

        //private readonly IReportGenerator _reportGenerator;

        ////public ReportingService(IReportGenerator reportGenerator)
        ////{
        ////    _reportGenerator = reportGenerator;
        ////}

        ////public void CreateReport(string data)
        ////{
        ////    _reportGenerator.GenerateReport(data);
        ////}

        // Implementation using Properties Injection

        public IReportGenerator ReportGenerator { get; set; }

        public void CreateCustomerReport(string customerData)
        {
            // Null check is important here, as the property might not be set.
            if (ReportGenerator != null)
            {
                ReportGenerator.GenerateReport(customerData);
            }
            else
            {
                Console.WriteLine("No report generator available.");
            }
        }

    }
}
