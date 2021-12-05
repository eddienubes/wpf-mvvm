using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Windows.Input;
using WpfApplication1.Model;

namespace WpfApplication1.ViewModel
{
    public class BusesInputViewModel : ViewModelBase
    {
        private string _name;
        private string _engine;
        private string _description;
        private string _id;

        public string Name
        {
            get => _name;
            set
            {
                _name = value;
                OnPropertyChanged(nameof(_name));
            }
        }

        public string Engine
        {
            get => _engine;
            set
            {
                _engine = value;
                OnPropertyChanged(nameof(_engine));
            }
        }

        public string Description
        {
            get => _description;
            set
            {
                _description = value;
                OnPropertyChanged(nameof(_description));
            }
        }

        public string Id
        {
            get => _id;
            set
            {
                _id = value;
                OnPropertyChanged(nameof(_id));
            }
        }


        public ICommand AddCommand { get; }
        public ICommand RemoveCommand { get; }

        public BusesInputViewModel()
        {
            
        }
    }
}