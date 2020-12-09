using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;
using System.Globalization;

namespace CarRentalWF
{
    public class Database
    {
        private static Database _instance = null;
        private SQLiteConnection _sqlite_conn;

        public Database()
        {
            ConnectToDatabase();
        }

        /*
        ~Database()
        {
            CloseConnection();
        }
        */

        #region Query
        public List<Vehicle> GetAllVehicles(bool availableOnly=false)
        {
            SQLiteDataReader sqlite_datareader;
            SQLiteCommand sqlite_cmd;
            List<Vehicle> vecList = new List<Vehicle>();

            sqlite_cmd = _sqlite_conn.CreateCommand();
            sqlite_cmd.CommandText = "SELECT * FROM vehicle";
            if (availableOnly)
            {
                sqlite_cmd.CommandText += " WHERE available=1";
            }

            sqlite_datareader = sqlite_cmd.ExecuteReader();
            while (sqlite_datareader.Read())
            {
                int id = sqlite_datareader.GetInt32(0);
                string type = (string)sqlite_datareader[1];
                string name = (string)sqlite_datareader[2];
                string brand = (string)sqlite_datareader[3];
                string color = (string)sqlite_datareader[4];
                int numberOfSeat = sqlite_datareader.GetInt32(5);
                int year = sqlite_datareader.GetInt32(6);
                double price = (double)sqlite_datareader.GetDouble(7);
                bool available = (sqlite_datareader.GetInt32(8) ==1);
                int condition = sqlite_datareader.GetInt32(9);
                int currentMileage = sqlite_datareader.GetInt32(10);
                int engineMileage = sqlite_datareader.GetInt32(11);
                int transmissionMileage = sqlite_datareader.GetInt32(12);
                int tireMileage = sqlite_datareader.GetInt32(13);

                if (type == "Car")
                {
                    Car car = new Car(name, color, brand, year, numberOfSeat, price, condition, currentMileage, engineMileage, transmissionMileage, tireMileage, available);
                    car.Id = id;
                    vecList.Add(car);
                }
                else
                {
                    Truck truck = new Truck(name, color, year, price, condition, currentMileage, engineMileage, transmissionMileage, tireMileage, available);
                    truck.Id = id;
                    vecList.Add(truck);
                }
            }
            return vecList;
        }

        public List<Rent> GetAllRents()
        {
            SQLiteDataReader sqlite_datareader;
            SQLiteCommand sqlite_cmd;
            List<Rent> rentList = new List<Rent>();
            CultureInfo culture = CultureInfo.InvariantCulture;

            sqlite_cmd = _sqlite_conn.CreateCommand();
            sqlite_cmd.CommandText = "SELECT * FROM rent";

            sqlite_datareader = sqlite_cmd.ExecuteReader();
            while (sqlite_datareader.Read())
            {
                Rent rent = new Rent
                {
                    Id = sqlite_datareader.GetInt32(0),
                    CustomerId = sqlite_datareader.GetInt32(1),
                    VehicleId = sqlite_datareader.GetInt32(2),
                    Total = (double)sqlite_datareader.GetDouble(3),
                    Status = (RentStatus)Enum.Parse(typeof(RentStatus), sqlite_datareader.GetString(4)),
                    StartDate = DateTime.ParseExact(sqlite_datareader.GetString(5), "yyyy-MM-dd", culture),
                    EndDate = DateTime.ParseExact(sqlite_datareader.GetString(6), "yyyy-MM-dd", culture)
                };
                try
                {
                    rent.ReturnDate = DateTime.ParseExact(sqlite_datareader.GetString(7), "yyyy-MM-dd", culture);
                }
                catch (Exception) { }

                rentList.Add(rent);
            }
            return rentList;
        }

        public List<Customer> GetAllCustomers()
        {
            SQLiteDataReader sqlite_datareader;
            SQLiteCommand sqlite_cmd;
            List<Customer> customerList = new List<Customer>();
      
            sqlite_cmd = _sqlite_conn.CreateCommand();
            sqlite_cmd.CommandText = "SELECT * FROM customer";

            sqlite_datareader = sqlite_cmd.ExecuteReader();
            while (sqlite_datareader.Read())
            {
                Customer customer = new Customer
                {
                    Id = sqlite_datareader.GetInt32(0),
                    Name = sqlite_datareader.GetString(1),
                    Phone = sqlite_datareader.GetString(2)
                };
                customerList.Add(customer);
            }
            return customerList;
        }

