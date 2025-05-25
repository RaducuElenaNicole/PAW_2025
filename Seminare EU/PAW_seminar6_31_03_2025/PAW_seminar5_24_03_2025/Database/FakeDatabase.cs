using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using PAW_seminar5_24_03_2025.Entities;

namespace PAW_seminar5_24_03_2025.Database
{
    public static class FakeDatabase
    {
        // se genereaza o singura instanta
        public static List<Car> Cars = new List<Car>() {
            new Car()
            {
                Id = Guid.NewGuid(),
                Make = "Skoda",
                Model = "Octavia",
                Year = 2003,
                Seats = 5,
                HasInsurance = false,
                LicenseNumber = "B123ASR"
            },
            new Car
            {
                Id = Guid.NewGuid(),
                Make = "Fiat",
                Model = "Multipla",
                Year = 2002,
                Seats = 6,
                HasInsurance = true,
                LicenseNumber = "AG47ABR"
            }
        };
            

        
    }
}
