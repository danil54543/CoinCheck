using CoinCheck.Service.Implementation;
using System.Windows;

namespace CoinCheck.WPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            CurrencyService currencyService = new();
            InitializeComponent();
            currencyService.GetTop7Coin();
        }
    }
}
