using CoinCheck.WPF.View;
using System.Windows;

namespace CoinCheck.WPF
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            TopCoin topCoin = new();
            CoinList coinList = new ();
            TopCoin.NavigationService.Navigate(topCoin);
            CoinList.NavigationService.Navigate(coinList);
        }
    }
}
