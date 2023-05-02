using CoinCheck.WPF.ViewModel;
using System.Windows.Controls;

namespace CoinCheck.WPF.View
{
    public partial class CoinList : Page
    {
        public CoinList()
        {
            InitializeComponent();
            var coinListViewModel = new CoinListViewModel();
            coinListViewModel.GetAllCoin();
            DataContext = coinListViewModel;
        }

        

        private void SearchButton_Click(object sender, System.Windows.RoutedEventArgs e)
        {
            CoinListViewModel coinListViewModel = new();
            coinListViewModel.Search(SearchTextBox.Text);
            DataContext = coinListViewModel;
        }

        private void UpdateButton_Click(object sender, System.Windows.RoutedEventArgs e)
        {
            CoinListViewModel coinListViewModel = new();
            coinListViewModel.GetAllCoin();
            DataContext = coinListViewModel;
        }
    }
}
