using CoinCheck.Service.Implementation;
using CoinCheck.WPF.View;
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
            InitializeComponent();
            TopCoin topCoin = new();
            CoinInfo coinInfo = new ();
            TopCoin.NavigationService.Navigate(topCoin);
            CoinDetail.NavigationService.Navigate(coinInfo);
        }
    }
}
