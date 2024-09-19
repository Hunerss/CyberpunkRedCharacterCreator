using System.Windows;
using System.Windows.Controls;
using System.Windows.Media.Imaging;

namespace CyberpunkRedCharacterCreator.UserControls
{
    /// <summary>
    /// Logika interakcji dla klasy ClassSelection_CharacterCreation.xaml
    /// </summary>
    public partial class ClassSelection_CharacterCreation : UserControl
    {
        private MainWindow window;
        private Random rnd = new();

        private string creationType;
        private string selectedClass;
        public ClassSelection_CharacterCreation(MainWindow window, string creationType)
        {
            InitializeComponent();
            this.window = window;
            this.creationType = creationType;
            SetClass(rnd.Next(0, 10));
        }

        private void SetClass(int selected)
        {
            selectedClass = ReturnClassName(selected);
            class_image.Source = new BitmapImage(new Uri(@"..\Images\image_" + selectedClass + ".png", UriKind.Relative));
            //class_image.Source = new BitmapImage(new Uri(@"..\Images\placeholder.png", UriKind.Relative));
            class_image.Visibility = Visibility.Visible;
            string description_key = "class_description_" + selectedClass;
            class_description.Text = Application.Current.Resources[description_key] as string;
            description_container.Visibility = Visibility.Collapsed;
            Console.WriteLine(selectedClass);
        }
        private void SetClass(string className)
        {
            selectedClass = className;
            class_image.Source = new BitmapImage(new Uri(@"..\Images\image_" + selectedClass + ".png", UriKind.Relative));
            //class_image.Source = new BitmapImage(new Uri(@"..\Images\placeholder.png", UriKind.Relative));
            class_image.Visibility = Visibility.Visible;
            string description_key = "class_description_" + selectedClass;
            class_description.Text = Application.Current.Resources[description_key] as string;
            description_container.Visibility = Visibility.Collapsed;
            select.Visibility = Visibility.Visible;
            Console.WriteLine(selectedClass);
        }

        private static string ReturnClassName(int classId)
        {
            return classId switch
            {
                0 => "exec",
                1 => "fixer",
                2 => "lawman",
                3 => "media",
                4 => "medtech",
                5 => "netrunner",
                6 => "nomad",
                7 => "rockerboy",
                8 => "solo",
                9 => "tech",
                _ => "error",
            };
        }

        private void MenuItem_Click(object sender, RoutedEventArgs e)
        {
            string buttonName = ((MenuItem)sender).Name;
            SetClass(buttonName[..^9]);
        }

        private void Select_Click(object sender, RoutedEventArgs e)
        {
            select.Visibility = Visibility.Collapsed;
            class_image.Visibility = Visibility.Collapsed;
            description_container.Visibility = Visibility.Visible;
        }

        private void Option_Click(object sender, RoutedEventArgs e)
        {
            string buttonName = ((Button)sender).Name;
            switch (buttonName)
            {
                case "cancel":
                    select.Visibility = Visibility.Visible;
                    class_image.Visibility = Visibility.Visible;
                    description_container.Visibility = Visibility.Collapsed;
                    break;
                case "confirm":
                    window.frame.NavigationService.Navigate(new Details_CharacterCreatiom(window, selectedClass, creationType));
                    break;
                default:
                    Console.WriteLine("Error");
                    break;
            }
        }
    }
}
