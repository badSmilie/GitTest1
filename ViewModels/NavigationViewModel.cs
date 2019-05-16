using MultipleViews.Helper;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace MultipleViews.ViewModels
{
    class NavigationViewModel : INotifyPropertyChanged
    {
        public ICommand RedCommand { get; set; }
        public ICommand BlueCommand { get; set; }

        public ICommand OrangeCommand { get; set; }

        private object selectedViewModel;

        public object SelectedViewModel
        {
            get { return selectedViewModel; }
            set { selectedViewModel = value; OnPropertyChanged("SelectedViewModel"); }
        }


        public NavigationViewModel()
        {
            RedCommand = new BaseCommand(OpenRed);
            BlueCommand = new BaseCommand(OpenBlue);
            OrangeCommand = new BaseCommand(OpenOrange);
        }

        private void OpenRed(object obj)
        {
            SelectedViewModel = new RedViewModel();
        }
        private void OpenBlue(object obj)
        {
            SelectedViewModel = new BlueViewModel();
        }

        private void OpenOrange(object obj)
        {
            SelectedViewModel = new OrangeViewModel();
        }

        public event PropertyChangedEventHandler PropertyChanged;
        private void OnPropertyChanged(string propName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propName));
            }
        }
    }
}