        public List<MaintenanceJob> GetMaintenanceJobs(int vehicleID)
        {
            SQLiteDataReader sqlite_datareader;
            SQLiteCommand sqlite_cmd;
            List<MaintenanceJob> jobList = new List<MaintenanceJob>();
            CultureInfo culture = CultureInfo.InvariantCulture;

            sqlite_cmd = _sqlite_conn.CreateCommand();
            sqlite_cmd.CommandText = "SELECT * FROM maintenaceJob WHERE vehicleID=@vehicleID";
            sqlite_cmd.Parameters.AddWithValue("@vehicleID", vehicleID);

            sqlite_datareader = sqlite_cmd.ExecuteReader();
            while (sqlite_datareader.Read())
            {
                MaintenanceJob job = new MaintenanceJob
                {
                    ID = sqlite_datareader.GetInt32(0),
                    VehicleID = sqlite_datareader.GetInt32(1),
                    Kind = sqlite_datareader.GetString(2),
                    Type = sqlite_datareader.GetString(3),
                    Mileage = sqlite_datareader.GetInt32(4),
                    ServeTime = DateTime.ParseExact(sqlite_datareader.GetString(5), "yyyy-MM-dd HH:mm:ss", culture),
                    Cost = sqlite_datareader.GetDouble(6),
                    Garage = sqlite_datareader.GetString(7)
                };

                jobList.Add(job);
            }
            return jobList;
        }
        #endregion

        #region Vehicle
        public int InsertVehicle(Vehicle vehicle)
        {
            SQLiteCommand sqlite_cmd;
            sqlite_cmd = _sqlite_conn.CreateCommand();
            sqlite_cmd.CommandText = "INSERT INTO vehicle (type, name, brand, color, numberOfSeat, year, price, condition, mileage, lastEngineService, lastTransmissionService, lastTireService) VALUES (@type, @name, @brand, @color, @numberOfSeat, @year, @price, @condition, @mileage, @lastEngineService, @lastTransmissionService, @lastTireService)";
            sqlite_cmd.Parameters.AddWithValue("@type", vehicle.Type);
            sqlite_cmd.Parameters.AddWithValue("@name", vehicle.Name);
            sqlite_cmd.Parameters.AddWithValue("@brand", vehicle.Brand);
            sqlite_cmd.Parameters.AddWithValue("@color", vehicle.Color);
            sqlite_cmd.Parameters.AddWithValue("@numberOfSeat", vehicle.NumberOfSeat);
            sqlite_cmd.Parameters.AddWithValue("@year", vehicle.Year);
            sqlite_cmd.Parameters.AddWithValue("@price", vehicle.Price);
            sqlite_cmd.Parameters.AddWithValue("@condition", vehicle.Condition);
            sqlite_cmd.Parameters.AddWithValue("@mileage", vehicle.CurrentMileage);
            sqlite_cmd.Parameters.AddWithValue("@lastEngineService", vehicle.LastEngineServiceMileage);
            sqlite_cmd.Parameters.AddWithValue("@lastTransmissionService", vehicle.LastTransmissionServiceMileage);
            sqlite_cmd.Parameters.AddWithValue("@lastTireService", vehicle.LastTireServiceMileage);
            sqlite_cmd.ExecuteNonQuery();

            int newId = (int)_sqlite_conn.LastInsertRowId;

            return newId;
        }

