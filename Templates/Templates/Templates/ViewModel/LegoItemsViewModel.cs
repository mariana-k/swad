using GalaSoft.MvvmLight;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media.Imaging;

namespace Templates.ViewModel
{
    public class LegoItemsViewModel : ViewModelBase
    {
        private string _description;
        private int _numberOfParts;

        public string Description
        {
            get => _description;
            set { _description = value; RaisePropertyChanged(); }
        }
        public int NumberOfParts {
            get => _numberOfParts;
            set { _numberOfParts = value; RaisePropertyChanged(); }
        }
        public string AgeRecommendation { get; set; }
        public BitmapImage Image { get; set; }

        public LegoItemsViewModel(string description, int numberOfParts, string ageRecommendation, BitmapImage image)
        {
            Description = description;
            NumberOfParts = numberOfParts;
            AgeRecommendation = ageRecommendation;
            Image = image;
        }
    }
}
