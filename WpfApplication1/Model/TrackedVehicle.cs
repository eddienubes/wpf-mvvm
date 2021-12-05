using System;
using WpfApplication1.ViewModel;

namespace WpfApplication1.Model
{
    
    public class TrackedVehicle : AbstractTransport, ITransport
    {
        public TrackedVehicle(string name, string engine, string description) : base(name, engine, description)
        {
        }
    
        public void Drive()
        {
            Console.WriteLine($@"TrackedVehicle {Id} is driving");
        }
    }
}