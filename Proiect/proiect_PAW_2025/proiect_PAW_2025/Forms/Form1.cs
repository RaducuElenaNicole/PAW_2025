using proiect_PAW_2025.Forms;
using proiect_PAW_2025.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace proiect_PAW_2025
{
    public partial class Form1 : Form
    {
        private string _connectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"D:\\FACULTATE\\RESTANTE\\2.2. PAW recuperare\\git_PAW_2025\\cod scris\\Proiect\\proiect_PAW_2025\\proiect_PAW_2025\\App_Data\\Productie_BD.mdf\";Integrated Security=True";
        public Form1()
        {
            InitializeComponent();
            productsDataGridView.DataSource = GetProducsFromDB();
            productsDataGridView.AutoGenerateColumns = true;
            productsDataGridView.CellClick += productsDataGridView_CellContentClick;
        }

        private List<Produs> GetProducsFromDB()
        {
            var products = new List<Produs>();

            // get data from db 
            var connection = new SqlConnection(_connectionString);
            connection.Open();

            var command = new SqlCommand("SELECT Cod, Denumire, " +
                "Pret, Cantitate FROM Produs", connection);
            var reader = command.ExecuteReader();
            while (reader.Read())
            {
                var produs = new Produs();
                produs.Cod = Convert.ToInt32(reader["Cod"].ToString());
                produs.Denumire = reader["Denumire"].ToString();
                produs.Pret = (float)Convert.ToDouble(reader["Pret"].ToString());
                produs.Cantitate = Convert.ToInt32(reader["Cantitate"].ToString());

                products.Add(produs);
            }
            connection.Close();
            return products;
        }

        private List<Productie> GetProductieForProdus(int codProdus)
        {
            var productieList = new List<Productie>();

            var connection = new SqlConnection(_connectionString);
            connection.Open();

            var commandSQL = new SqlCommand("SELECT CodProdus, Cost, TimpProductie " +
                "FROM Productie WHERE CodProdus = @cod", connection);
            commandSQL.Parameters.AddWithValue("@cod", codProdus);

            var reader = commandSQL.ExecuteReader();
            while (reader.Read())
            {
                var productieDetaliiIntoduse = new Productie();
                productieDetaliiIntoduse.CodProdus = Convert.ToInt32(reader["CodProdus"]);
                productieDetaliiIntoduse.Cost = Convert.ToDecimal(reader["Cost"]);
                productieDetaliiIntoduse.TimpProductie = Convert.ToInt32(reader["TimpProductie"]);

                productieList.Add(productieDetaliiIntoduse);
            }

            connection.Close();

            return productieList;
        }

        private List<GestiuneStoc> GetGestiuneForProdus(int codProdus)
        {
            var gestiuni = new List<GestiuneStoc>();

            var connection = new SqlConnection(_connectionString);
            connection.Open();

            var command = new SqlCommand(
                "SELECT CodProdus, CategorieNume, CategorieID, Stare FROM GestiuneStoc WHERE CodProdus = @cod",
                connection);

            command.Parameters.AddWithValue("@cod", codProdus);

            var reader = command.ExecuteReader();
            while (reader.Read())
            {
                var gestiuneStocDetalii = new GestiuneStoc();
                gestiuneStocDetalii.CodProdus = Convert.ToInt32(reader["CodProdus"]);
                gestiuneStocDetalii.CategorieNume = reader["CategorieNume"].ToString();
                gestiuneStocDetalii.CategorieID = Convert.ToInt32(reader["CategorieID"]);
                gestiuneStocDetalii.Stare = reader["Stare"].ToString();

                gestiuni.Add(gestiuneStocDetalii);
            }

            connection.Close();
            return gestiuni;
        }

        // INSERT
        private void insertButton_Click(object sender, EventArgs e)
        {
            var formProdus = new proiect_PAW_2025.Forms.FormProdus();

            if(formProdus.ShowDialog() == DialogResult.OK)
            {
                Produs produsNou = formProdus.ProdusCreat;

                var connection = new SqlConnection(_connectionString);
                connection.Open();

                var command = new SqlCommand(
                     "INSERT INTO Produs (Cod, Denumire, Pret, Cantitate) " +
                     "VALUES (@cod, @denumire, @pret, @cantitate)", connection);

                command.Parameters.AddWithValue("@cod", produsNou.Cod);
                command.Parameters.AddWithValue("@denumire", produsNou.Denumire);
                command.Parameters.AddWithValue("@pret", produsNou.Pret);
                command.Parameters.AddWithValue("@cantitate", produsNou.Cantitate);

                command.ExecuteNonQuery();
                connection.Close();

                productsDataGridView.DataSource = null;
                productsDataGridView.DataSource = GetProducsFromDB();
            }
        }

        private int codProdusSelectat = -1;

        private void productsDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                var randSelectat = productsDataGridView.Rows[e.RowIndex];
                codProdusSelectat = Convert.ToInt32(randSelectat.Cells["Cod"].Value);

                productie_DataGridView.DataSource = GetProductieForProdus(codProdusSelectat);
                gestiuneStoc_DataGridView.DataSource = GetGestiuneForProdus(codProdusSelectat);
            }
        }

        private void addProductie_button_Click(object sender, EventArgs e)
        {
            if(codProdusSelectat == -1)
            {
                MessageBox.Show("Pentru realizarea functionalitatii butonului apasat, " +
                    "trebuie selectat un produs!");
                return;
            }

            var formProductie = new FormProductie(codProdusSelectat);
            if(formProductie.ShowDialog() == DialogResult.OK)
            {
                Productie productie = formProductie.ProductieCreata;

                var connection = new SqlConnection(_connectionString);
                connection.Open();

                var command = new SqlCommand(
                    "INSERT INTO Productie (CodProdus, Cost, TimpProductie) " +
                    "VALUES (@codProdus, @cost, @timp)", connection);

                command.Parameters.AddWithValue("@codProdus", productie.CodProdus);
                command.Parameters.AddWithValue("@cost", productie.Cost);
                command.Parameters.AddWithValue("@timp", productie.TimpProductie);

                command.ExecuteNonQuery();
                connection.Close();

                productie_DataGridView.DataSource = null; 
                productie_DataGridView.DataSource = GetProductieForProdus(codProdusSelectat);
            }
        }

        private void addGestiuneStoc_Button_Click(object sender, EventArgs e)
        {
            if(codProdusSelectat == -1)
            {
                MessageBox.Show("Pentru realizarea functionalitatii butonului apasat, " +
                    "trebuie selectat un produs!");
                return;
            }

            var formGestiuneStoc = new FormGestiuneStoc(codProdusSelectat);

            if(formGestiuneStoc.ShowDialog() == DialogResult.OK)
            {
                GestiuneStoc gestiune = formGestiuneStoc.GestiuneStocCreata;

                var connection = new SqlConnection(_connectionString);
                connection.Open();

                var command = new SqlCommand(
                    "INSERT INTO GestiuneStoc (CodProdus, CategorieNume, CategorieID, Stare) " +
                    "VALUES (@codProdus, @categorieNume, @categorieID, @stare)", connection);

                command.Parameters.AddWithValue("@codProdus", gestiune.CodProdus);
                command.Parameters.AddWithValue("@categorieNume", gestiune.CategorieNume);
                command.Parameters.AddWithValue("@categorieID", gestiune.CategorieID);
                command.Parameters.AddWithValue("@stare", gestiune.Stare);

                command.ExecuteNonQuery();
                connection.Close();

                gestiuneStoc_DataGridView.DataSource = null;
                gestiuneStoc_DataGridView.DataSource = GetGestiuneForProdus(codProdusSelectat);
            }
        }

        // EDIT 
        private void editProdus_Button_Click(object sender, EventArgs e)
        {
            if (codProdusSelectat == -1)
            {
                MessageBox.Show("Pentru realizarea functionalitatii butonului apasat, " +
                    "trebuie selectat un produs!");
                return;
            }

            Produs produsDeEditat = null;
            foreach (Produs p in GetProducsFromDB())
            {
                if (p.Cod == codProdusSelectat)
                {
                    produsDeEditat = p;
                    break;
                }
            }

            if (produsDeEditat == null)
            {
                MessageBox.Show("Produsul selectat nu mai există!");
                return;
            }

            var formEdit = new FormProdus(produsDeEditat);
            if (formEdit.ShowDialog() == DialogResult.OK)
            {
                Produs produsModificat = formEdit.ProdusCreat;

                var connection = new SqlConnection(_connectionString);
                connection.Open();

                var command = new SqlCommand(
                    "UPDATE Produs SET Denumire = @denumire, Pret = @pret, " +
                    "Cantitate = @cantitate " +
                    "WHERE Cod = @cod", connection);

                command.Parameters.AddWithValue("@cod", produsModificat.Cod);
                command.Parameters.AddWithValue("@denumire", produsModificat.Denumire);
                command.Parameters.AddWithValue("@pret", produsModificat.Pret);
                command.Parameters.AddWithValue("@cantitate", produsModificat.Cantitate);

                command.ExecuteNonQuery();
                connection.Close();

                productsDataGridView.DataSource = null;
                productsDataGridView.DataSource = GetProducsFromDB();
            }
        }

        // DELETE
        private void deleteProdus_button_Click(object sender, EventArgs e)
        {
            if (codProdusSelectat == -1)
            {
                MessageBox.Show("Pentru realizarea functionalitatii butonului apasat, " +
                    "trebuie selectat un produs!");
                return;
            }

            var confirm = MessageBox.Show("Confirm stergerea produsului selectat , " +
                "precum si toate detaliile asociate acestuia?",
                "Confirmare ștergere", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (confirm == DialogResult.Yes)
            {
                var connection = new SqlConnection(_connectionString);
                connection.Open();
               // connection.BeginTransaction();  

                // stergere din PRODUCTIE
                var deleteProductie = new SqlCommand(
                    "DELETE FROM Productie WHERE CodProdus = @cod", connection);
                deleteProductie.Parameters.AddWithValue("@cod", codProdusSelectat);
                deleteProductie.ExecuteNonQuery();

                // stergere din GESTIUNE STOCURI
                var deleteGestiune = new SqlCommand(
                    "DELETE FROM GestiuneStoc WHERE CodProdus = @cod", connection);
                deleteGestiune.Parameters.AddWithValue("@cod", codProdusSelectat);
                deleteGestiune.ExecuteNonQuery();

                // stergere din PRODUS
                var deleteProdus = new SqlCommand(
                    "DELETE FROM Produs WHERE Cod = @cod", connection);
                deleteProdus.Parameters.AddWithValue("@cod", codProdusSelectat);
                deleteProdus.ExecuteNonQuery();

                connection.Close();

                MessageBox.Show("Produsul si detaliile asociate au fost sterse cu SUCCES!");

                productsDataGridView.DataSource = null;
                productsDataGridView.DataSource = GetProducsFromDB();

                productie_DataGridView.DataSource = null;
                gestiuneStoc_DataGridView.DataSource = null;

                codProdusSelectat = -1;
            }
        }
    }
}