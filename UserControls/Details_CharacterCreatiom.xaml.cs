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

namespace CyberpunkRedCharacterCreator.UserControls
{
    /// <summary>
    /// Logika interakcji dla klasy Details_CharacterCreatiom.xaml
    /// </summary>
    public partial class Details_CharacterCreatiom : UserControl
    {
        MainWindow window;
        string choosenClass;
        string creationType;

        public Details_CharacterCreatiom(MainWindow window, string choosenClass, string creationType)
        {
            InitializeComponent();
            this.window = window;
            this.choosenClass = choosenClass;
            this.creationType = creationType;
        }

        private void MenuItem_Click(object sender, RoutedEventArgs e)
        {
            //string buttonName = ((MenuItem)sender).Name;
            //SetClass(buttonName[..^9]);
        }

        private void combobox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void combobox_DropDownClosed(object sender, EventArgs e)
        {

        }

        private void add_Click(object sender, RoutedEventArgs e)
        {

        }

        private void remove_Click(object sender, RoutedEventArgs e)
        {

        }

        private void DataGrid_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {

        }
    }
}
