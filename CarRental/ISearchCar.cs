using System;

namespace CarRental {
  interface ISearchCar {
    Vehicle SearchByName(string name);
    Vehicle SearchByColor(string name);
    Vehicle SearchByBrand(string name);
  }
}