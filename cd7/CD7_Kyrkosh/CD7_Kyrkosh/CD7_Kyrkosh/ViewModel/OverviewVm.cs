using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using GalaSoft.MvvmLight.Messaging;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media.Imaging;

namespace CD7_Kyrkosh.ViewModel
{
   public class OverviewVm : ViewModelBase
    {
        private ViewModelBase currentVm;
        public ViewModelBase CurrentVm
        {
            get => currentVm;
            set { currentVm = value; RaisePropertyChanged(); }
        }

        public ObservableCollection<ToyVm> BoughtItems
        {
            get;
            set;
        }

        public ObservableCollection<ToyVm> ToyTypes
        {
            get; set;
        }

        private ToyVm currentItem;
        public ToyVm CurrentItem
        {
            get => currentItem;
            set
            {
                currentItem = value;
                RaisePropertyChanged();
            }
        }


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
        public ObservableCollection<ToyVm> Legos
        {
            get; set;
        }


        

        public ToyVm Toy { get; set; }

        
        public RelayCommand SaveBtnClickedCmd
        {
            get;
            set;
        }

        IMessenger messenger = Messenger.Default;


        public OverviewVm()
        {
           
            Toy = new ToyVm();
            SaveBtnClickedCmd = new RelayCommand(() => {
                messenger.Send(new NotificationMessage<ToyVm>(new ToyVm(Toy), ""));
            });

            BoughtItems = new ObservableCollection<ToyVm>();
            BuyButtonCommand = new RelayCommand<ToyVm>((parentToy) =>
            {
                messenger.Send(new NotificationMessage<ToyVm>(parentToy, ""));
                BoughtItems.Add(parentToy);
            }, (parentToy) => { return true; });

            ToyTypes = new ObservableCollection<ToyVm>();

            CreateDemoToysList();
        }


        private void CreateDemoToysList()
        {
            ToyTypes.Add(new ToyVm("My Lego", new BitmapImage(new Uri("../Images/lego1.jpg", UriKind.Relative))));
            ToyTypes.Add(new ToyVm("My Play Mobil", new BitmapImage(new Uri("../Images/playmobil1.jpg", UriKind.Relative))));
            ToyTypes[ToyTypes.Count - 2].AddToy(
               new ToyVm("Lego Toy 1", 300, "5+", new BitmapImage(new Uri("../Images/lego1.jpg", UriKind.Relative))));
            ToyTypes[ToyTypes.Count - 2].AddToy(
               new ToyVm("Lego Toy 2", 100, "10+", new BitmapImage(new Uri("../Images/lego2.jpg", UriKind.Relative))));
            ToyTypes[ToyTypes.Count - 2].AddToy(
               new ToyVm("Lego Toy 3", 200, "10+", new BitmapImage(new Uri("../Images/lego3.jpg", UriKind.Relative))));
            ToyTypes[ToyTypes.Count - 2].AddToy(
               new ToyVm("Lego Toy 4", 300, "5+", new BitmapImage(new Uri("../Images/lego4.jpg", UriKind.Relative))));
            ToyTypes[ToyTypes.Count - 1].AddToy(
                new ToyVm("My Play Mobil", 200, "10+", new BitmapImage(new Uri("../Images/playmobil1.jpg", UriKind.Relative))));
            ToyTypes[ToyTypes.Count - 1].AddToy(
                new ToyVm("My Play Mobil", 300, "5+", new BitmapImage(new Uri("../Images/playmobil2.jpg", UriKind.Relative))));
            ToyTypes[ToyTypes.Count - 1].AddToy(
                new ToyVm("My Play Mobil", 100, "10+", new BitmapImage(new Uri("../Images/playmobil3.jpg", UriKind.Relative))));
            ToyTypes[ToyTypes.Count - 1].AddToy(
                new ToyVm("My Play Mobil", 200, "10+", new BitmapImage(new Uri("../Images/playmobil4.jpg", UriKind.Relative))));
        }
    }
}
