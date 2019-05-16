using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultipleViews.Models
{
    public class PlantCollection : INotifyPropertyChanged
    {
        private List<Plant> plants;

        public List<Plant> Plants
        {
            get
            {
                return plants;
            }
            set
            {
                plants = value;
                OnPropertyChanged(nameof(Plants));
            }
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
