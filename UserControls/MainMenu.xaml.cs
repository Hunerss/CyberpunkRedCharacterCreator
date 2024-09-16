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
    /// Logika interakcji dla klasy MainMenu.xaml
    /// </summary>
    public partial class MainMenu : UserControl
    {
        private MainWindow window;
        public MainMenu(MainWindow window)
        {
            InitializeComponent();
            this.window = window;
        }

        private void Navigate_Click(object sender, RoutedEventArgs e)
        {
            string btn_name = ((Button)sender).Name;
            if (btn_name == "character_creation_description_calculated")
            {
                window.frame.NavigationService.Navigate(new );
            } else if (btn_name == "character_creation_description_calculated")
            {

            } else if (btn_name == "calculated_button")
            {

            } else {
                Console.WriteLine("Error button overflow");
            }
        }
    }
}
