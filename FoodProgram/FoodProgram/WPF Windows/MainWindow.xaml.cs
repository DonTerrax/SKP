using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Diagnostics;
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

namespace FoodProgram
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private SqlConnection sqlConnection;
        public MainWindow()
        {
            InitializeComponent();

            Console.WriteLine(ConfigurationManager.ConnectionStrings[0].ConnectionString);

        }

        private void ListBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void Login(object sender, RoutedEventArgs e)
        {

        }

        private void Sign_Up(object sender, RoutedEventArgs e)
        {
            SignUp sig = new SignUp();
            sig.ShowDialog();
        }

        private void Hyperlink_RequestNavigate(object sender, RequestNavigateEventArgs e)
        {
            RecoverPassword rec = new RecoverPassword();
            rec.ShowDialog();
        }


    }
}
