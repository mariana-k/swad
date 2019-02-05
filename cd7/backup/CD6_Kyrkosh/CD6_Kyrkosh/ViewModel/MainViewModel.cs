using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using GalaSoft.MvvmLight.Ioc;
using GalaSoft.MvvmLight.Messaging;
using System;
using System.Collections.ObjectModel;
using System.Windows.Media.Imaging;

namespace CD6_Kyrkosh.ViewModel
{

    public class MainViewModel : ViewModelBase
    {
        private ViewModelBase currentVm;
        public ViewModelBase CurrentVm { get => currentVm;
            set { currentVm = value; RaisePropertyChanged(); } }

        public ObservableCollection<ToyVm> BoughtItems { get; set; }

        public ObservableCollection<ToyVm> ToyTypes
        {
            get; set;
        }

        public ToyVm CurrentItem
        {
            get => currentItem;
            set
            {
                currentItem = value;
                if (currentItem.Description == "My Lego")
                {
                    CurrentVm = SimpleIoc.Default.GetInstance<MyLegoVm>();
                } else
                {
                    CurrentVm = SimpleIoc.Default.GetInstance<MyPlayMobilVm>();
                }
                RaisePropertyChanged();
            }
        }

        private ToyVm currentItem;
        private RelayCommand<ToyVm> buyButtonCommand;

        public RelayCommand<ToyVm> BuyButtonCommand
        {
            get
            {
                return buyButtonCommand;
            }

            set
            {

                buyButtonCommand = value; RaisePropertyChanged();
            }
        }

        public ObservableCollection<ToyVm> Toys { get; set; }

        IMessenger messenger = Messenger.Default;

        public MainViewModel()
        {
            Toys = new ObservableCollection<ToyVm>();
            messenger.Register<NotificationMessage<ToyVm>>(this, updateList);

            CurrentVm = SimpleIoc.Default.GetInstance<MyLegoVm>();
            BoughtItems = new ObservableCollection<ToyVm>();
            BuyButtonCommand = new RelayCommand<ToyVm>((p) =>
            {
                BoughtItems.Add(p);
            }, (p) => { return true; });

            BoughtItems.Add(new ToyVm("My Lego", new BitmapImage(new Uri("Images/lego1.jpg", UriKind.Relative))));

            ToyTypes = new ObservableCollection<ToyVm>();
           
            DemoDataGenerator();
        }

        private void updateList(NotificationMessage<ToyVm> obj)
        {
            Toys.Add(obj.Content);
        }

        public void BuyToys()
        {
            BoughtItems = new ObservableCollection<ToyVm>();
            BuyButtonCommand = new RelayCommand<ToyVm>((p) =>
            {
                BoughtItems.Add(p);
            }, (p) => { return true; });
        }

        private void DemoDataGenerator()
        {
            ToyTypes.Add(new ToyVm("My Lego", new BitmapImage(new Uri("/../Images/lego1.jpg", UriKind.Relative))));
            ToyTypes.Add(new ToyVm("My Play Mobil", new BitmapImage(new Uri("Images/playmobil1.jpg", UriKind.Relative))));
        } 
    }
}