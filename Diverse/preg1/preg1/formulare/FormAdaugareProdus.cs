using preg1.clase;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace preg1.formulare
{
    public partial class FormAdaugareProdus : Form
    {
        public Produs produsNou {  get; set; }
        public List<Produs> produseAdaugate {  get; set; }
        public FormAdaugareProdus()
        {
            InitializeComponent();

            produseAdaugate = new List<Produs>();
        }

        private void salveazaProdus_btn_Click(object sender, EventArgs e)
        {
            if(textBox_id.Text == "")
            {
                errorProvider_validitateaDatelor.SetError(textBox_id, 
                    "Introduceti id-ul!");
            }else if(textBox_denumire.Text == "")
            {
                errorProvider_validitateaDatelor.SetError(textBox_denumire,
                    "Introduceti denumirea!");
            }else if(textBox_cantitate.Text == "")
            {
                errorProvider_validitateaDatelor.SetError(textBox_cantitate,
                   "Introduceti cantitatea!");
            }else if(textBox_pret.Text == "")
            {
                errorProvider_validitateaDatelor.SetError(textBox_pret,
                   "Introduceti pretul!");
            }
            else
            {
                errorProvider_validitateaDatelor.Clear();

                try
                {
                    int id = Convert.ToInt32(textBox_id.Text);
                    string denumire = textBox_denumire.Text;
                    decimal pret = Convert.ToDecimal(textBox_pret.Text);
                    int cantitate = Convert.ToInt32(textBox_cantitate.Text);

                    produsNou = new Produs(id, denumire, pret, cantitate);
                    produseAdaugate.Add(produsNou);

                    MessageBox.Show("Informatiile despre noul produs sunt: "
                        + produsNou.ToString());
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    textBox_id.Clear();
                    textBox_denumire.Clear();
                    textBox_pret.Clear();
                    textBox_cantitate.Clear();
                }
            }
        }
    }
}
