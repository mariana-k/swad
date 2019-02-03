using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;
using CD3_Kyrkosh.ViewModel;
using CodingDojo4DataLib;
using CodingDojo4DataLib.Converter;
using GalaSoft.MvvmLight;

namespace CD3_Kyrkosh.Model
{
    public class StockEntryModel : ViewModelBase
    {
        private StockEntry stockEntry;
        private double purchasePriceInEuro;
        private double salesPriceInEuro;
        public String Name
        {
            get
            {
                return stockEntry.SoftwarePackage.Name;
            }
            set
            {
                stockEntry.SoftwarePackage.Name = value;
            }
        }
        public String Group
        {
            get
            {
                return stockEntry.SoftwarePackage.Category.Name;
            }
            set
            {
                stockEntry.SoftwarePackage.Category.Name = value;
            }
        }
        public double SalesPrice
        {
            get
            {
                return stockEntry.SoftwarePackage.SalesPrice;
            }
            set
            {
                stockEntry.SoftwarePackage.SalesPrice = value;
                RaisePropertyChanged("SalesPrice");
            }
        }
        public double PurchasePrice
        {
            get
            {
                return stockEntry.SoftwarePackage.PurchasePrice;
            }
            set
            {
                stockEntry.SoftwarePackage.PurchasePrice = value;
                RaisePropertyChanged("PurchasePrice");
            }
        }
        public int Amount
        {
            get
            {
                return stockEntry.Amount;
            }
            set
            {
                stockEntry.Amount = value;
            }
        }
        public StockEntryModel(StockEntry item)
        {
            stockEntry = item;
            salesPriceInEuro = item.SoftwarePackage.SalesPrice;
            purchasePriceInEuro = item.SoftwarePackage.PurchasePrice;
        }

        public void ConvertSalesPrice(Currencies currency)
        {
            this.SalesPrice = CurrencyConverter.ConvertFromEuroTo(currency, salesPriceInEuro);
        }

        public void ConvertPurchasePrice(Currencies currency)
        {
            this.PurchasePrice = CurrencyConverter.ConvertFromEuroTo(currency, purchasePriceInEuro);
        }
       
    }
}
