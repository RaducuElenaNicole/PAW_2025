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
    public partial class FormProdus : Form
    {
        public Produs ProdusCreat { get; set; }

        public FormProdus()
        {
            InitializeComponent();
        }
        public FormProdus(Produs produsExistent)
        {
            InitializeComponent();

            cod_TextBox.Text = produsExistent.Cod.ToString();
            denumire_TextBox.Text = produsExistent.Denumire;
            pret_TextBox.Text = produsExistent.Pret.ToString();
            cantitate_TextBox.Text = produsExistent.Cantitate.ToString();

            cod_TextBox.ReadOnly = true;
        }

        private void detaliiButton_Click(object sender, EventArgs e)
        {
            if(cod_TextBox.Text == "")
            {
                validareIntroducereDetalii_ErrorProvider.SetError(cod_TextBox,
                    "Introduceti codul produsului!");
            }else if(denumire_TextBox.Text == "")
            {
                validareIntroducereDetalii_ErrorProvider.SetError(denumire_TextBox,
                    "Introduceti denumirea produsului!");
            }else if(pret_TextBox.Text == "")
            {
                validareIntroducereDetalii_ErrorProvider.SetError(pret_TextBox,
                    "Introduceti pretul produsului!");
            }else if(cantitate_TextBox.Text == "")
            {
                validareIntroducereDetalii_ErrorProvider.SetError(cantitate_TextBox,
                   "Introduceti cantitatea produsului!");
            }
            else
            {
                validareIntroducereDetalii_ErrorProvider.Clear();

                try
                {
                    int cod = Convert.ToInt32(cod_TextBox.Text);
                    string denumire = denumire_TextBox.Text; 
                    float pret = (float)Convert.ToDouble(pret_TextBox.Text);
                    int cantitate = Convert.ToInt32(cantitate_TextBox.Text);

                    ProdusCreat = new Produs(cod, denumire, pret, cantitate);

                    MessageBox.Show("Informatiile despre noul produs sunt: " 
                        + ProdusCreat.ToString(),
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
                    cod_TextBox.Clear();
                    denumire_TextBox.Clear();
                    pret_TextBox.Clear();
                    cantitate_TextBox.Clear();
                }
            }
        }
    }
}
