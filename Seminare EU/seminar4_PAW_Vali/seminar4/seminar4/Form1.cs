using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace seminar4 { 

    public partial class Form1 : Form { 
        private List<Student> _students;
    
        public Form1()
        {
            InitializeComponent();
            _students = new List<Student>();
        }

        private void SaveBtn_Click(object sender, EventArgs e)
        {
            var student = new Student();
            student.FirstName = FirstNameTextBox.Text;
            student.LastName = LastNameTextBox.Text;
            var result = ushort.TryParse(AgeTextBox.Text, out ushort age);
            if (!result)
            {
                MessageBox.Show("Age is not valid", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            student.Age = age;

            _students.Add(student);

            FirstNameTextBox.Text = string.Empty;
            LastNameTextBox.Text = string.Empty;
            AgeTextBox.Text = string.Empty;
        }
    }
}
