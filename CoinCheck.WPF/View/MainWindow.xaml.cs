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
            CoinInfo coinInfo = new();
            TopCoin.NavigationService.Navigate(topCoin);
            CoinDetail.NavigationService.Navigate(coinInfo);
            CoinList.NavigationService.Navigate(coinList);
        }
    }
}
