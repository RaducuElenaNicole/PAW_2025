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
    public partial class FormGestiuneStoc : Form
    {
        public GestiuneStoc GestiuneStocCreata { get; private set; }
        private int codProdus; 

        public FormGestiuneStoc(int codProdusSelectat)
        {
            InitializeComponent();

            codProdus = codProdusSelectat;
            stare_ComboBox.SelectedIndex = 0;
        }

        private void afisareDetaliiGestiuneStoc_button_Click(object sender, EventArgs e)
        {
            if(categorieNume_TextBox.Text == "")
            {
                validariGestiuneStoc_ErrorProvider.SetError(categorieNume_TextBox,
                    "Introduceti numele categoriei!");
            }else if(categorieID_textBox.Text == "")
            {
                validariGestiuneStoc_ErrorProvider.SetError(categorieID_textBox,
                    "Introduceti id-ul categoriei!");
            }else if(stare_ComboBox.Text == "")
            {
                validariGestiuneStoc_ErrorProvider.SetError(stare_ComboBox,
                    "Alegeti starea!");
            }
            else
            {
                validariGestiuneStoc_ErrorProvider.Clear();

                try
                {
                    string numeCategorie = categorieNume_TextBox.Text;
                    int idCategorie = Convert.ToInt32(categorieID_textBox.Text);
                    string stare = stare_ComboBox.SelectedItem.ToString();

                    GestiuneStocCreata = new GestiuneStoc(codProdus, numeCategorie, codProdus, stare);

                    MessageBox.Show("Informatiile introduse despre produsul cu codul " + codProdus 
                        + " cu privire la gestiunea de stocuri sunt: "
                        + GestiuneStocCreata.ToString(),
                         "Succes", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    DialogResult = DialogResult.OK;
                    this.Close();

                }catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    categorieID_textBox.Clear();
                    categorieNume_TextBox.Clear();
                    stare_ComboBox.Items.Clear();
                }
            }
        }
    }
}
