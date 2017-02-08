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

namespace WPF_Hello
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        int timesPressed = 0;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnHello_Click(object sender, RoutedEventArgs e)
        {
            timesPressed++;
            txbHello.Text = "Hello " + txtName.Text;
            MessageBox.Show("Terve " + txtName.Text, "Tuomas'es Juttu");
            txbCount.Text = timesPressed.ToString();
            txbMessage.Text = "painoin buttonia tnbHello";
        }

        private void btnAbout_Click(object sender, RoutedEventArgs e)
        {
            //kutsutaan näkyviin about- ikkuna
            About about = new About();
            //huom ikkuna voi olla modaalinen(täytyy sulkea ennen muihin ikkonoihin palaamista) tai tavallinen
            about.ShowDialog();
        }

        private void btnExit_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
