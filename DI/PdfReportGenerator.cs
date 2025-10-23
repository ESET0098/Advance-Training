using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DI
{
    public class PdfReportGenerator: IReportGenerator
    {
        public void GenerateReport(string reportData)
        {
          
            Console.WriteLine("Generating PDF report...");
        }

    }

    public class HtmlReportGenerator: IReportGenerator
    {
        public void GenerateReport(string reportData)
        {
            Console.WriteLine("Generating HTML report...");
        }
    }
}
