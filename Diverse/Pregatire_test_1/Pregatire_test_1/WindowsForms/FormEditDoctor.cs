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
    public partial class FormEditDoctor : Form
    {
        public Doctor doctorModificat { get; set; }
        public FormEditDoctor(Doctor doctorDeEditat)
        {
            InitializeComponent();

            textBox_Id.Text = doctorDeEditat._id.ToString();
            textBox_Nume.Text = doctorDeEditat._nume;
            textBox_Salariu.Text = doctorDeEditat._salariu.ToString();
            textBox_Specializare.Text = doctorDeEditat._specializare;
        }

        private void button_ActualizareDetaliiDoctor_Click(object sender, EventArgs e)
        {
            if (textBox_Id.Text == "")
            {
                errorProvider_ValidareIntroducereDate.SetError(textBox_Id,
                    "Introduceti id-ul!");
            }
            else if (textBox_Nume.Text == "")
            {
                errorProvider_ValidareIntroducereDate.SetError(textBox_Nume,
                    "Introduceti numele!");
            }
            else if (textBox_Salariu.Text == "")
            {
                errorProvider_ValidareIntroducereDate.SetError(textBox_Salariu,
                   "Introduceti salariul!");
            }
            else if (textBox_Specializare.Text == "")
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

                    doctorModificat = new Doctor(id, nume, salariu, specializare);

                    MessageBox.Show("Informatiile actualizate despre medic au fost salvate: "
                        + doctorModificat.ToString());

                }
                catch (Exception ex)
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
    }
}
