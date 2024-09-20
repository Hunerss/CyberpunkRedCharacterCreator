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
        Random rnd = new();
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
            lifepath_container.Visibility = Visibility.Collapsed;
            stats_container.Visibility = Visibility.Collapsed;
            skills_container.Visibility = Visibility.Collapsed;
            inventory_container.Visibility = Visibility.Collapsed;
            fashion_container.Visibility = Visibility.Collapsed;
            ability_container.Visibility = Visibility.Collapsed;

            switch (menuName.Substring(0, menuName.Length - 9))
            {
                case "lifepath":
                    lifepath_container.Visibility = Visibility.Visible;
                    lifepath_general.Visibility = Visibility.Visible;

                    lifepath_exec.Visibility = Visibility.Collapsed;
                    lifepath_fixer.Visibility = Visibility.Collapsed;
                    lifepath_lawman.Visibility = Visibility.Collapsed;
                    lifepath_media.Visibility = Visibility.Collapsed;
                    lifepath_medtech.Visibility = Visibility.Collapsed;
                    lifepath_netrunner.Visibility = Visibility.Collapsed;
                    lifepath_nomad.Visibility = Visibility.Collapsed;
                    lifepath_rockerboy.Visibility = Visibility.Collapsed;
                    lifepath_solo.Visibility = Visibility.Collapsed;
                    lifepath_tech.Visibility = Visibility.Collapsed;

                    switch (choosenClass)
                    {
                        case "exec":
                            lifepath_exec.Visibility = Visibility.Visible;
                            break;
                        case "fixer":
                            lifepath_fixer.Visibility = Visibility.Visible;
                            break;
                        case "lawman":
                            lifepath_lawman.Visibility = Visibility.Visible;
                            break;
                        case "media":
                            lifepath_media.Visibility = Visibility.Visible;
                            break;
                        case "medtech":
                            lifepath_medtech.Visibility = Visibility.Visible;
                            break;
                        case "netrunner":
                            lifepath_netrunner.Visibility = Visibility.Visible;
                            break;
                        case "nomad":
                            lifepath_nomad.Visibility = Visibility.Visible;
                            break;
                        case "rokcerboy":
                            lifepath_rockerboy.Visibility = Visibility.Visible;
                            break;
                        case "solo":
                            lifepath_solo.Visibility = Visibility.Visible;
                            break;
                        case "tech":
                            lifepath_tech.Visibility = Visibility.Visible;
                            break;
                        default:
                            Console.WriteLine("Error");
                            break;
                    }
                    break;
                case "stats":
                    stats_container.Visibility = Visibility.Visible;
                    break;
                case "skills":
                    skills_container.Visibility = Visibility.Visible;
                    break;
                case "inventory":
                    inventory_container.Visibility = Visibility.Visible;
                    break;
                case "fashion":
                    fashion_container.Visibility = Visibility.Visible;
                    break;
                case "ability":
                    ability_container.Visibility = Visibility.Visible;
                    break;
                default:
                    Console.WriteLine("Error");
                    break;
            }
        }

        private void combobox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            //ComboBox comboBox = sender as ComboBox;

            //if (comboBox != null && comboBox.SelectedItem is ComboBoxItem selectedItem)
            //{
            //    DockPanel parentPanel = comboBox.Parent as DockPanel;

            //    if (parentPanel != null)
            //    {
            //        TextBox associatedTextBox = parentPanel.Children.OfType<TextBox>().FirstOrDefault();

            //        if (associatedTextBox != null)
            //        {
            //            if (selectedItem.Name.Contains("rnd"))
            //            {
            //                var items = comboBox.Items.OfType<ComboBoxItem>().ToList();

            //                ComboBoxItem randomItem;

            //                do
            //                {
            //                    randomItem = items[rnd.Next(items.Count)];
            //                }
            //                while (randomItem.Name.Contains("rnd"));
            //                associatedTextBox.Text = randomItem.Content.ToString();
            //            }
            //            else
            //            {
            //                associatedTextBox.Text = selectedItem.Content.ToString();
            //            }
            //        }
            //    }
            //}
        }

        private void combobox_DropDownClosed(object sender, EventArgs e)
        {
            ComboBox comboBox = sender as ComboBox;

            if (comboBox != null && comboBox.SelectedItem is ComboBoxItem selectedItem)
            {
                DockPanel parentPanel = comboBox.Parent as DockPanel;

                if (parentPanel != null)
                {
                    TextBox associatedTextBox = parentPanel.Children.OfType<TextBox>().FirstOrDefault();

                    if (associatedTextBox != null)
                    {
                        if (selectedItem.Name.Contains("rnd"))
                        {
                            var items = comboBox.Items.OfType<ComboBoxItem>().ToList();

                            ComboBoxItem randomItem;

                            do
                            {
                                randomItem = items[rnd.Next(items.Count)];
                            }
                            while (randomItem.Name.Contains("rnd"));
                            associatedTextBox.Text = randomItem.Content.ToString();
                        }
                        else
                        {
                            associatedTextBox.Text = selectedItem.Content.ToString();
                        }
                    }
                }
            }
        }

        private void add_Click(object sender, RoutedEventArgs e)
        {
            Button addButton = sender as Button;

            if (addButton != null)
            {
                string buttonName = addButton.Name;
                DockPanel parentPanel = addButton.Parent as DockPanel;

                if (parentPanel != null)
                {
                    TextBox valueTextBox = parentPanel.Children.OfType<TextBox>().FirstOrDefault();

                    if (valueTextBox != null)
                    {
                        int currentValue = int.Parse(valueTextBox.Text);
                        currentValue++;
                        valueTextBox.Text = currentValue.ToString();
                    }
                }
            }
        }

        private void remove_Click(object sender, RoutedEventArgs e)
        {
            Button removeButton = sender as Button;

            if (removeButton != null)
            {
                DockPanel parentPanel = removeButton.Parent as DockPanel;

                if (parentPanel != null)
                {
                    TextBox valueTextBox = parentPanel.Children.OfType<TextBox>().FirstOrDefault();

                    if (valueTextBox != null)
                    {
                        int currentValue = int.Parse(valueTextBox.Text);
                        if (currentValue > 0)
                        {
                            currentValue--;
                            valueTextBox.Text = currentValue.ToString();
                        }
                    }
                }
            }
        }

        private void ChangeAviability(string word, UIElement rootElement, bool blockAdd)
        {
            foreach (var child in LogicalTreeHelper.GetChildren(rootElement))
            {
                if (child is DockPanel dockPanel)
                {
                    foreach (var dockChild in LogicalTreeHelper.GetChildren(dockPanel))
                    {
                        if (dockChild is Button button)
                        {
                            if (blockAdd && button.Name.Contains(word + "_add"))
                            {
                                button.IsEnabled = false;
                            }
                            else if (blockAdd && button.Name.Contains(word + "_remove"))
                            {
                                button.IsEnabled = true;
                            }
                            else if (!blockAdd && button.Name.Contains(word + "_remove"))
                            {
                                button.IsEnabled = false;
                            }
                            else if (!blockAdd && button.Name.Contains(word + "_add"))
                            {
                                button.IsEnabled = true;
                            }
                        }
                    }
                }
            }
        }

        private void DataGrid_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {

        }
    }
}
