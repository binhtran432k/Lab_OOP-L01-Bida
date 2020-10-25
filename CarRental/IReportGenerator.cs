using System;

namespace CarRental {
  interface IReportGenerator {
    void GenerateDailyReport();
    void GenerateMonthlyReport();
    void ExportPdf();
    void ExportExcel();
    void PrintReport();
  }
}