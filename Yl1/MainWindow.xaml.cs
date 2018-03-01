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

namespace Yl1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            List<Inimene> Inimesed = new List<Inimene>();
            Inimesed.Add(new Inimene() { Nimi = "Mait", Perekonnanimi = "Rappu", Vanus = 17 });
            Inimesed.Add(new Inimene() { Nimi = "Joosep", Perekonnanimi = "Kolk", Vanus = 50 });
            Inimesed.Add(new Inimene() { Nimi = "Jaanus", Perekonnanimi = "Dra", Vanus = 90 });

            InimesedListBox.ItemsSource = Inimesed;
        }
    }

    public class Inimene
    {
        public string Nimi { get; set; }
        public string Perekonnanimi { get; set; }
        public int Vanus { get; set; }
    }
}
