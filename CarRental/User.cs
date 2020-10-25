using System;

namespace CarRental {
  abstract class User {
    private string _id;
    private string _name;
    private string _phone;
    private string _password;
    public abstract void Login();
    public abstract void Logout();
    public abstract void ViewProfile();
    public abstract void UpdateProfile();
    public abstract void ViewCarList();
  }
}