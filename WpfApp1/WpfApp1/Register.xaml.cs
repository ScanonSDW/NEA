using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using System.Data.SqlClient;
using System.Data;

namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for Register.xaml
    /// </summary>
    public partial class Register : Window
    {
        public Register()
        {
            InitializeComponent();
        }

        string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Scott Wilson\source\repos\WpfApp1\WpfApp1\Database.mdf;Integrated Security=True";

        private void RegisterClicked(object sender, EventArgs e)
        {
            if (txtboxFirstName.Text == "" || txtboxLastName.Text == "" || txtboxUsername.Text == "" || txtboxEmail.Text == "" || txtboxPassword.Text == "")
                MessageBox.Show("Please enter data");
            else
            {
                SqlConnection sqlCon = new SqlConnection(connectionString);
                SqlCommand sqlcmd = new SqlCommand();
                sqlCon.Open();
                SqlCommand sqlCmd = new SqlCommand("INSERT INTO tblUser(Username,FirstName,LastName,Email,Password) VALUES ('" + txtboxUsername.Text + "','" + txtboxFirstName.Text + "','" + txtboxLastName.Text + "','" + txtboxEmail.Text + "','" + txtboxPassword.Text + "')", sqlCon);
                sqlCmd.ExecuteNonQuery();
                MessageBox.Show("Registered");
                Clear();
                sqlCon.Close();
            }
            
        }
        void Clear()
        {
            txtboxUsername.Text = txtboxFirstName.Text = txtboxLastName.Text = txtboxEmail.Text = txtboxPassword.Text = "";
        }

        private void btnBackReg_Click(object sender, RoutedEventArgs e)
        {
            var newForm = new MainWindow();
            newForm.Show();
            this.Close();
        }

        private void btnGotoLogin_Click(object sender, RoutedEventArgs e)
        {
            var newForm = new Login();
            newForm.Show();
            this.Close();
        }
    }
}
