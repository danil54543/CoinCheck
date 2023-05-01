using CoinCheck.WPF.ViewModel;
using System.Windows.Controls;

namespace CoinCheck.WPF.View
{
    /// <summary>
    /// Логика взаимодействия для TopCoin.xaml
    /// </summary>
    public partial class TopCoin : Page
    {
        public TopCoin()
        {
            InitializeComponent();
            DataContext = new TopCoinViewModel();

        }

        private void SelectionClick(object sender, SelectionChangedEventArgs e)
        {
        }
    }
}
