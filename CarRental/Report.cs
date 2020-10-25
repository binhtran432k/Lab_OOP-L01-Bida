using System;

namespace CarRental {
  class Report : IReportGenerator {
    private DateTime _dateCreate;
    public void GenerateDailyReport() {}
    public void GenerateMonthlyReport() {}
    public void ExportPdf() {}
    public void ExportExcel() {}
    public void PrintReport() {}
  }
}