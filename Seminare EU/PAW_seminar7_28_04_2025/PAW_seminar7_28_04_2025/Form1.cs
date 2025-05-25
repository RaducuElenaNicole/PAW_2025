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

namespace PAW_seminar7_28_04_2025
{
    public partial class Form1 : Form
    {
        private string _connectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\Ileana\\Documents\\paw1.mdf;Integrated Security=True;Connect Timeout=30";
        public Form1()
        {
            InitializeComponent();
            usersDataGridView.DataSource = GetUsersFromDatabse();
            usersDataGridView.AutoGenerateColumns = true;
        }

        // Exemplu de insert 
        private List<User> GetUsersFromDatabse()
        {
            var users = new List<User>();

            // get data from db 
            var connection = new SqlConnection(_connectionString);
            connection.Open();

            // ... 
            var command = new SqlCommand("SELECT  Id, FirstName, LastName, Email, " +
                                        "Password FROM Users", connection);
            var reader = command.ExecuteReader();
            while (reader.Read()) { 
                var user = new User();
                user.Id = reader.GetGuid(0);
                user.FirstName = reader.GetString(1);
                user.LastName = reader["LastName"].ToString();
                user.Email = reader["Email"].ToString();
                user.Password = reader["Password"].ToString();

                users.Add(user);
            }

            connection.Close();

            return users;
        }

        private void addUserButton_Click(object sender, EventArgs e)
        {
            var user = new User();
            user.Id = Guid.NewGuid();
            user.FirstName = "Gigel";
            user.LastName = "Ionel";
            user.Email = "gigel@ionel.ro";
            user.Password = "1234";

            var connection = new SqlConnection(_connectionString);
            connection.Open();

            var command = new SqlCommand(
                "INSERT INTO Users (Id, FirstName, LastName, Email, Password) " +
                "VALUES (@id, @firstName, @lastName, @email, @password)", 
                connection);

            command.Parameters.AddWithValue("id", user.Id); 
            command.Parameters.AddWithValue("firstName", user.FirstName); 
            command.Parameters.AddWithValue("lastName", user.LastName); 
            command.Parameters.AddWithValue("email", user.Email); 
            command.Parameters.AddWithValue("password", user.Password);
            
            command.ExecuteNonQuery();

            connection.Close();

            usersDataGridView.DataSource = null; 
            usersDataGridView.DataSource = GetUsersFromDatabse(); 
        }
    }
}
