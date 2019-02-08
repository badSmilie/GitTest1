using MultipleViews.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace MultipleViews.Views
{
    /// <summary>
    /// Interaktionslogik für BlueView.xaml
    /// </summary>
    public partial class BlueView : UserControl
    {
        public BlueView()
        {
            InitializeComponent();
        }

        private void StackPanel_Click(object sender, RoutedEventArgs e)
        {
            tbFName.Text = "Vorname send"; // bubbled
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            tbName.Text = "Name send";
        }
    }
}
