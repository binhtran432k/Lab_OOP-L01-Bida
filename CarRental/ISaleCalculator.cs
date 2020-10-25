using System;

namespace CarRental {
  interface ISaleCalculator {
    double CalculateTotalSale();
    double CalculateDailySale();
    double CalculateMonthlySale();
  }
}