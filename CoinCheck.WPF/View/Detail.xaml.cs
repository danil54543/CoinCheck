using CoinCheck.Domain.Model;
using System.Windows;

namespace CoinCheck.WPF.View
{
    /// <summary>
    /// Логика взаимодействия для Detail.xaml
    /// </summary>
    public partial class Detail : Window
    {
        public Detail(Coin coin)
        {
            InitializeComponent();
            Name.Content = coin.Name;
            Symbol.Content = coin.Symbol.ToUpper();
            Usd.Content = coin.MarketData.CurrentPrice.Usd.ToString() + " $";
            Uah.Content = coin.MarketData.CurrentPrice.Uah.ToString() + " ₴";
        }
    }
}
