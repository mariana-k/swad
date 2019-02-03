using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using GalaSoft.MvvmLight.Ioc;

namespace MultiVM.ViewModel
{
    
    public class MainViewModel : ViewModelBase
    {
        private ViewModelBase currentVm;

        public ViewModelBase CurrentVm
        {
            get { return currentVm; }
            set { currentVm = value; RaisePropertyChanged(); }
        }

        public RelayCommand AddBtnCommand { get; set; }
        public RelayCommand SearchBtnCommand { get; set; }


        public MainViewModel()
        {
            CurrentVm = SimpleIoc.Default.GetInstance<AddVm>();
            AddBtnCommand = new RelayCommand(() => { CurrentVm = SimpleIoc.Default.GetInstance<AddVm>(); });
            SearchBtnCommand = new RelayCommand(() => { CurrentVm = SimpleIoc.Default.GetInstance<SearchVm>(); });
        }
    }
}