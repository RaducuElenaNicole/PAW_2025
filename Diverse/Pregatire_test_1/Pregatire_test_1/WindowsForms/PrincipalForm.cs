using Pregatire_test_1.clase;
using Pregatire_test_1.Entities;
using Pregatire_test_1.WindowsForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pregatire_test_1
{
    public partial class PrincipalForm : Form
    {

        private Spital _spital;
        public PrincipalForm()
        {
            InitializeComponent();

            _spital = new Spital("SP_01",
                "Spitalul Universitar de Urgenta, Bucuresti", new List<Doctor>());

            dataGridView_Doctors.AutoGenerateColumns = true;
        }

        private void button_AddDoctor_Click(object sender, EventArgs e)
        {
            FormAddDoctor formAddDoctor = new FormAddDoctor();
            formAddDoctor.ShowDialog();

            if(formAddDoctor.newDoctor != null)
            {
                //_spital.addDoctor(formAddDoctor.newDoctor);
                _spital = new Spital("SP_01",
                            "Spitalul Universitar de Urgenta, Bucuresti", 
                            formAddDoctor.doctors);
            }
        }

        private void button_AfisareMedici_Click(object sender, EventArgs e)
        {
            dataGridView_Doctors.DataSource = null;
            _spital.GetDoctori().Sort(); // sortare alfabetica dupa nume 
            dataGridView_Doctors.DataSource = _spital.GetDoctori();
        }

        private void dataGridView_Doctors_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
