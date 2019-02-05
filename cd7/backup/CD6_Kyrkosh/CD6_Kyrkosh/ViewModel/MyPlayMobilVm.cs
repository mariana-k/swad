using GalaSoft.MvvmLight;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media.Imaging;

namespace CD6_Kyrkosh.ViewModel
{
    public class MyPlayMobilVm : ViewModelBase
    {
      
        public ObservableCollection<ToyVm> PlayMobils
        {
            get; set;
        }
        public MyPlayMobilVm()
        {
            
            PlayMobils = new ObservableCollection<ToyVm>();
            DemoDataGenerator();
        }

        private void DemoDataGenerator()
        {
           PlayMobils.Add(new ToyVm("Play Mobil 1", 200, "10+", new BitmapImage(new Uri("../Images/playmobil1.jpg", UriKind.Relative))));
        }
    }
}
