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
        
        int toppings=0;
       
        double size_Price = 0.00;
        double crust_Price = 0.00;
        double topping_Price = 0.00;
        double extra_Price = 0.00;

        public HomePage(string email)
        {
            InitializeComponent();
            lblHomeMsg.Content = "Hii " + email;
        }
      
        /*pizza size radio buttons
         */
        private void rdSmall_Checked(object sender, RoutedEventArgs e)
        {
           if(rdSmall.IsChecked == true)
            {
               size_Price = 10.00;
            }
            update_ui();
        }
        private void rdMedium_Checked(object sender, RoutedEventArgs e)
        {
            if (rdMedium.IsChecked == true)
            {
                size_Price = 15.00;
            }
            update_ui();
        }

        private void rdLarge_Checked(object sender, RoutedEventArgs e)
        {
            if (rdLarge.IsChecked == true)
            {
                size_Price = 20.00;
            }
            update_ui();
        }

        /*pizza crust radio buttons
        */
        private void rdThick_Checked(object sender, RoutedEventArgs e)
        {
            if (rdThick.IsChecked == true)
            {
                crust_Price = 5.00;
            }
            update_ui();
        }

        private void rdThin_Checked(object sender, RoutedEventArgs e)
        {
            if (rdThin.IsChecked == true)
            {
                crust_Price = 3.00;
            }
            update_ui();
        }

        /*pizza toppings checkbox buttons
        */
        private void chkOnion_Checked(object sender, RoutedEventArgs e)
        {
            if(chkOnion.IsChecked==true)
            {
                toppings++;
                if (toppings > 2)
                {
                    topping_Price += 1.00;
                }
            }
            else
            {
                toppings--;
                if(toppings>2)
                {
                    topping_Price -= 1.00;
                }   
            }
            update_ui(); ;
        }

        private void chkPineapple_Checked(object sender, RoutedEventArgs e)
        {
            if (chkPineapple.IsChecked == true)
            {
                toppings++;
                if (toppings > 2)
                {
                    topping_Price += 1.00;
                }
            }
            else 
            {
                toppings--;
                if (toppings > 2)
                {
                    topping_Price -= 1.00;
                }
            }
            update_ui();
        }

        private void chkSausage_Checked(object sender, RoutedEventArgs e)
        {
            if (chkSausage.IsChecked == true)
            {
                toppings++;
                if (toppings > 2)
                {
                    topping_Price += 1.00;
                }
            }
            else
            {
                toppings--;
                if (toppings > 2)
                {
                    topping_Price -= 1.00;
                }
            }
            update_ui();
        }

        private void chkBacon_Checked(object sender, RoutedEventArgs e)
        {
            if (chkBacon.IsChecked == true)
            {
                toppings++;
                if (toppings > 2)
                {
                    topping_Price += 1.00;
                }
            }
            else
            {
                toppings--;
                if (toppings > 2)
                {
                    topping_Price -= 1.00;
                }
            }
            update_ui(); 
        }

        private void chkPepper_Checked(object sender, RoutedEventArgs e)
        {
            if (chkPepper.IsChecked == true)
            {
                toppings++;
                if (toppings > 2)
                {
                    topping_Price += 1.00;
                }
            }
            else
            {
                toppings--;
                if (toppings > 2)
                {
                    topping_Price -= 1.00;
                }
            }
            update_ui();
        }

        private void chkOlives_Checked(object sender, RoutedEventArgs e)
        {
            if (chkOlives.IsChecked == true)
            {
                toppings++;
                if (toppings > 2)
                {
                    topping_Price += 1.00;
                }
            }
            else
            {
                toppings--;
                if (toppings > 2)
                {
                    topping_Price -= 1.00;
                }
            }
            update_ui();
        }

        /*pizza extras checkbox buttons
        */
        private void chkPasta_Checked(object sender, RoutedEventArgs e)
        {
           if(chkPasta.IsChecked==true)
            {
                extra_Price += 5.00;
            }
            else
            {
               extra_Price -= 5.00;    
            }
            update_ui();
        }

        private void chkGarlicBread_Checked(object sender, RoutedEventArgs e)
        {
            if (chkGarlicBread.IsChecked == true)
            {
                extra_Price += 4.00;
            }
            else
            {
                extra_Price -= 4.00;
            }
            update_ui();
        }

        private void chkWings_Checked(object sender, RoutedEventArgs e)
        {
            if (chkWings.IsChecked == true)
            {
                extra_Price += 6.00;
            }
            else
            {
                extra_Price -= 6.00;
            }
            update_ui();
        }

        private void chkFries_Checked(object sender, RoutedEventArgs e)
        {
            if (chkFries.IsChecked == true)
            {
                extra_Price += 3.00;
            }
            else
            {
                extra_Price -= 3.00;
            }
            update_ui();
        }

        private void chkCan_Checked(object sender, RoutedEventArgs e)
        {
            if (chkCan.IsChecked == true)
            {
                extra_Price += 2.00;
            }
            else
            {
                extra_Price -= 2.00;
            }
            update_ui();
        }

        /*Calculate the price based on selected options of pizza
         */
        public double[] calculate_price()
        {
            double total= size_Price + crust_Price + topping_Price + extra_Price;
            double tax = Math.Round(0.13 * total,2);
            double[] price = {total,tax, Math.Round(total+tax,2)};
            return price;      
        }
        public void update_ui()
        {
            double[] prices = calculate_price();
            {
                 lblSubtotalResult.Content = "$" + prices[0];
                 lblHomeTaxResult.Content =  "$" + prices[1];
                 lblHomeGrandResult.Content ="$" + prices[2];  
            }
        }

        /*Order button implementation to place order and store the values in database
        */
        private void btnOrder_Click(object sender, RoutedEventArgs e)
        {  
            string size="";
            string crust="";
            //string topping = "";
            //string extra = "";

            if (rdSmall.IsChecked==true)
            {
                size = "small";
            }
            if (rdMedium.IsChecked == true)
            {
                size = "Medium";
            }
            if (rdLarge.IsChecked == true)
            {
                size = "Large";
            }
            if (rdThick.IsChecked == true)
            {
                crust = "Thick";
            }
            if (rdThin.IsChecked == true)
            {
                crust = "Thin";
            }
            //if (chkOnion.IsChecked == true)
            //{
            //    topping = "Onion";
            //}
            //if (chkPineapple.IsChecked == true)
            //{
            //    topping = "Pineapple";
            //}
            //if (chkSausage.IsChecked == true)
            //{
            //    topping = "sausage";
            //}
            //if (chkPepper.IsChecked == true)
            //{
            //    topping = "Green Pepper";
            //}
            //if (chkOlives.IsChecked == true)
            //{
            //    topping = "Olives";
            //}
            //if (chkBacon.IsChecked == true)
            //{
            //    topping = "Bacon";
            //}
            //if (chkPasta.IsChecked == true)
            //{
            //    extra = "Pasta";
            //}
            //if (chkGarlicBread.IsChecked == true)
            //{
            //    extra = "Garlic Bread";
            //}
            //if (chkWings.IsChecked == true)
            //{
            //    extra = "Chicken Wings";
            //}
            //if (chkFries.IsChecked == true)
            //{
            //    extra = "Fries";
            //}
            //if (chkCan.IsChecked == true)
            //{
            //    extra = "Can of Pop";
            //}
            
            string connection = "datasource=localhost; port=3306; username=root; password=sang12529; database=pizzashop";

            string query1 = "insert into order (`orderId`,`size`,`crust`) values(null,'" + size + "','" + crust + "');";
            
            //string query2 = "insert into topping(`toppingId`,`orderId`,`topping`) values(null,'" + orderId + "','" + topping + "')";
            //string query3 = "insert into extra(`extraId`,`orderId`,`extraName`) values(null,'" + orderId2 + "','" + extra + "')";

            MySqlConnection conn = new MySqlConnection(connection);

            MySqlCommand command1 = new MySqlCommand(query1, conn);

            //command1.CommandType = CommandType.StoredProcedure;
            //command1.Parameters.AddWithValue("@orderId", null);
            //command1.Parameters.AddWithValue("@size", size);
            //command1.Parameters.AddWithValue("@crust", crust);
            //MySqlCommand command2 = new MySqlCommand(query2, conn);
            //MySqlCommand command3 = new MySqlCommand(query3, conn);

            command1.CommandTimeout = 60;
            //command2.CommandTimeout = 60;
            //command3.CommandTimeout = 60;

            conn.Open();
            
            MySqlDataReader dataReader = command1.ExecuteReader();

            //MySqlDataReader dataReader1 = command1.ExecuteReader();
            //int orderId = Convert.ToInt32(command2.ExecuteScalar());
            //int orderId2 = Convert.ToInt32(command3.ExecuteScalar());
            // MySqlDataReader dataReader2 = command2.ExecuteReader();

            conn.Close();
            
            
            MessageBox.Show("Thank You ! your order has been placed");    
        }
        //public static void main(string[] args)
        //{
        //    Application.Run();
        //}
    }
}

