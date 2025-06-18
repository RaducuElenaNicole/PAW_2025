using Pregatire_test_1.clase;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pregatire_test_1.WindowsForms
{
    public partial class FormAddDoctor : Form
    {
        public List<Doctor> doctors = new List<Doctor>();
        public Doctor newDoctor { get; set; }

        public FormAddDoctor()
        {
            InitializeComponent();
        }

        private void button_AdaugaDetaliiDoctor_Click(object sender, EventArgs e)
        {
            if(textBox_Id.Text == "")
            {
                errorProvider_ValidareIntroducereDate.SetError(textBox_Id, 
                    "Introduceti id-ul!"); 
            }else if(textBox_Nume.Text == ""){
                errorProvider_ValidareIntroducereDate.SetError(textBox_Nume,
                    "Introduceti numele!");
            }else if(textBox_Salariu.Text == "")
            {
                errorProvider_ValidareIntroducereDate.SetError(textBox_Salariu,
                   "Introduceti salariul!");
            }else if (textBox_Specializare.Text == "")
            {
                errorProvider_ValidareIntroducereDate.SetError(textBox_Specializare,
                  "Introduceti specializarea!");
            }
            else
            {
                errorProvider_ValidareIntroducereDate.Clear();

                try
                {
                    int id = Convert.ToInt32(textBox_Id.Text);
                    string nume = textBox_Nume.Text;
                    float salariu = (float)Convert.ToDouble(textBox_Salariu.Text);
                    string specializare = textBox_Specializare.Text;

                    newDoctor = new Doctor(id, nume, salariu, specializare);

                    doctors.Add(newDoctor);

                    MessageBox.Show("Informatiile despre noul medic au fost adaugate: "
                        + newDoctor.ToString());

                }catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    textBox_Id.Clear();
                    textBox_Nume.Clear();
                    textBox_Salariu.Clear();
                    textBox_Specializare.Clear();
                }
            }
        }

        private void button_AddDoctorsToHospital_Click(object sender, EventArgs e)
        {
            if (doctors.Count > 0)
            {
                // apas butonul si mi se deschide un alt
                // formular in care adaug restul detaliilor pt un spital

                // apoi am un buton cu adauga detalii spital si le afisez
                // in formularul principla in grid data view 
            }
        }
    }
}
