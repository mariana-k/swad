using GalaSoft.MvvmLight;
using System;
using System.Collections.ObjectModel;
using System.Windows.Media.Imaging;

namespace Templates.ViewModel
{

    public class MainViewModel : ViewModelBase
    {
        public ObservableCollection<LegoItemsViewModel> Items { get; set; }
        public LegoItemsViewModel CurrentItem
        {
            get => currentItem;
            set
            {
                currentItem = value;
                RaisePropertyChanged();
            }
        }

        private LegoItemsViewModel currentItem;
        public MainViewModel()
        {
            Items = new ObservableCollection<LegoItemsViewModel>();
            DemoDataGenerator();
        }

        private void DemoDataGenerator()
        {
            Items.Add(new LegoItemsViewModel("Lego 1", 300, "10+", new BitmapImage(new Uri("Images/lego1.jpg", UriKind.Relative))));
            Items.Add(new LegoItemsViewModel("Lego 2", 200, "5+", new BitmapImage(new Uri("Images/lego2.jpg", UriKind.Relative))));
        }
    }
}