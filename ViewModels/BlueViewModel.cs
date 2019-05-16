using MultipleViews.Helper;
using MultipleViews.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;

namespace MultipleViews.ViewModels
{
    class BlueViewModel
    {
        public ICommand DateCommand { get; set; }
        GenericList<DateTime> genericList;
        Person person;
        public Person Person { get => person; set => person = value; }

        public BlueViewModel()
        {
            DateCommand = new BaseCommand(ShowDate);
            genericList = new GenericList<DateTime>();
            Person = new Person();
        }

        private void ShowDate(object par)
        {
            DateTime dateTime = DateTime.Now;
            MessageBox.Show(dateTime.ToString("mm.dd.yyyy hh:ss"));
            genericList.AddEntry(dateTime);
        }
    }
}
