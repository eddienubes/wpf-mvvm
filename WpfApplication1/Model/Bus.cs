using System;

namespace WpfApplication1.Model
{
    public class Bus : AbstractTransport, ITransport
    {
        public Bus(string name, string engine, string description) : base(name, engine, description)
        {
        }

        public void Drive()
        {
            Console.WriteLine($@"Bus {Id} is driving");
        }
    }
}