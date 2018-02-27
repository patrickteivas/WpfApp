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

namespace WpfApp1
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

        private void Liida(object sender, RoutedEventArgs e)
        {
            try
            {
                CalculationResult.Content = int.Parse(FirstNumber.Text) + int.Parse(SecondNumber.Text);
            }
            catch (System.FormatException)
            {
                CalculationResult.Content = "Vale sisestus";
            }
            catch (System.OverflowException)
            {
                CalculationResult.Content = "Liiga suur number";
            }
        }
        private void Lahuta(object sender, RoutedEventArgs e)
        {
            try
            {
                CalculationResult.Content = int.Parse(FirstNumber.Text) - int.Parse(SecondNumber.Text);
            }
            catch (System.FormatException)
            {
                CalculationResult.Content = "Vale sisestus";
            }
            catch (System.OverflowException)
            {
                CalculationResult.Content = "Liiga suur number";
            }
        }
        private void Korruta(object sender, RoutedEventArgs e)
        {
            try
            {
                CalculationResult.Content = int.Parse(FirstNumber.Text) * int.Parse(SecondNumber.Text);
            }
            catch (System.FormatException)
            {
                CalculationResult.Content = "Vale sisestus";
            }
            catch (System.OverflowException)
            {
                CalculationResult.Content = "Liiga suur number";
            }
        }
        private void Jaga(object sender, RoutedEventArgs e)
        {
            try
            {
                CalculationResult.Content = int.Parse(FirstNumber.Text) / int.Parse(SecondNumber.Text);
            }
            catch (System.FormatException)
            {
                CalculationResult.Content = "Vale sisestus";
            }
            catch (System.OverflowException)
            {
                CalculationResult.Content = "Liiga suur number";
            }
        }
    }
}
