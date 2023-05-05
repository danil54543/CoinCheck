using CoinCheck.WPF.ViewModel;
using System.Windows.Controls;

namespace CoinCheck.WPF.View
{
    public partial class TopCoin : Page
    {
        private TopCoinViewModel viewModel;
        public TopCoin()
        {
            InitializeComponent();
            viewModel = new();
            viewModel.GetTopCoin();
            DataContext = viewModel;

        }

        private void SelectionClick(object sender, SelectionChangedEventArgs e)
        {
            if (viewModel.SelectedCoin.Id != null)
            {
                
            }
        }
        
    }
}