        public void UpdateVehicle(Vehicle vehicle)
        {
            SQLiteCommand sqlite_cmd;
            sqlite_cmd = _sqlite_conn.CreateCommand();
            sqlite_cmd.CommandText = "UPDATE vehicle SET type=@type, name=@name, brand=@brand, color=@color, numberOfSeat=@numberOfSeat, year=@year, price=@price, available=@available, condition=@condition, mileage=@mileage, lastEngineService=@lastEngineService, lastTransmissionService=@lastTransmissionService, lastTireService=@lastTireService WHERE id = @id";
            sqlite_cmd.Parameters.AddWithValue("@type", vehicle.Type);
            sqlite_cmd.Parameters.AddWithValue("@name", vehicle.Name);
            sqlite_cmd.Parameters.AddWithValue("@brand", vehicle.Brand);
            sqlite_cmd.Parameters.AddWithValue("@color", vehicle.Color);
            sqlite_cmd.Parameters.AddWithValue("@numberOfSeat", vehicle.NumberOfSeat);
            sqlite_cmd.Parameters.AddWithValue("@year", vehicle.Year);
            sqlite_cmd.Parameters.AddWithValue("@price", vehicle.Price);
            sqlite_cmd.Parameters.AddWithValue("@available", vehicle.Available ? 1: 0) ;
            sqlite_cmd.Parameters.AddWithValue("@condition", vehicle.Condition);
            sqlite_cmd.Parameters.AddWithValue("@mileage", vehicle.CurrentMileage);
            sqlite_cmd.Parameters.AddWithValue("@lastEngineService", vehicle.LastEngineServiceMileage);
            sqlite_cmd.Parameters.AddWithValue("@lastTransmissionService", vehicle.LastTransmissionServiceMileage);
            sqlite_cmd.Parameters.AddWithValue("@lastTireService", vehicle.LastTireServiceMileage);
            sqlite_cmd.Parameters.AddWithValue("@id", vehicle.Id);
            sqlite_cmd.ExecuteNonQuery();
        }

        public Vehicle GetVehicle(int vehicleID)
        {
            SQLiteDataReader sqlite_datareader;
            SQLiteCommand sqlite_cmd;
            sqlite_cmd = _sqlite_conn.CreateCommand();
            sqlite_cmd.CommandText = "SELECT * FROM vehicle WHERE id = @id";
            sqlite_cmd.Parameters.AddWithValue("@id", vehicleID);
            sqlite_datareader = sqlite_cmd.ExecuteReader();
            while (sqlite_datareader.Read())
            {
                int id = sqlite_datareader.GetInt32(0);
                string type = (string)sqlite_datareader[1];
                string name = (string)sqlite_datareader[2];
                string brand = (string)sqlite_datareader[3];
                string color = (string)sqlite_datareader[4];
                int numberOfSeat = sqlite_datareader.GetInt32(5);
                int year = sqlite_datareader.GetInt32(6);
                double price = (double)sqlite_datareader.GetDouble(7);
                bool available = (sqlite_datareader.GetInt32(8) == 1);
                int condition = sqlite_datareader.GetInt32(9);
                int currentMileage = sqlite_datareader.GetInt32(10);
                int engineMileage = sqlite_datareader.GetInt32(11);
                int transmissionMileage = sqlite_datareader.GetInt32(12);
                int tireMileage = sqlite_datareader.GetInt32(13);

                if (type == "Car")
                {
                    Car car = new Car(name, color, brand, year, numberOfSeat, price, condition, currentMileage, engineMileage, transmissionMileage, tireMileage, available);
                    car.Id = id;
                    return car;
                }
                else
                {
                    Truck truck = new Truck(name, color, year, price, condition, currentMileage, engineMileage, transmissionMileage, tireMileage, available);
                    truck.Id = id;
                    return truck;
                }
            }
            return null;
        }

        public void RemoveVehicle(int vehicleId)
        {
            SQLiteCommand sqlite_cmd;
            sqlite_cmd = _sqlite_conn.CreateCommand();
            sqlite_cmd.CommandText = "DELETE FROM vehicle WHERE id = @id";
            sqlite_cmd.Parameters.AddWithValue("@id", vehicleId);
            sqlite_cmd.ExecuteNonQuery();
        }
#endregion

