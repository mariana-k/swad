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
    public class ToyVm : ViewModelBase
    {
        private string _description;
        private int _numberOfParts;
        public ObservableCollection<ToyVm> Toys { get; set; }

        public string Description
        {
            get => _description;
            set { _description = value; RaisePropertyChanged(); }
        }
        public int NumberOfParts
        {
            get => _numberOfParts;
            set { _numberOfParts = value; RaisePropertyChanged(); }
        }
        public string AgeRecommendation { get; set; }
        public BitmapImage Image { get; set; }

        public ToyVm(string description, int numberOfParts, string ageRecommendation, BitmapImage image)
        {
            Description = description;
            NumberOfParts = numberOfParts;
            AgeRecommendation = ageRecommendation;
            Image = image;
        }
        public ToyVm(string description, BitmapImage image)
        {
            Description = description;
            Image = image;
        }
       public void AddToy(ToyVm toy)
        {
            if (Toys == null)
                Toys = new ObservableCollection<ToyVm>();

            Toys.Add(toy);
        }
    }
}
