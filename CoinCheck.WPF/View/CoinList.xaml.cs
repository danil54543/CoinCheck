﻿using CoinCheck.WPF.ViewModel;
using System.Windows;
using System.Windows.Controls;

namespace CoinCheck.WPF.View
{
    public partial class CoinList : Page
    {
        private CoinListViewModel viewModel;
        public CoinList()
        {
            InitializeComponent();
            viewModel = new();
            viewModel.GetAllCoin();
            DataContext = viewModel;
        }

        private void SearchButton_Click(object sender, RoutedEventArgs e)
        {
            viewModel.Search(SearchTextBox.Text);
            DataContext = viewModel;
        }

        private void UpdateButton_Click(object sender, RoutedEventArgs e)
        {
            viewModel.GetAllCoin();
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
