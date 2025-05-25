using PAW_seminar5_24_03_2025.Entities;
using PAW_seminar5_24_03_2025.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace PAW_seminar5_24_03_2025.Services
{
    public class CarService
    {
        private CarRepository _carRepository;
        private const string _licenseNumberRegex = "^[A-Z]{1, 2}[0-9]{2, 3}[A-Z]{3}$";


        public CarService()
        {
            _carRepository = new CarRepository();
        }
        public void AddCar(Car car)
        {
            if (_carRepository.ExistsByLicenseNumber(car.LicenseNumber))
            {
                throw new Exception
                    ($"O masina cu numarul {car.LicenseNumber} " +
                    $"exista deja! ");
            }
            if(!Regex.IsMatch(car.LicenseNumber, _licenseNumberRegex))
            {
                throw new Exception($"Numarul de inmatriculare {car.LicenseNumber} exista deja!");
            }

            _carRepository.Add(car);  
        }
    }
}
