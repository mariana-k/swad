using CD3_Kyrkosh.Converters;
using CD3_Kyrkosh.Model;
using CodingDojo4DataLib;
using CodingDojo4DataLib.Converter;
using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;

namespace CD3_Kyrkosh.ViewModel
{
   
    public class MainViewModel : ViewModelBase
    {

        private List<object> FormatCurrencies()
        {
            List<object> currencies = new List<object>();
            foreach (var currency in Enum.GetValues(typeof(Currencies)))
            {
                currencies.Add(currency);
            }

            object tmp = currencies[0];
            currencies[0] = currencies[1];
            currencies[1] = tmp;
            return currencies;
        }
    
        public List<object> Currencies
        {
            get {

                
                return FormatCurrencies();
            }
        }
        public Currencies SelectedCurrency
        {
            get
            {
                return selectedCurrency;
            }
            set
            {
                selectedCurrency = value;
                RaisePropertyChanged("SelectedCurrency");
                this.ConvertCurrencies();
            }
        }

        private Currencies selectedCurrency;
        public ObservableCollection<StockEntryModel> items = new ObservableCollection<StockEntryModel>();
        public ObservableCollection<StockEntryModel> Items
        {
            get
            {
                return items;
            }
            set
            {
                items = value;
            }
        }
        public void ConvertCurrencies()
        {
            foreach(var item in Items)
            {
                item.ConvertSalesPrice(selectedCurrency);
                item.ConvertPurchasePrice(selectedCurrency);
            }

             
        }
        public List<StockEntry> stock;
        public RelayCommand DeleteItem { get; set; }
        public RelayCommand AddItem { get; set; }
        public MainViewModel()
        {
 
            SampleManager manager = new SampleManager();
            stock = manager.CurrentStock.OnStock;
   
            foreach (var item in stock) {
                items.Add(new StockEntryModel(item));
            }

            DeleteItem = new RelayCommand(DeleteRow);
            AddItem = new RelayCommand(AddRow);
        }

        private StockEntryModel currentSelectedItem;
        public StockEntryModel CurrentSelectedItem
        {
            get { return currentSelectedItem; }
            set
            {
                currentSelectedItem = value;

            }
        }

        private void DeleteRow()
        {
            if (CurrentSelectedItem != null)
            {
                foreach (var item in stock)
                {
                    if (item.SoftwarePackage.Name.Equals(CurrentSelectedItem.Name))
                    {
                        stock.Remove(item);
                        break;
                    }
                }
                System.Windows.MessageBox.Show("One item removed. There are " + stock.Count + " items on the stock now!");
                Items.Remove(CurrentSelectedItem);
            } else
            {
                System.Windows.MessageBox.Show("No items selected!");
            }
        }
       
        private void AddRow()
        {
            StockEntry newEntry = new StockEntry();
            newEntry.Amount = 0;
            newEntry.SoftwarePackage = new Software("New Entry");
            newEntry.SoftwarePackage.Category = new Group()
            {
                Name = "New Entry"
            };

            StockEntryModel newStockEntryModel = new StockEntryModel(newEntry);
            stock.Add(newEntry);
            Items.Add(newStockEntryModel);
            System.Windows.MessageBox.Show("One item added. There are " + stock.Count + " items on the stock now!");
        }
       
    }
}