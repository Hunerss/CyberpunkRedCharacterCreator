using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

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
            string menuName = ((MenuItem)sender).Name;
            //inventory_menuItem
            switch (menuName.Substring(0,menuName.Length-9))
            {
                case "lifepath":
                    lifepath_container.Visibility = Visibility.Visible;
                    stats_container.Visibility = Visibility.Collapsed;
                    skills_container.Visibility = Visibility.Collapsed;
                    inventory_container.Visibility = Visibility.Collapsed;
                    fashion_container.Visibility = Visibility.Collapsed;
                    ability_container.Visibility = Visibility.Collapsed;

                    lifepath_general.Visibility = Visibility.Visible;
                    switch (choosenClass)
                    {
                        case "exec":
                            lifepath_exec.Visibility = Visibility.Visible;
                            lifepath_fixer.Visibility = Visibility.Collapsed;
                            lifepath_lawman.Visibility = Visibility.Collapsed;
                            lifepath_media.Visibility = Visibility.Collapsed;
                            lifepath_medtech.Visibility = Visibility.Collapsed;
                            lifepath_netrunner.Visibility = Visibility.Collapsed;
                            lifepath_nomad.Visibility = Visibility.Collapsed;
                            lifepath_rockerboy.Visibility = Visibility.Collapsed;
                            lifepath_solo.Visibility = Visibility.Collapsed;
                            lifepath_tech.Visibility = Visibility.Collapsed;
                            break;
                        case "fixer":
                            lifepath_exec.Visibility = Visibility.Collapsed;
                            lifepath_fixer.Visibility = Visibility.Visible;
                            lifepath_lawman.Visibility = Visibility.Collapsed;
                            lifepath_media.Visibility = Visibility.Collapsed;
                            lifepath_medtech.Visibility = Visibility.Collapsed;
                            lifepath_netrunner.Visibility = Visibility.Collapsed;
                            lifepath_nomad.Visibility = Visibility.Collapsed;
                            lifepath_rockerboy.Visibility = Visibility.Collapsed;
                            lifepath_solo.Visibility = Visibility.Collapsed;
                            lifepath_tech.Visibility = Visibility.Collapsed;
                            break;
                        case "lawman":
                            lifepath_exec.Visibility = Visibility.Collapsed;
                            lifepath_fixer.Visibility = Visibility.Collapsed;
                            lifepath_lawman.Visibility = Visibility.Visible;
                            lifepath_media.Visibility = Visibility.Collapsed;
                            lifepath_medtech.Visibility = Visibility.Collapsed;
                            lifepath_netrunner.Visibility = Visibility.Collapsed;
                            lifepath_nomad.Visibility = Visibility.Collapsed;
                            lifepath_rockerboy.Visibility = Visibility.Collapsed;
                            lifepath_solo.Visibility = Visibility.Collapsed;
                            lifepath_tech.Visibility = Visibility.Collapsed;
                            break;
                        case "media":
                            lifepath_exec.Visibility = Visibility.Collapsed;
                            lifepath_fixer.Visibility = Visibility.Collapsed;
                            lifepath_lawman.Visibility = Visibility.Collapsed;
                            lifepath_media.Visibility = Visibility.Visible;
                            lifepath_medtech.Visibility = Visibility.Collapsed;
                            lifepath_netrunner.Visibility = Visibility.Collapsed;
                            lifepath_nomad.Visibility = Visibility.Collapsed;
                            lifepath_rockerboy.Visibility = Visibility.Collapsed;
                            lifepath_solo.Visibility = Visibility.Collapsed;
                            lifepath_tech.Visibility = Visibility.Collapsed;
                            break;
                        case "medtech":
                            lifepath_exec.Visibility = Visibility.Collapsed;
                            lifepath_fixer.Visibility = Visibility.Collapsed;
                            lifepath_lawman.Visibility = Visibility.Collapsed;
                            lifepath_media.Visibility = Visibility.Collapsed;
                            lifepath_medtech.Visibility = Visibility.Visible;
                            lifepath_netrunner.Visibility = Visibility.Collapsed;
                            lifepath_nomad.Visibility = Visibility.Collapsed;
                            lifepath_rockerboy.Visibility = Visibility.Collapsed;
                            lifepath_solo.Visibility = Visibility.Collapsed;
                            lifepath_tech.Visibility = Visibility.Collapsed;
                            break;
                        case "netrunner":
                            lifepath_exec.Visibility = Visibility.Collapsed;
                            lifepath_fixer.Visibility = Visibility.Collapsed;
                            lifepath_lawman.Visibility = Visibility.Collapsed;
                            lifepath_media.Visibility = Visibility.Collapsed;
                            lifepath_medtech.Visibility = Visibility.Collapsed;
                            lifepath_netrunner.Visibility = Visibility.Visible;
                            lifepath_nomad.Visibility = Visibility.Collapsed;
                            lifepath_rockerboy.Visibility = Visibility.Collapsed;
                            lifepath_solo.Visibility = Visibility.Collapsed;
                            lifepath_tech.Visibility = Visibility.Collapsed;
                            break;
                        case "nomad":
                            lifepath_exec.Visibility = Visibility.Collapsed;
                            lifepath_fixer.Visibility = Visibility.Collapsed;
                            lifepath_lawman.Visibility = Visibility.Collapsed;
                            lifepath_media.Visibility = Visibility.Collapsed;
                            lifepath_medtech.Visibility = Visibility.Collapsed;
                            lifepath_netrunner.Visibility = Visibility.Collapsed;
                            lifepath_nomad.Visibility = Visibility.Visible;
                            lifepath_rockerboy.Visibility = Visibility.Collapsed;
                            lifepath_solo.Visibility = Visibility.Collapsed;
                            lifepath_tech.Visibility = Visibility.Collapsed;
                            break;
                        case "rokcerboy":
                            lifepath_exec.Visibility = Visibility.Collapsed;
                            lifepath_fixer.Visibility = Visibility.Collapsed;
                            lifepath_lawman.Visibility = Visibility.Collapsed;
                            lifepath_media.Visibility = Visibility.Collapsed;
                            lifepath_medtech.Visibility = Visibility.Collapsed;
                            lifepath_netrunner.Visibility = Visibility.Collapsed;
                            lifepath_nomad.Visibility = Visibility.Collapsed;
                            lifepath_rockerboy.Visibility = Visibility.Visible;
                            lifepath_solo.Visibility = Visibility.Collapsed;
                            lifepath_tech.Visibility = Visibility.Collapsed;
                            break;
                        case "solo":
                            lifepath_exec.Visibility = Visibility.Collapsed;
                            lifepath_fixer.Visibility = Visibility.Collapsed;
                            lifepath_lawman.Visibility = Visibility.Collapsed;
                            lifepath_media.Visibility = Visibility.Collapsed;
                            lifepath_medtech.Visibility = Visibility.Collapsed;
                            lifepath_netrunner.Visibility = Visibility.Collapsed;
                            lifepath_nomad.Visibility = Visibility.Collapsed;
                            lifepath_rockerboy.Visibility = Visibility.Collapsed;
                            lifepath_solo.Visibility = Visibility.Visible;
                            lifepath_tech.Visibility = Visibility.Collapsed;
                            break;
                        case "tech":
                            lifepath_exec.Visibility = Visibility.Collapsed;
                            lifepath_fixer.Visibility = Visibility.Collapsed;
                            lifepath_lawman.Visibility = Visibility.Collapsed;
                            lifepath_media.Visibility = Visibility.Collapsed;
                            lifepath_medtech.Visibility = Visibility.Collapsed;
                            lifepath_netrunner.Visibility = Visibility.Collapsed;
                            lifepath_nomad.Visibility = Visibility.Collapsed;
                            lifepath_rockerboy.Visibility = Visibility.Collapsed;
                            lifepath_solo.Visibility = Visibility.Collapsed;
                            lifepath_tech.Visibility = Visibility.Visible;
                            break;
                        default:
                            Console.WriteLine("Error");
                            break;
                    }
                    break;
                case "stats":
                    lifepath_container.Visibility = Visibility.Collapsed;
                    stats_container.Visibility = Visibility.Visible;
                    skills_container.Visibility = Visibility.Collapsed;
                    inventory_container.Visibility = Visibility.Collapsed;
                    fashion_container.Visibility = Visibility.Collapsed;
                    ability_container.Visibility = Visibility.Collapsed;
                    break;
                case "skills":
                    lifepath_container.Visibility = Visibility.Collapsed;
                    stats_container.Visibility = Visibility.Collapsed;
                    skills_container.Visibility = Visibility.Visible;
                    inventory_container.Visibility = Visibility.Collapsed;
                    fashion_container.Visibility = Visibility.Collapsed;
                    ability_container.Visibility = Visibility.Collapsed;
                    break;
                case "inventory":
                    lifepath_container.Visibility = Visibility.Collapsed;
                    stats_container.Visibility = Visibility.Collapsed;
                    skills_container.Visibility = Visibility.Collapsed;
                    inventory_container.Visibility = Visibility.Visible;
                    fashion_container.Visibility = Visibility.Collapsed;
                    ability_container.Visibility = Visibility.Collapsed;
                    break;
                case "fashion":
                    lifepath_container.Visibility = Visibility.Collapsed;
                    stats_container.Visibility = Visibility.Collapsed;
                    skills_container.Visibility = Visibility.Collapsed;
                    inventory_container.Visibility = Visibility.Collapsed;
                    fashion_container.Visibility = Visibility.Visible;
                    ability_container.Visibility = Visibility.Collapsed;
                    break;
                case "ability":
                    lifepath_container.Visibility = Visibility.Collapsed;
                    stats_container.Visibility = Visibility.Collapsed;
                    skills_container.Visibility = Visibility.Collapsed;
                    inventory_container.Visibility = Visibility.Collapsed;
                    fashion_container.Visibility = Visibility.Collapsed;
                    ability_container.Visibility = Visibility.Visible;
                    break;
                default:
                    Console.WriteLine("Error");
                    break;
            }
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
