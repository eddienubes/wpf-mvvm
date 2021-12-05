using System;

namespace WpfApplication1.ViewModel
{
    public abstract class MyObject
    {
        public abstract override string ToString();

        public virtual void Print()
        {
            Console.WriteLine(ToString());
        }
    }
}