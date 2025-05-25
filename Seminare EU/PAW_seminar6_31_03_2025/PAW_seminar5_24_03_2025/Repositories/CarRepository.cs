using PAW_seminar5_24_03_2025.Database;
using PAW_seminar5_24_03_2025.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PAW_seminar5_24_03_2025.Repositories
{
    public class CarRepository
    {
        public bool ExistsByLicenseNumber(string licenseNumber)
        {
            //foreach (var car in FakeDatabase.Cars)
            //{
            //    if(car.LicenseNumber == licenseNumber)
            //        return true;
            //}
            //return false;

            return FakeDatabase.Cars.FirstOrDefault(car => 
                car.LicenseNumber == licenseNumber) != null;
        }

        public void Add(Car car)
        {
            FakeDatabase.Cars.Add(car);
        }
    }
}
