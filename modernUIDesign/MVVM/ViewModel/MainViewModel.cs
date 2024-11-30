using modernUIDesign.Main;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace modernUIDesign.MVVM.ViewModel
{
    internal class MainViewModel: ObservableOjects
    {
        public HomeViewModel HomeVM { get; set; }

        private object _currentView;

        public object CurrentView
        {
            get { return _currentView; }
            set { 
                _currentView = value;
                OnPropertyChanged();
            }

        }

        public MainViewModel()
        {
            HomeVM= new HomeViewModel();
            CurrentView = HomeVM;
        }
    }
}
