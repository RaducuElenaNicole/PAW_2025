using preg1.clase;
using preg1.formulare;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace preg1
{
    public partial class FormPrincipal : Form
    {
        public CosCumparaturi cosCumparaturi { get; set; }
        public FormPrincipal()
        {
            InitializeComponent();

            cosCumparaturi = new CosCumparaturi();

            dataGridView_produseCosCumparaturi.AutoGenerateColumns = true;
        }

        private void adaugaProdus_btn_Click(object sender, EventArgs e)
        {
            FormAdaugareProdus formAdaugareProdus = new FormAdaugareProdus();
            formAdaugareProdus.ShowDialog();

            if(formAdaugareProdus.produsNou != null)
            {
                cosCumparaturi = new CosCumparaturi(formAdaugareProdus.produseAdaugate);
            }
        }

        private void afiseazaCosCumparaturi_btn_Click(object sender, EventArgs e)
        {
            dataGridView_produseCosCumparaturi.DataSource = null;
            // cosCumparaturi.getProduse().Sort(); 
            dataGridView_produseCosCumparaturi.DataSource = cosCumparaturi.getProduse();    
        }

        private void afiseazaDetalii_btn_Click(object sender, EventArgs e)
        {
            textBox_numarProduse.Clear();
            textBox_valoareTotala.Clear();

            textBox_valoareTotala.Text = cosCumparaturi.valoareTotala.ToString();
            textBox_numarProduse.Text = cosCumparaturi.numarProduse.ToString();
        }
    }
}
