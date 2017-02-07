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

namespace Harj2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        double input;
        double output;
        double convertRate = 120.1234567;
        string value;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void toEuroButton_Click(object sender, RoutedEventArgs e)
        {
            double input = double.Parse(inputBox.ToString());
            output = convertRate / input;
            value = output.ToString("0.00");
            outputBlock.Text = "Tulos: " + value + " euroa";
        }

        private void toMarkkaButton_Click(object sender, RoutedEventArgs e)
        {
            double input = double.Parse(inputBox.ToString());
            output = convertRate * input;
            value = output.ToString("0.00");
            outputBlock.Text = "Tulos: " + value + " markkaa";
        }
    }
}
