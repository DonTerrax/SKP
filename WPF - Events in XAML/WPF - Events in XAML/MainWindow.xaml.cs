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

namespace WPF___Events_in_XAML
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

        private void Button_click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Button was clicked - Direct event");
        }


        private void UIElement_OnMouseUp(object sender, MouseButtonEventArgs e)
        {
            MessageBox.Show("Mouse button went up / was released");
        }

        private void UIElement_OnPreviewMouseUp(object sender, MouseButtonEventArgs e)
        {
            
            MessageBox.Show("Mouse button went up / was released - Tunneling event");
        }


        private void UIElement_OnPreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            MessageBox.Show("Left Mouse button went down - tunneling event ");

        }

        private void UIElement_OnPreviewMouseRightButtonUp(object sender, MouseButtonEventArgs e)
        {
            MessageBox.Show("Right Mouse button went up - tunneling event");

        }
    }
}
