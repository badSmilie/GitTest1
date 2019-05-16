using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultipleViews.Models
{
    public class Plant : INotifyPropertyChanged
    {
        private int id;
        private string genus;
        private string species;
        private string cultivar;
        private string common;

        public int Id
        {
            get
            {
                return id;
            }
            set
            {
                id = value;
                OnPropertyChanged(nameof(Id));
            }
        }
        public string Genus
        {
            get
            {
                return genus;
            }
            set
            {
                genus = value;
                OnPropertyChanged(nameof(Genus));
            }
        }
        public string Species
        {
            get
            {
                return species;
            }
            set
            {
                species = value;
                OnPropertyChanged(nameof(Species));
            }
        }

        public string Cultivar
        {
            get
            {
                return cultivar;
            }
            set
            {
                cultivar = value;
                OnPropertyChanged(nameof(Cultivar));
            }
        }
        public string Common
        {
            get
            {
                return common;
            }
            set
            {
                common = value;
                OnPropertyChanged(nameof(Common));
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
