using WpfApplication1.Model;

namespace WpfApplication1.ViewModel
{
    public class BusViewModel : ViewModelBase
    {
        private readonly Bus _bus;

        public string Id => _bus.Id;
        public string Name => _bus.Name;
        public string Engine => _bus.Engine;
        public string Description => _bus.Description;


        public BusViewModel(Bus bus)
        {
            _bus = bus;
        }
    }
}