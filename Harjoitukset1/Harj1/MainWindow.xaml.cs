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

namespace Harj1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        int truckCount = 0;
        int carCount = 0;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void truckButton_Click(object sender, RoutedEventArgs e)
        {
            truckCount++;
            truckBlock.Text = truckCount.ToString();
        }

        private void carButton_Click(object sender, RoutedEventArgs e)
        {
            carCount++;
            carBlock.Text = carCount.ToString();
        }
    }
}
