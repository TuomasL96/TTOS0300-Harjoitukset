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
        double value;
        double input;
        double convertRate = 5.94573;
        string output;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void toEuroButton_Click(object sender, RoutedEventArgs e)
        {
            input = double.Parse(inputBox.Text);
            value = input / convertRate;
            output = value.ToString("0.00");
            outputBlock.Text = "Tulos: " + output + " euroa";
        }

        private void toMarkkaButton_Click(object sender, RoutedEventArgs e)
        {
            input = double.Parse(inputBox.Text);
            value = convertRate * input;
            output = value.ToString("0.00");
            outputBlock.Text = "Tulos: " + output + " markkaa";
        }
    }
}
