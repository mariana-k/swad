using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using GalaSoft.MvvmLight.Ioc;
using GalaSoft.MvvmLight.Messaging;
using System;
using System.Collections.ObjectModel;
using System.Windows;
using System.Windows.Media.Imaging;

namespace CD7_Kyrkosh.ViewModel
{

    public class MainViewModel : ViewModelBase
    {
        private ViewModelBase currentVm;

        public RelayCommand OverviewBtnClickedCmd { get; set; }
        public RelayCommand MyToysBtnClickedCmd { get; set; }
        public ViewModelBase CurrentVm
        {
            get { return currentVm; }
            set { currentVm = value; RaisePropertyChanged(); }
        }
        private Message message;
        public Message Message
        {
            get => message;
            set { message = value; RaisePropertyChanged(); }
        }

        String mymessage = "Your cart is empty. Add products to the cart!";
        public string MyMessage
        {
            get
            {
                return mymessage;
            }

            set
            {
                mymessage = value; RaisePropertyChanged();
            }
        }

        BitmapImage myimage;
        public BitmapImage MyImage
        { 
            get
            {
                return myimage;
            }

            set
            {
                 myimage = value; RaisePropertyChanged();
            }
        }

        public void ShowInfo(Message msg)
        {
            MyMessage = msg.Text;
            MyImage = msg.Image;
        }
            IMessenger messenger = Messenger.Default;

        public MainViewModel()
        {

            Message = new Message();
            CurrentVm = SimpleIoc.Default.GetInstance<OverviewVm>();
            OverviewBtnClickedCmd = new RelayCommand(() =>
            {
                CurrentVm = SimpleIoc.Default.GetInstance<OverviewVm>();
            });
            MyToysBtnClickedCmd = new RelayCommand(() =>
            {
                CurrentVm = SimpleIoc.Default.GetInstance<MyToysVm>();
            });
           
             messenger.Register<NotificationMessage<ToyVm>>(this, updateList);
      
           
        }
        private void updateList(NotificationMessage<ToyVm> obj)
        {

            Message.Text = "Your toy has been adde to cart!";
            Message.Image = new BitmapImage(new Uri("../Images/State_Ok.png", UriKind.Relative));

            ShowInfo(Message);

        }
    }
}