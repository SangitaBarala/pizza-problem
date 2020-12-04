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
using System.Windows.Navigation;
using System.Windows.Shapes;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace Login
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        /*Login and Registration by user
         */
        private void btnLogin_Click(object sender, RoutedEventArgs e)
        {
            string email = txtEmail.Text;
            string password = txtPassword.Password;

            if(Login(email,password))
            {
                HomePage home = new HomePage(email);
                home.Show();
                this.Hide();
            }
            else
            {
                lblMsg.Content = "invalid username or password";
            }
        }

        private void btnRegister_Click(object sender, RoutedEventArgs e)
        {
            Register register = new Register();
            register.Show();
            this.Hide();
        }

        /*Registered user can login. Login page is dynamic so for login you can use: username:sam@gmail.com and password:1234
         */
        public bool Login(string email, string password)
        {
            string connection = "datasource=localhost; port=3306; username=root; password=sang12529; database=pizzashop";

            string query = "select * from user where email='" + email + "' and password='" + password + "'";

            MySqlConnection conn = new MySqlConnection(connection);

            MySqlCommand command = new MySqlCommand(query, conn);

            command.CommandTimeout = 60;

            conn.Open();

            MySqlDataReader dataReader = command.ExecuteReader();

            if(dataReader.HasRows)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
