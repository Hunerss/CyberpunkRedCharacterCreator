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
    /// Logika interakcji dla klasy ClassSelection_CharacterCreation.xaml
    /// </summary>
    public partial class ClassSelection_CharacterCreation : UserControl
    {
        MainWindow window;
        string creationType;
        public ClassSelection_CharacterCreation(MainWindow window, string creationType)
        {
            InitializeComponent();
            this.window = window;
            this.creationType = creationType;
        }

        private void menuItem_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
