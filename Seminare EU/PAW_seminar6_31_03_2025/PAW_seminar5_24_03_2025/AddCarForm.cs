using PAW_seminar5_24_03_2025.Entities;
using PAW_seminar5_24_03_2025.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PAW_seminar5_24_03_2025
{
    public partial class AddCarForm : Form // da F12 pe Form ! 
    {
        private CarService _carService;
        public AddCarForm()
        {
            InitializeComponent();
        }

        private void cancelCarButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void saveCarButton_Click(object sender, EventArgs e)
        {
            var car = new Car();
            car.Id = Guid.NewGuid();
            car.Make = makeTextBox.Text;
            car.Model = modelTextBox.Text;
            car.Year = Convert.ToInt32(yearNumericUpDown.Value);
            car.Seats = Convert.ToInt32(seatsNumericUpDown.Value);
            car.HasInsurance = hasInsuranceCheckBox.Checked;
            car.LicenseNumber = licenseNumberTextBox.Text;

            try
            {
                _carService.AddCar(car);
                Close();
            }
            catch (Exception ex) {
                MessageBox.Show(ex.Message);
            }

        }
    }
}
