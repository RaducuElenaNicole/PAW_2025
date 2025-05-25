using CarRentalApp.Database;
using CarRentalApp.Entities;
using System.Linq;

namespace CarRentalApp.Repositories
{
    public class CarRepository
    {
        public bool ExistsByLicenseNumber(string licenseNumber) {
            return FakeDatabase.Cars.FirstOrDefault(car => car.LicenseNumber == licenseNumber) != null;            
        }

        public void Add(Car car) {
            FakeDatabase.Cars.Add(car);
        }

        public void Update(Car car)
        {
            var existingCar = FakeDatabase.Cars.FirstOrDefault(x => x.Id == car.Id);

            if (existingCar.GetHashCode() != car.GetHashCode())
            {
                // intra pe aici 
            }

            existingCar.Make = car.Make;
            existingCar.LicenseNumber = car.LicenseNumber;
            existingCar.Model = car.Model;
            existingCar.Year = car.Year;
            existingCar.Seats = car.Seats;
            existingCar.HasInsurance = car.HasInsurance;
        }
    }
}