        #region Rent
        public int InsertRent(Rent rent)
        {
            SQLiteCommand sqlite_cmd;
            sqlite_cmd = _sqlite_conn.CreateCommand();
            sqlite_cmd.CommandText = "INSERT INTO rent (customer_id, vehicle_id, total, status, start_date, end_date) VALUES (@customer_id, @vehicle_id, @total, @status, @start_date, @end_date)";
            sqlite_cmd.Parameters.AddWithValue("@customer_id", rent.CustomerId);
            sqlite_cmd.Parameters.AddWithValue("@vehicle_id", rent.VehicleId);
            sqlite_cmd.Parameters.AddWithValue("@total", rent.Total);
            sqlite_cmd.Parameters.AddWithValue("@status", rent.Status.ToString());
            sqlite_cmd.Parameters.AddWithValue("@start_date", rent.StartDate.ToString("yyyy-MM-dd"));
            sqlite_cmd.Parameters.AddWithValue("@end_date", rent.EndDate.ToString("yyyy-MM-dd"));
            sqlite_cmd.ExecuteNonQuery();

            int newId = (int)_sqlite_conn.LastInsertRowId;

            return newId;
        }

        public void UpdateRent(Rent rent)
        {
            SQLiteCommand sqlite_cmd;
            sqlite_cmd = _sqlite_conn.CreateCommand();
            sqlite_cmd.CommandText = "UPDATE rent SET customer_id=@customer_id, vehicle_id=@vehicle_id, total=@total, status=@status, start_date=@start_date, end_date=@end_date, return_date=@return_date WHERE id=@id";
            sqlite_cmd.Parameters.AddWithValue("@customer_id", rent.CustomerId);
            sqlite_cmd.Parameters.AddWithValue("@vehicle_id", rent.VehicleId);
            sqlite_cmd.Parameters.AddWithValue("@total", rent.Total);
            sqlite_cmd.Parameters.AddWithValue("@status", rent.Status.ToString());
            sqlite_cmd.Parameters.AddWithValue("@start_date", rent.StartDate.ToString("yyyy-MM-dd"));
            sqlite_cmd.Parameters.AddWithValue("@end_date", rent.EndDate.ToString("yyyy-MM-dd"));
            sqlite_cmd.Parameters.AddWithValue("@return_date", rent.ReturnDate?.ToString("yyyy-MM-dd"));
            sqlite_cmd.Parameters.AddWithValue("@id", rent.Id);
            sqlite_cmd.ExecuteNonQuery();
        }

        public void RemoveRent(int rentID)
        {
            SQLiteCommand sqlite_cmd;
            sqlite_cmd = _sqlite_conn.CreateCommand();
            sqlite_cmd.CommandText = "DELETE FROM rent WHERE id = @id";
            sqlite_cmd.Parameters.AddWithValue("@id", rentID);
            sqlite_cmd.ExecuteNonQuery();
        }

        public Rent GetRent(int rentID)
        {
            SQLiteDataReader sqlite_datareader;
            SQLiteCommand sqlite_cmd;
            CultureInfo culture = CultureInfo.InvariantCulture;

            sqlite_cmd = _sqlite_conn.CreateCommand();
            sqlite_cmd.CommandText = "SELECT * FROM rent WHERE id = @id";
            sqlite_cmd.Parameters.AddWithValue("@id", rentID);
            sqlite_datareader = sqlite_cmd.ExecuteReader();
            while (sqlite_datareader.Read())
            {
                Rent rent = new Rent
                {
                    Id = sqlite_datareader.GetInt32(0),
                    CustomerId = sqlite_datareader.GetInt32(1),
                    VehicleId = sqlite_datareader.GetInt32(2),
                    Total = (double)sqlite_datareader.GetDouble(3),
                    Status = (RentStatus)Enum.Parse(typeof(RentStatus), sqlite_datareader.GetString(4)),
                    StartDate = DateTime.ParseExact(sqlite_datareader.GetString(5), "yyyy-MM-dd", culture),
                    EndDate = DateTime.ParseExact(sqlite_datareader.GetString(6), "yyyy-MM-dd", culture)
                };
                try
                {
                    rent.ReturnDate = DateTime.ParseExact(sqlite_datareader.GetString(7), "yyyy-MM-dd", culture);
                }
                catch (Exception) { }

                return rent;
            }
            return null;
        }
        #endregion

