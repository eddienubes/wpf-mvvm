namespace WpfApplication1.Model
{
    public class Bulldozer : AbstractTransport
    {
        public string Manufacturer { get; }

        public Bulldozer(string name, string engine, string description, string manufacturer) : base(name, engine, description)
        {
            Manufacturer = manufacturer;
        }
    }
}