﻿using CoinCheck.WPF.ViewModel;
using System.Windows.Controls;

namespace CoinCheck.WPF.View
{
    public partial class CoinInfo : Page
    {
        public CoinInfo()
        {
            InitializeComponent();
            DataContext = new CoinInfoViewModel();

        }
    }
}
