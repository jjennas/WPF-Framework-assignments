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

namespace WpfCalculator
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    /// 
    public partial class MainWindow : Window
    {
        int number1 = 0;
        int number2 = 0;
        string operation = "";

        public MainWindow()
        {
            InitializeComponent();
        }

        private void one_Click(object sender, RoutedEventArgs e)
        {
            if (operation == "")
            {
                number1 = (number1 * 10) + 1;
                Output.Text = number1.ToString();
            }
            else {
                number2 = (number2 * 10) + 1;
                Output.Text = number2.ToString();
            }
        }

        private void two_Click(object sender, RoutedEventArgs e)
        {
            if (operation == "")
            {
                number1 = (number1 * 10) + 2;
                Output.Text = number1.ToString();
            }
            else
            {
                number2 = (number2 * 10) + 2;
                Output.Text = number2.ToString();
            }
        }

        private void three_Click(object sender, RoutedEventArgs e)
        {
            if (operation == "")
            {
                number1 = (number1 * 10) + 3;
                Output.Text = number1.ToString();
            }
            else
            {
                number2 = (number2 * 10) + 3;
                Output.Text = number2.ToString();
            }

        }

        private void four_Click(object sender, RoutedEventArgs e)
        {
            if (operation == "")
            {
                number1 = (number1 * 10) + 4;
                Output.Text = number1.ToString();
            }
            else
            {
                number2 = (number2 * 10) + 4;
                Output.Text = number2.ToString();
            }

        }

        private void five_Click(object sender, RoutedEventArgs e)
        {
            if (operation == "")
            {
                number1 = (number1 * 10) + 5;
                Output.Text = number1.ToString();
            }
            else
            {
                number2 = (number2 * 10) + 5;
                Output.Text = number2.ToString();
            }

        }

        private void six_Click(object sender, RoutedEventArgs e)
        {
            if (operation == "")
            {
                number1 = (number1 * 10) + 6;
                Output.Text = number1.ToString();
            }
            else
            {
                number2 = (number2 * 10) + 6;
                Output.Text = number2.ToString();
            }

        }

        private void seven_Click(object sender, RoutedEventArgs e)
        {
            if (operation == "")
            {
                number1 = (number1 * 10) + 7;
                Output.Text = number1.ToString();
            }
            else
            {
                number2 = (number2 * 10) + 7;
                Output.Text = number2.ToString();
            }

        }

        private void eight_Click(object sender, RoutedEventArgs e)
        {
            if (operation == "")
            {
                number1 = (number1 * 10) + 8;
                Output.Text = number1.ToString();
            }
            else
            {
                number2 = (number2 * 10) + 8;
                Output.Text = number2.ToString();
            }

        }

        private void nine_Click(object sender, RoutedEventArgs e)
        {
            if (operation == "")
            {
                number1 = (number1 * 10) + 9;
                Output.Text = number1.ToString();
            }
            else
            {
                number2 = (number2 * 10) + 9;
                Output.Text = number2.ToString();
            }

        }

        private void zero_Click(object sender, RoutedEventArgs e)
        {
            if (operation == "")
            {
                number1 = (number1 * 10) + 0;
                Output.Text = number1.ToString();
            }
            else
            {
                number2 = (number2 * 10) + 0;
                Output.Text = number2.ToString();
            }

        }

        private void add_Click(object sender, RoutedEventArgs e)
        {
            operation = "+";
            Output.Text = "0";
        }

        private void sub_Click(object sender, RoutedEventArgs e)
        {
            operation = "-";
            Output.Text = "0";
        }

        private void multiply_Click(object sender, RoutedEventArgs e)
        {
            operation = "*";
            Output.Text = "0";
        }

        private void total_Click(object sender, RoutedEventArgs e)
        {
            if (operation == "+")
            {
                int sum = number1 + number2;
                Output.Text = sum.ToString();
            }
            else if (operation == "-")
            {
                int divide = number1 - number2;
                Output.Text = divide.ToString();
            }
            else if (operation == "*")
            {
                int multiply = number1 * number2;
                Output.Text = multiply.ToString();
            }
        }

        private void clear_Click(object sender, RoutedEventArgs e)
        {
            number1 = 0;
            number2 = 0;
            operation = "";

            Output.Text = "0";
        }
    }
}
