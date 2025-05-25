using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PAW_seminar8_05_05_2025
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            //using(var stream = new FileStream("export.bin", FileMode.Open))
            //{
            //    var formatter = new BinaryFormatter();
            //   // FakeDatabase.Files = (List<FileMode>)formatter.Serialize(stream);
                
            //}

            // stil de afisare in list view 
            filesListView.View = View.Details;
            filesListView.Columns.Add("File Name", 300);
            filesListView.Columns.Add("Extension");
            filesListView.Columns.Add("Modifiesd On");

            foreach(var file in FakeDatabase.Files)
            {
                var item = new ListViewItem();
                item.Text = file.Name;
                item.SubItems.Add(file.Extension);
                item.SubItems.Add(file.ModifiedOn.ToString("dddd dd/MMMM/yyyy"));

                filesListView.Items.Add(item);
            }
        }

        private void serializeButton_Click(object sender, EventArgs e)
        {
            // serializare binara
            // Metoda 1
            //var stream = new FileStream("export.bin", FileMode.OpenOrCreate);
            //stream.Close();
            //stream.Dispose();

            // Metoda 2
            using (var stream = new FileStream("export.bin", FileMode.OpenOrCreate))
            {
                var formatter = new BinaryFormatter();
                formatter.Serialize(stream, FakeDatabase.Files);
            }
        }
    }
}
