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
using MySql.Data;
using MySql.Data.MySqlClient;

namespace Login
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

        /* If user registers, its information will be stored into databse
         */
        private void btnRegister_Click(object sender, RoutedEventArgs e)
        {
            string name = txtRegName.Text;
            string email = txtRegEmail.Text;
            string password = txtRegPwd.Password;

            string connection = "datasource=localhost; port=3306; username=root; password=sang12529; database=pizzashop";

            string query = "insert into user(`id`,`name`,`email`,`password`) values(null,'" + name + "','" + email + "','" + password + "')";

            MySqlConnection conn = new MySqlConnection(connection);

            MySqlCommand command = new MySqlCommand(query, conn);

            command.CommandTimeout = 60;

            conn.Open();

            MySqlDataReader dataReader = command.ExecuteReader();

            conn.Close();

            MessageBox.Show("User is registered successfully");
        }
    }
}

