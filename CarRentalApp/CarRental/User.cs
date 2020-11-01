using System;

namespace CarRental
{
    abstract class User
    {
        static int NumberOfUser = 0;
        public string ID { get; set; }
        public string Name { get; set; }
        public string Phone { get; set; }

        public void GenerateID()
        {
            NumberOfUser += 1;
            ID = NumberOfUser.ToString();
        }

        public abstract void ViewProfile();

        public abstract void UpdateProfile();
    }
}

