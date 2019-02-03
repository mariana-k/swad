using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using GalaSoft.MvvmLight.Messaging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiVM.ViewModel
{
    public class AddVm : ViewModelBase
    {

        public DeviceVm Device { get; set; }

        public List<string> Manufacturers { get; set; }
        public List<string> Types { get; set; }
        public RelayCommand SaveBtnClickedCmd { get;
            set; }

        IMessenger messenger = Messenger.Default;
        public AddVm()
        {
            Types = new List<string>() { "driller", "milling machine", "saw" };
            Manufacturers = new List<string>() { "Bosch", "Hilti", "Makita" };
            Device = new DeviceVm();
            SaveBtnClickedCmd = new RelayCommand(() => {
                messenger.Send(new NotificationMessage<DeviceVm>(new DeviceVm(Device), ""));
            });
        }
    }
}
