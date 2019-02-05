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
        
        
        public ObservableCollection<ToyVm> Toys { get; set; }

        private string _description;
        public string Description
        {
            get => _description;
            set { _description = value; RaisePropertyChanged(); }
        }

        private int _numberOfParts;
        public int NumberOfParts
        {
            get => _numberOfParts;
            set { _numberOfParts = value; RaisePropertyChanged(); }
        }

        private string _ageRecommendation;
        public string AgeRecommendation { get => _ageRecommendation;
            set { _ageRecommendation = value; } }

        private BitmapImage _image;
        public BitmapImage Image { get => _image;
            set { _image = value; } }

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
        public ToyVm()
        {
           
        }

        public ToyVm(ToyVm toy)
        {
            Description = _description;
            NumberOfParts = _numberOfParts;
            AgeRecommendation = _ageRecommendation;
            Image = _image;
        }
       public void AddToy(ToyVm toy)
        {
            if (Toys == null)
                Toys = new ObservableCollection<ToyVm>();

            Toys.Add(toy);
        }
    }
}
