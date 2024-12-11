using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace edytortekstu
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

        private void lewo_Click(object sender, RoutedEventArgs e)
        {
            tekst.TextAlignment = TextAlignment.Left;
        }

        private void srodek_Click(object sender, RoutedEventArgs e)
        {
            tekst.TextAlignment = TextAlignment.Center;
        }

        private void justuj_Click(object sender, RoutedEventArgs e)
        {
            tekst.TextAlignment = TextAlignment.Justify;
        }

        private void prawo_Click(object sender, RoutedEventArgs e)
        {
            tekst.TextAlignment = TextAlignment.Right;
        }

        private void pogrub_Checked(object sender, RoutedEventArgs e)
        {
            tekst.FontWeight = FontWeights.Bold;
        }

        private void pogrub_unChecked(object sender, RoutedEventArgs e)
        {
            tekst.FontWeight = FontWeights.Normal;
        }

        private void podkresl_Checked(object sender, RoutedEventArgs e)
        {
            tekst.TextDecorations = TextDecorations.Underline;
        }

        private void podkresl_unChecked(object sender, RoutedEventArgs e)
        {
            tekst.TextDecorations = null;
        }

        private void kursywa_Checked(object sender, RoutedEventArgs e)
        {
            tekst.FontStyle = FontStyles.Italic;
        }

        private void kursywa_unChecked(object sender, RoutedEventArgs e)
        {
            tekst.FontStyle = FontStyles.Normal;
        }

        private void niebieski_Checked(object sender, RoutedEventArgs e)
        {
            tekst.Foreground = Brushes.Blue;
        }

        private void fioletowy_Checked(object sender, RoutedEventArgs e)
        {
            tekst.Foreground = Brushes.Purple;
        }

        private void czerwony_Checked(object sender, RoutedEventArgs e)
        {
            tekst.Foreground = Brushes.Red;
        }

        private void rozmiarczcionki_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            tekst.FontSize = rozmiarczcionki.Value;
        }
    }
}