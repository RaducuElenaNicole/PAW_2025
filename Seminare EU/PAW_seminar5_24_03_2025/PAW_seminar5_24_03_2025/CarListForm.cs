using PAW_seminar5_24_03_2025.Database;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

// F7

namespace PAW_seminar5_24_03_2025
{
    public partial class CarListForm : Form
    {
        public CarListForm()
        {
            InitializeComponent();

            carsDataGridView.AutoGenerateColumns = false;
            carsDataGridView.DataSource = FakeDatabase.Cars;

            AddTextBoxColumn("Id", "ID", isVisible: false);
            // pun cu : ca sa nu modific si restul parametrilor, adica sa raman default 
            AddTextBoxColumn("Make", "Marca");
            AddTextBoxColumn("Model", "Model");
            AddTextBoxColumn("Year", "An fabricatie");
            AddTextBoxColumn("Seats", "Numar locuri", 70);
            AddCheckBoxColumn("HasInsurance", "Are asigurare?", 100);
        }

        private void AddTextBoxColumn(string propertyName, string headerText, 
                                        int width = 150, bool isVisible = true)
        // int width = 150 -> valoare default => se poate transmite ca parametru o valoare, si daca nu se trimite va ramane 150 
        {
            var column = new DataGridViewTextBoxColumn();
            column.DataPropertyName = propertyName;
            column.Name = propertyName;
            column.HeaderText = headerText;
            column.Width = width; // latime 
            column.Visible = isVisible;
            carsDataGridView.Columns.Add(column);
        }

        private void AddCheckBoxColumn(string propertyName, string headerText,
                                        int width = 150, bool isVisible = true)
        {
            var column = new DataGridViewCheckBoxColumn();
            column.DataPropertyName = propertyName;
            column.Name = propertyName;
            column.HeaderText = headerText;
            column.Width = width; 
            column.Visible = isVisible;
            carsDataGridView.Columns.Add(column);
        }
    }
}
