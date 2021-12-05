using System.Windows.Controls;
using WpfApplication1.Model;
using WpfApplication1.ViewModel;
using System.Collections.Generic;

namespace WpfApplication1.View
{
    public partial class BusesList : UserControl
    {
        public readonly List<Bus> Buses;

        public BusesList()
        {
            InitializeComponent();

            // var busViewModel = new BusInputViewModel();
            //
            // Buses = busViewModel.Buses;
            // BusList.ItemsSource = Buses;
        }
    }
}