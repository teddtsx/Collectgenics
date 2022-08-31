using Collectgenics.Desktop.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collectgenics.Desktop.MVVM.ViewModel
{
    internal class MainViewModel : ObservableObject
    {

        public RelayCommand HomeViewCommand { get; set; }
        public RelayCommand AboutViewCommand { get; set; }

        public HomeViewModel HomeVM { get; set; }
        public AboutViewModel AboutVM { get; set; }

        private Object _currentView;

        public Object CurrentView
        {
            get { return _currentView; }
            set { 
                _currentView = value;
                OnPropertyChaneged();
            }
        }

        public MainViewModel()
        {
            HomeVM=new HomeViewModel(); 
            AboutVM=new AboutViewModel(); 
            CurrentView=HomeVM;

            HomeViewCommand = new RelayCommand(o =>
            {
                CurrentView = HomeVM;
            });
            
            AboutViewCommand = new RelayCommand(o =>
            {
                CurrentView = AboutVM;
            });
        }

    }
}
