using System;
using System.Linq;

namespace WpfApplication1.Model
{
    public abstract class AbstractTransport
    {
        public string Id { get; }
        public string Name { get; }
        public string Engine { get; }
        public string Description { get; }

        private string GetRandomString(int length)
        {
            var random = new Random();
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            return new string(Enumerable.Repeat(chars, length)
                .Select(s => s[random.Next(s.Length)]).ToArray());
        }
        
        protected AbstractTransport(string name, string engine, string description)
        {
            
            Id = GetRandomString(5);
            Name = name;
            Engine = engine;
            Description = description;
        }
    }
}