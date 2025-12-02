using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static ManyClassAplication.Warehouse;

namespace ManyClassAplication
{
    class Report
    {
        private List<ReportRow> report_ = new List<ReportRow>(); 

        public void AddReport(ReportRow row)
        {
            report_.Add(row);
        }
        public string ToString(ReportRow row)
        {
            return row.Products + "," + row.Price + "," + row.Quantity;
        }
        public string PrintReport()
        {
            string result = "";
            foreach (ReportRow row in report_)
            {
                result += ToString(row) + "\n";
            }
            Console.WriteLine(result);
            return result;
        }
        public void CalculateSum()
        {
            double sum = 0; 
            foreach(ReportRow row in report_)
            {
                sum += row.Quantity * row.Price;
            }
            Console.WriteLine("Сумма всех товаров " + sum);
        }
    }
}
