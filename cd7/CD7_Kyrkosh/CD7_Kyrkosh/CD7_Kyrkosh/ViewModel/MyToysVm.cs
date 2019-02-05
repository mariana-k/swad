using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Messaging;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace CD7_Kyrkosh.ViewModel
{
    public class MyToysVm : ViewModelBase
    {

        public ObservableCollection<ToyVm> Toys { get; set; }

        IMessenger messenger = Messenger.Default;
        public MyToysVm()
        {

            Toys = new ObservableCollection<ToyVm>();
            messenger.Register<NotificationMessage<ToyVm>>(this, updateList);
        }

        private void updateList(NotificationMessage<ToyVm> obj)
        {

            Toys.Add(obj.Content);
           
            
        }
    }
}
