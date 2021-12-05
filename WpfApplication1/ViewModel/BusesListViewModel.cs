using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using WpfApplication1.Model;

namespace WpfApplication1.ViewModel
{
    public class BusesListViewModel : ViewModelBase
    {
        private readonly ObservableCollection<BusViewModel> _buses;

        public IEnumerable<BusViewModel> Buses => _buses;

        public BusesListViewModel()
        {
            _buses = new ObservableCollection<BusViewModel>();
            _buses.Add(new BusViewModel(new Bus("asd", "asdasd", "asda2adasd")));
            _buses.Add(new BusViewModel(new Bus("asd", "asdasd", "asda2adasd")));
            _buses.Add(new BusViewModel(new Bus("asd", "asdasd", "asda2adasd")));
        }

        // public List<Bus> Buses { get; private set; }
        //
        // public BusViewModel()
        // {
        //     Buses = new List<Bus>
        //     {
        //         new Bus(IdGenerator.GetRandomString(5), "bus1", "engine1", "hello world"),
        //         new Bus(IdGenerator.GetRandomString(5), "bus2", "engine2", "hello world"),
        //         new Bus(IdGenerator.GetRandomString(5), "bus3", "engine3", "hello world"),
        //         new Bus(IdGenerator.GetRandomString(5), "bus4", "engine4", "hello world"),
        //         new Bus(IdGenerator.GetRandomString(5), "bus5", "engine5", "hello world"),
        //     };
        // }
    }
}