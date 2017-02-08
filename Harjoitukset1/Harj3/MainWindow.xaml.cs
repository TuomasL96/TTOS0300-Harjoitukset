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

namespace Harj3
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
        private void calculateButton_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                double windowWidth = double.Parse(widthInput.Text);
                double windowHeight = double.Parse(heightInput.Text);
                double karmiWidth = double.Parse(karmiWidthInput.Text);
                outputIPA.Text = ((windowHeight * windowWidth) / 10).ToString() + " cm^2";
                outputLPA.Text = (((windowHeight - (karmiWidth * 2)) * (windowWidth - (karmiWidth * 2))) / 10).ToString() + " cm^2";
                outputKarmi.Text = (((2 * windowHeight) + (2 * windowWidth)) / 10).ToString() + " cm";
            }
            catch (Exception ex)
            {
                Error.Text = ex.Message + "\n\nTapahtui jokin virhe!\n\nAnnoithan mitat numeroina(mm)?";
            }
        }
    }
}
