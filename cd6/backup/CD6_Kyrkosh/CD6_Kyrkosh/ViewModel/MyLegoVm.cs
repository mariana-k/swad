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

namespace CD6_Kyrkosh.ViewModel
{
    public class MyLegoVm : ViewModelBase
    {
        public ObservableCollection<ToyVm> Legos
        {
            get; set;
        }
        private string _description;
        public string Description
        {
            get => _description;
            set { _description = value; RaisePropertyChanged(); }
        }
        private BitmapImage _image;
        public BitmapImage Image
        {
            get => _image;
            set { _image = value; }
        }
        IMessenger messenger = Messenger.Default;
        public RelayCommand BuyToyClickedCmd {
            get;

            set; }
        public ToyVm Toy { get; set; }
        public MyLegoVm()
        {
            Legos = new ObservableCollection<ToyVm>();
       
            DemoDataGenerator();

            Toy = new ToyVm("Lego 1", 300, "5+", new BitmapImage(new Uri("./../Images/lego1.jpg", UriKind.Relative)));
         
            BuyToyClickedCmd = new RelayCommand(() => {
                messenger.Send(new NotificationMessage<ToyVm>(new ToyVm(Toy), ""));
            });
        }
        private void CommandWithAParameter(object state)
        {
            var str = state as string;
        }
        public void AddToy(ToyVm toy)
        {
            messenger.Send(new NotificationMessage<ToyVm>(toy, ""));
        }

        private void DemoDataGenerator()
        {
            Legos.Add(new ToyVm("Lego 1", 300, "5+", new BitmapImage(new Uri("../Images/lego1.jpg", UriKind.Relative))));
            Legos.Add(new ToyVm("Lego 2", 200, "7+", new BitmapImage(new Uri("../Images/lego2.jpg", UriKind.Relative))));
            Legos.Add(new ToyVm("Lego 3", 100, "6+", new BitmapImage(new Uri("../Images/lego3.jpg", UriKind.Relative))));            
        }
    }
}