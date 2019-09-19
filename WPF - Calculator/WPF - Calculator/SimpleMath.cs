using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace WPF___Calculator
{
    class SimpleMath
    {
        public double Add(double n1, double n2)
        {
            return n1 + n2;
        }
        public double SubStraction(double n1, double n2)
        {
            return n1 - n2;
        }
        public double Divide(double n1, double n2)
        {
            if (n2 == 0)
            {
                MessageBox.Show("Division by 0 is not supported", "Wrong operation", MessageBoxButton.OK,
                    MessageBoxImage.Error);
                return 0;
            }
            return n1 / n2;
        }
        public double Multiply(double n1, double n2)
        {
            return n1 * n2;
        }
    }
}
