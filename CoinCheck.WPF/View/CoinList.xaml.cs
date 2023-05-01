using CoinCheck.WPF.ViewModel;
using System.Windows.Controls;

namespace CoinCheck.WPF.View
{
    public partial class CoinList : Page
    {
        public CoinList()
        {
            InitializeComponent();
            DataContext = new CoinListViewModel();
        }
    }
}
