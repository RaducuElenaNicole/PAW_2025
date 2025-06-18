using proiect_PAW_2025.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace proiect_PAW_2025.Forms
{
    public partial class FormProductie : Form
    {
        public Productie ProductieCreata {  get; set; }
        private int codProdus;
        public FormProductie(int codProdusSelectat)
        {
            InitializeComponent();
            codProdus = codProdusSelectat;
        }

        private void afiseazaDetaliiProductie_button_Click(object sender, EventArgs e)
        {
            if(costProductie_TextBox.Text == "")
            {
                validareDetaliiProductie_ErrorProvider.SetError(costProductie_TextBox,
                    "Introduceti costul productie!");
            }else if(timpProductie_TextBox.Text == "")
            {
                validareDetaliiProductie_ErrorProvider.SetError(timpProductie_TextBox,
                    "Introduceti timpul productie!");
            }
            else
            {
                validareDetaliiProductie_ErrorProvider.Clear();

                try
                {
                    decimal costProductie = Convert.ToDecimal(costProductie_TextBox.Text); 
                    int timpProductie = Convert.ToInt32(timpProductie_TextBox.Text);

                    ProductieCreata = new Productie(codProdus, costProductie, timpProductie);

                    MessageBox.Show("Informatiile despre produsul cu codul " + codProdus 
                        + " cu privire la productie sunt: " + ProductieCreata.ToString(),
                         "Succes", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    DialogResult = DialogResult.OK;
                    this.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    costProductie_TextBox.Clear();
                    timpProductie_TextBox.Clear();
                }
            }
        }
    }
}
