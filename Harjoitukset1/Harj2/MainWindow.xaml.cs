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
        double myValue;
        double input;
        double convertRate = 5.94573;
        string output;
        public MainWindow()
        {
            InitializeComponent();
        }
        private void toEuroButton_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                input = double.Parse(inputBox.Text);
                myValue = input / convertRate;
                output = myValue.ToString("0.00");
                outputBlock.Text = "Tulos: " + output + " euroa";
            }
            catch (Exception ex)
            {
                outputBlock.Text = ex.Message + "\n-Annoithan mitat numeroina(mm)?";
            }
        }

        private void toMarkkaButton_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                input = double.Parse(inputBox.Text);
                myValue = convertRate * input;
                output = myValue.ToString("0.00");
                outputBlock.Text = "Tulos: " + output + " markkaa";
            }
            catch (Exception ex)
            {
                outputBlock.Text = ex.Message + "\n-Annoithan mitat numeroina(mm)?";
            }
        }
    }
}
