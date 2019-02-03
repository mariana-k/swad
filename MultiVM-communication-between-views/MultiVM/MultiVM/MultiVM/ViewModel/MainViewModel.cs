using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using GalaSoft.MvvmLight.Ioc;

namespace MultiVM.ViewModel
{
    
    public class MainViewModel : ViewModelBase
    {
        private ViewModelBase currentVm;

        public RelayCommand AddBtnClickedCmd { get; set; }
        public RelayCommand SearchBtnClickedCmd { get; set; }
        public ViewModelBase CurrentVm
        {
            get { return currentVm; }
            set { currentVm = value; RaisePropertyChanged(); }
        }

        public MainViewModel()
        {
            CurrentVm = SimpleIoc.Default.GetInstance<AddVm>();
            AddBtnClickedCmd = new RelayCommand(() =>
            {
                CurrentVm = SimpleIoc.Default.GetInstance<AddVm>();
            });
            SearchBtnClickedCmd = new RelayCommand(() =>
            {
                CurrentVm = SimpleIoc.Default.GetInstance<SearchVm>();
            });
        }
    }
}