        #region MaintenanceJob
        public int InsertMaintenanceJob(MaintenanceJob job)
        {
            SQLiteCommand sqlite_cmd;
            CultureInfo culture = CultureInfo.InvariantCulture;

            sqlite_cmd = _sqlite_conn.CreateCommand();
            sqlite_cmd.CommandText = "INSERT INTO maintenaceJob (vehicleID, kind, type, mileage, serveTime, cost, garage) values (@vehicleID, @kind, @type, @mileage, @serveTime, @cost, @garage)";
            sqlite_cmd.Parameters.AddWithValue("@vehicleID", job.VehicleID);
            sqlite_cmd.Parameters.AddWithValue("@kind", job.Kind);
            sqlite_cmd.Parameters.AddWithValue("@type", job.Type);
            sqlite_cmd.Parameters.AddWithValue("@mileage", job.Mileage);
            sqlite_cmd.Parameters.AddWithValue("@serveTime", job.ServeTime.ToString("yyyy-MM-dd HH:mm:ss"));
            sqlite_cmd.Parameters.AddWithValue("@cost", job.Cost);
            sqlite_cmd.Parameters.AddWithValue("@garage", job.Garage);
            sqlite_cmd.ExecuteNonQuery();

            int newId = (int)_sqlite_conn.LastInsertRowId;

            return newId;
        }
        #endregion

        #region Customer
        public int InsertCustomer(Customer customer)
        {
            SQLiteCommand sqlite_cmd;
            sqlite_cmd = _sqlite_conn.CreateCommand();
            sqlite_cmd.CommandText = "INSERT INTO customer (name, phone) VALUES (@name, @phone)";
            sqlite_cmd.Parameters.AddWithValue("@name", customer.Name);
            sqlite_cmd.Parameters.AddWithValue("@phone", customer.Phone);
            sqlite_cmd.ExecuteNonQuery();

            int newId = (int)_sqlite_conn.LastInsertRowId;

            return newId;
        }

        public void UpdateCustomer(Customer customer)
        {
            SQLiteCommand sqlite_cmd;
            sqlite_cmd = _sqlite_conn.CreateCommand();
            sqlite_cmd.CommandText = "UPDATE customer SET name=@name, phone=@phone WHERE id = @id";
            sqlite_cmd.Parameters.AddWithValue("@name", customer.Name);
            sqlite_cmd.Parameters.AddWithValue("@phone", customer.Phone);
            sqlite_cmd.Parameters.AddWithValue("@id", customer.Id);
            sqlite_cmd.ExecuteNonQuery();
        }

        public Customer GetCustomer(int customerId)
        {
            SQLiteDataReader sqlite_datareader;
            SQLiteCommand sqlite_cmd;
            sqlite_cmd = _sqlite_conn.CreateCommand();
            sqlite_cmd.CommandText = "SELECT * FROM customer WHERE id = @id";
            sqlite_cmd.Parameters.AddWithValue("@id", customerId);
            sqlite_datareader = sqlite_cmd.ExecuteReader();
            while (sqlite_datareader.Read())
            {
                int id = sqlite_datareader.GetInt32(0);
                string name = (string)sqlite_datareader[1];
                string phone = (string)sqlite_datareader[2];
                Customer customer = new Customer(name, phone);
                customer.Id = id;
                return customer;
            }
            return null;
        }

        public void RemoveCustomer(int customerId)
        {
            SQLiteCommand sqlite_cmd;
            sqlite_cmd = _sqlite_conn.CreateCommand();
            sqlite_cmd.CommandText = "DELETE FROM customer WHERE id = @id";
            sqlite_cmd.Parameters.AddWithValue("@id", customerId);
            sqlite_cmd.ExecuteNonQuery();
        }
        #endregion

        private void ConnectToDatabase()
        {
            _sqlite_conn = new SQLiteConnection("Data Source=../../database/db.sqlite3; Version = 3; ");
            // Open the connection:
            try
            {
                _sqlite_conn.Open();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }

        private void CloseConnection()
        {
            _sqlite_conn.Close();
        }

        public static Database GetInstance()
        {
            if (_instance == null)
            {
                _instance = new Database();
            }

            return _instance;
        }
    }
}
