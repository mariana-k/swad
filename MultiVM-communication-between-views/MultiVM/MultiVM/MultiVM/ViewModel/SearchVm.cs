using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Ioc;
using GalaSoft.MvvmLight.Messaging;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace MultiVM.ViewModel
{
    public class SearchVm : ViewModelBase
    {
        public ObservableCollection<DeviceVm> Devices { get; set; }

        IMessenger messenger = Messenger.Default;
        public SearchVm()
        {

            Devices = new ObservableCollection<DeviceVm>();
            messenger.Register<NotificationMessage<DeviceVm>>(this, updateList);
        }

        private void updateList(NotificationMessage<DeviceVm> obj)
        {
            MessageBox.Show("Hello MessageBox " + obj.Content);
            Devices.Add(obj.Content);
        }
    }
}
