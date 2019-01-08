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
            set
            {
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

        public RelayCommand DeleteItem { get; set; }
        public RelayCommand AddItem { get; set; }
        public RelayCommand EditItem { get; set; }

        private StockEntryViewModel currentSelectedItem;
        public StockEntryViewModel CurrentSelectedItem
        {
            get { return currentSelectedItem; }
            set
            {
                currentSelectedItem = value;

            }
        }

        public bool ReadOnly { get; private set; }

        public MainViewModel()
        {
            ReadOnly = true;
            SampleManager manager = new SampleManager();
            stock = manager.CurrentStock.OnStock;
            foreach (var item in manager.CurrentStock.OnStock)
            {
                Items.Add(new StockEntryViewModel(item));
            }
           
            DeleteItem = new RelayCommand(DelteRow);
            AddItem = new RelayCommand(AddRow);
            EditItem = new RelayCommand(DelteRow);
        }

        private void DelteRow(object obj)
        {
            Items.Remove(CurrentSelectedItem); //delete from view

        }

        private void AddRow(object obj)
        {
            StockEntry entry = new StockEntry();
            Group group = new Group();
            group.Name = "Edit";
            Software software = new Software("Edit entry");
            software.Name = "Now edit entry";
            software.PurchasePrice = 123;
            software.SalesPrice = 234;
            software.Category = group;
            entry.SoftwarePackage = software;

            entry.Amount = 0;

            // Items.Add(CurrentSelectedItem); //delete from view
            Items.Add(new StockEntryViewModel(entry));

        }
       
        private void EditRow(object sender, RoutedEventArgs e)
        {
            try
            {
               
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }
        }
        

    }

}
