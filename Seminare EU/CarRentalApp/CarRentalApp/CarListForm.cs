using CarRentalApp.Database;
using System.CodeDom;
using System.Windows.Forms;

namespace CarRentalApp
{
    public partial class CarListForm: Form
    {
        public CarListForm() {
            InitializeComponent();

            carsDataGridView.AutoGenerateColumns = false;
            carsDataGridView.DataSource = FakeDatabase.Cars;

            AddTextBoxColumn("Id", "ID", isVisible: false);
            AddTextBoxColumn("Make", "Marca", 200);
            AddTextBoxColumn("Model", "Model", 180);
            AddTextBoxColumn("Year", "An");
            AddTextBoxColumn("Seats", "Locuri");
            AddCheckBoxColumn("HasInsurance", "Are asigurare");
            AddTextBoxColumn("LicenseNumber", "Numar de inmatriculare");

            AddButtonColumn("editColumn", "Editeaza");
            AddButtonColumn("deleteColumn", "Sterge");
        }

        private void AddTextBoxColumn(string propertyName, string headerText, int width = 100, bool isVisible = true) {
            var column = new DataGridViewTextBoxColumn();
            column.DataPropertyName = propertyName;
            column.HeaderText = headerText;
            column.Width = width;
            column.Name = propertyName;
            column.Visible = isVisible;
            carsDataGridView.Columns.Add(column);
        }

        private void AddCheckBoxColumn(string propertyName, string headerText, int width = 100) {
            var column = new DataGridViewCheckBoxColumn();
            column.DataPropertyName = propertyName;
            column.HeaderText = headerText;
            column.Width = width;
            column.Name = propertyName;
            carsDataGridView.Columns.Add(column);            
        }

        private void addCarToolStripMenuItem_Click(object sender, System.EventArgs e) {
            var addCarForm = new AddCarForm();
            addCarForm.ShowDialog();
            carsDataGridView.DataSource = null;
            carsDataGridView.DataSource = FakeDatabase.Cars;
        }

        private void AddButtonColumn(string columnName, string headerText)
        {
            var column = new DataGridViewButtonColumn();
            column.Name = columnName;
            column.HeaderText = headerText;
            column.Width = Width;
            column.DataPropertyName = columnName;
            column.UseColumnTextForButtonValue = true;
            column.Visible = true;
            carsDataGridView.Columns.Add(column);
        }

        private void carsDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var dataGridView = sender as DataGridView;
            var columnName = dataGridView.Columns[e.ColumnIndex].Name;

            if(columnName == "editColumn")
            {
                //editeaza 
                var car = dataGridView.Rows[e.RowIndex].DataBoundItem as Entities.Car;
                var updateCarForm = new UpdateCarForm(car);
                updateCarForm.ShowDialog();
                
            }

            if (columnName == "deleteColumn")
            {
                //stergere 
            }
        }
    }
}
