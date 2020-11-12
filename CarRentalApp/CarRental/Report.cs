using System;
using System.Collections.Generic;
using System.Text;

namespace CarRental
{
    class Report : IReportGenerator
    {
        private DateTime DateCreate;

        public Report(DateTime dateCreate)
        {
            DateCreate = dateCreate;
        }
        public void GenerateDailyReport() { }
        public void GenerateMonthlyReport() { }
        public void ExportPdf() { }
        public void ExportExcel() { }
        public void PrintReport() { }
    }
}
