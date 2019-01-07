using CD3_Kyrkosh.Command;
using CodingDojo4DataLib;
using CodingDojo4DataLib.Converter;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace CD3_Kyrkosh.ViewModel
{
    class MainViewModel : BaseViewModel
    {
        public Array Currencies
        {
            get { return Enum.GetValues(typeof(Currencies));  }
        }

        public Currencies SelectedCurrency
        {
            get { return selectedCurrency; }
            set {
                selectedCurrency = value;
                OnChange("SelectedCurrency");
                StartConvertion();
            }
        }

        private void StartConvertion()
        {
            foreach( var item in Items)
            {
                item.CalculateSalesPriceFromEuro(SelectedCurrency);
                item.CalculatePurchasePriceFromEuro(SelectedCurrency);
            } 
        }
        private List<StockEntry> stock;
        
        private CodingDojo4DataLib.Converter.Currencies selectedCurrency;
        public ObservableCollection<StockEntryViewModel> items = new ObservableCollection<StockEntryViewModel>();
        public ObservableCollection<StockEntryViewModel> Items
        {
            get { return items; }
            set { items = value; }
        }     

        public MainViewModel()
        {
            SampleManager manager = new SampleManager();
            stock = manager.CurrentStock.OnStock;
            foreach (var item in manager.CurrentStock.OnStock)
            {
                Items.Add(new StockEntryViewModel(item));
            }
        }

        private void ItemsView_OnSelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var dg = sender as DataGrid;
            if (dg == null) return;
            var index = dg.SelectedIndex;
            //here we get the actual row at selected index
            DataGridRow row = dg.ItemContainerGenerator.ContainerFromIndex(index) as DataGridRow;

            //here we get the actual data item behind the selected row
            var item = dg.ItemContainerGenerator.ItemFromContainer(row);

        }
    }

}
