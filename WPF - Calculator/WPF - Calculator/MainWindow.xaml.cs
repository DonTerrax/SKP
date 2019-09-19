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

namespace WPF___Calculator
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private double lastNumber, result;
        private SelectedOperator selectedOperator;
        public MainWindow()
        {
            InitializeComponent();
            
            acButton.Click += AcButton_Click;
            negativeButton.Click += NegativeButton_Click;
            percentageButton.Click += PercentageButton_Click;
            equalButton.Click += EqualButton_Click;
        }

        private void EqualButton_Click(object sender, RoutedEventArgs e)
        {
            double newNumber;
            if (double.TryParse(resultLabel.Content.ToString(), out newNumber))
            {
                SimpleMath operation = new SimpleMath();
                switch (selectedOperator)
                {
                    case SelectedOperator.Addition:
                        result = operation.Add(lastNumber, newNumber);
                        break;
                    case SelectedOperator.SubStraction:
                        result = operation.SubStraction(lastNumber, newNumber);
                        break;
                    case SelectedOperator.Division:
                        result = operation.Divide(lastNumber, newNumber);
                        break;
                    case SelectedOperator.Multiplication:
                        result = operation.Multiply(lastNumber, newNumber);
                        break;
                }

                resultLabel.Content = result.ToString();
            }
        }

        private void PercentageButton_Click(object sender, RoutedEventArgs e)
        {
            double tempNumber;
            if (double.TryParse(resultLabel.Content.ToString(), out tempNumber))
            {
                tempNumber = tempNumber / 100;
                if (lastNumber != 0)
                    tempNumber *= lastNumber;
                resultLabel.Content = tempNumber.ToString();
            }
        }

        private void NegativeButton_Click(object sender, RoutedEventArgs e)
        {
            if (double.TryParse(resultLabel.Content.ToString(),out lastNumber))
            {
                lastNumber = lastNumber * -1;
                resultLabel.Content = lastNumber.ToString();
            }
        }

        private void AcButton_Click(object sender, RoutedEventArgs e)
        {
            resultLabel.Content = "0";
        }

        private void OperationButton_Click(object sender, RoutedEventArgs e)
        {
            if (double.TryParse(resultLabel.Content.ToString(), out lastNumber))
            {
                resultLabel.Content = "0";
            }

            if (sender == multiplyButton)
            {
                selectedOperator = SelectedOperator.Multiplication;
            }

            if (sender.Equals(divideButton))
            {
                selectedOperator = SelectedOperator.Division;
            }

            if (sender == plusButton)
            {
                selectedOperator = SelectedOperator.Addition;
            }

            if (sender == minusButton)
            {
                selectedOperator = SelectedOperator.SubStraction;
            }
        }

        private void pointButton_Click(object sender, RoutedEventArgs e)
        {
            if (resultLabel.Content.ToString().Contains("."))
            {
                //Do nothing
            }
            else
            {
                resultLabel.Content = $"{resultLabel.Content}.";
            }
            
        }

        private void NumberButton_Click(object sender, RoutedEventArgs e)
        {
            int selectedValue = 0;

            Button[] numberButtons = new Button[10]{zeroButton,oneButton,twoButton,threeButton,fourButton,fiveButton,sixButton,sevenButton,eightButton,nineButton};

            for (int i = 0; i < numberButtons.Length; i++)
            {
                if (sender == numberButtons[i])
                {
                    selectedValue = i;
                    i = numberButtons.Length + 1;
                }
            }

            if (resultLabel.Content.ToString()=="0")
            {
                resultLabel.Content = $"{selectedValue}";
            }
            else
            {
                resultLabel.Content = $"{resultLabel.Content}{selectedValue}";
            }
        }
    }

    public enum SelectedOperator
    {
        Addition,
        SubStraction,
        Division,
        Multiplication

    }

    
}
