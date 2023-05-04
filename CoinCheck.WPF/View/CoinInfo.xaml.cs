using CoinCheck.WPF.ViewModel;
using System.Windows.Controls;

namespace CoinCheck.WPF.View
{
    public partial class CoinInfo : Page
    {
        public CoinInfo(string id)
        {
            InitializeComponent();
            DataContext = new CoinInfoViewModel(id);

        }
    }
}
