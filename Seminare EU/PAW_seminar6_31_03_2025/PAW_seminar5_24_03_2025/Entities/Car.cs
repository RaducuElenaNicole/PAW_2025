using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PAW_seminar5_24_03_2025.Entities{
    public class Car
    {
        public Guid Id { get; set; }
        public string Make {  get; set; }
        public string Model {  get; set; }
        public int Year { get; set; }
        public int Seats { get; set; }
        public bool HasInsurance {  get; set; }
        public string LicenseNumber {  get; set; } 
    }
}
