using System;
using System.Collections.Generic;
using System.Collections.ObjectModel; // for observableobject
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
using JAMK.ICT;

namespace DataBindingDemo
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        //koska useampi metodi-tapahtumankäsittelijä tulee käyttämään näitä muuttujia -->
        // määritellään luokan tasolle jäsenmuuttujiksi
        JAMK.ICT.HockeyLeague liiga = new JAMK.ICT.HockeyLeague();
        ObservableCollection<JAMK.ICT.HockeyTeam> joukkueet;
        int counter = 0;
        public MainWindow()
        {
            InitializeComponent();
            InitMyStuff();
        }
        private void InitMyStuff()
        {
            //tänne kootusti omien kontrollien alustukset
            List<String> muuvit = new List<string>();
            muuvit.Add("Halloween");
            muuvit.Add("Jaws");
            muuvit.Add("Star Wars");
            muuvit.Add("Pahat pojat");
            cmbMovies.ItemsSource = muuvit;
            // haetaan smliiga-joukkueet classista
            liiga = new JAMK.ICT.HockeyLeague();
            joukkueet = liiga.GetTeams();
            cmbTeam.ItemsSource = joukkueet;
        }

        private void btnBind_Click(object sender, RoutedEventArgs e)
        {
            //määritellään stackpaneelin datacontext
            //Demo01: datakonteksti on olio
            //HockeyTeam tiimi = new JAMK.ICT.HockeyTeam("TuoTeam", "Leppävirta");
            //spRight.DataContext = tiimi;
            //demo02 kytketään olio-kokoelma 1. olioon
            spRight.DataContext = joukkueet[counter];
        }

        private void btnForward_Click(object sender, RoutedEventArgs e)
        {
            if (counter < joukkueet.Count - 1)
            {
                counter++;
            }
            spRight.DataContext = joukkueet[counter];
        }

        private void btnBackward_Click(object sender, RoutedEventArgs e)
        {
            if (counter > 0)
            {
                counter--;
            }
            spRight.DataContext = joukkueet[counter];
        }

        private void btnAdd_Click(object sender, RoutedEventArgs e)
        {
            liiga.addTeam(txbName.Text, txbCity.Text);
        }
    }
}
