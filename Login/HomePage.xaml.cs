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
using System.Data;
using MySql.Data.MySqlClient;

namespace Login
{
    /// <summary>
    /// Interaction logic for HomePage.xaml
    /// </summary>
    public partial class HomePage : Window
    {
       
        public HomePage(string email)
        {
            InitializeComponent();
            lblHomeMsg.Content = "Hii " + email;
        }
        double total = 0.00;
        int toppings;
        bool IsChecked = false;
        private void rdSmall_Checked(object sender, RoutedEventArgs e)
        {
           if(rdSmall.IsChecked == true)
            {
                total += 10.00;
            }
            lblSubtotalResult.Content = total;

        }
        private void rdMedium_Checked(object sender, RoutedEventArgs e)
        {
            if (rdMedium.IsChecked == true)
            {
                total += 15.00;
            }
            lblSubtotalResult.Content = total;
        }

        private void rdLarge_Checked(object sender, RoutedEventArgs e)
        {
            if (rdLarge.IsChecked == true)
            {
                total += 20.00;
            }
            lblSubtotalResult.Content = total;
        }

        private void rdThick_Checked(object sender, RoutedEventArgs e)
        {
            if (rdThick.IsChecked == true)
            {
                total += 5.00;
            }
            lblSubtotalResult.Content = total;
        }

        private void rdThin_Checked(object sender, RoutedEventArgs e)
        {
            if (rdThin.IsChecked == true)
            {
                total += 3.00;
            }
            lblSubtotalResult.Content = total;
        }

        private void chkOnion_Checked(object sender, RoutedEventArgs e)
        {
            if(chkOnion.IsChecked==true)
            {
                toppings++;
                if (toppings > 2)
                {
                    total += 1.00;
                }
            }
            lblSubtotalResult.Content = total;
        }

        private void chkPineapple_Checked(object sender, RoutedEventArgs e)
        {
            if (chkPineapple.IsChecked == true)
            {
                toppings++;
                if (toppings > 2)
                {
                    total += 1.00;
                }
            }
            lblSubtotalResult.Content = total;
        }

        private void chkSausage_Checked(object sender, RoutedEventArgs e)
        {
            if (chkSausage.IsChecked == true)
            {
                toppings++;
                if (toppings > 2)
                {
                    total += 1.00;
                }
            }
            lblSubtotalResult.Content = total;
        }

        private void chkBacon_Checked(object sender, RoutedEventArgs e)
        {
            if (chkBacon.IsChecked == true)
            {
                toppings++;
                if (toppings > 2)
                {
                    total += 1.00;
                }
            }
            lblSubtotalResult.Content = total;
        }

        private void chkPepper_Checked(object sender, RoutedEventArgs e)
        {
            if (chkPepper.IsChecked == true)
            {
                toppings++;
                if (toppings > 2)
                {
                    total += 1.00;
                }
            }
            lblSubtotalResult.Content = total;
        }

        private void chkOlives_Checked(object sender, RoutedEventArgs e)
        {
            if (chkOlives.IsChecked == true)
            {
                toppings++;
                if (toppings > 2)
                {
                    total += 1.00;
                }
            }
            lblSubtotalResult.Content = total;
        }

      
    }
}
