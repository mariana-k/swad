using GalaSoft.MvvmLight;

namespace MultiVM.ViewModel
{
    public class DeviceVm : ViewModelBase
    {

        public string Manufacturer { get; set; }
        public string Typ { get; set; }
        public string Description { get; set; }
        public string ArticelNo { get; set; }
        public decimal Price { get; set; }

        public DeviceVm(string manufacturer, string typ, string description, string articelNo, decimal price)
        {
            Manufacturer = manufacturer;
            Typ = typ;
            Description = description;
            ArticelNo = articelNo;
            Price = price;
        }
        public DeviceVm()
        {

        }

        public DeviceVm(DeviceVm device)
        {
            //make a copy
            ArticelNo = device.ArticelNo;
            Description = device.Description;
            Manufacturer = device.Manufacturer;
            Price = device.Price;
            Typ = device.Typ;

        }
    }
}