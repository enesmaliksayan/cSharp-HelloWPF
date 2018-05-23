using System;
using System.Collections;
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

namespace HelloWPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        ArrayList lenghtChecked = new ArrayList();

        public MainWindow()
        {
            InitializeComponent();
        }


        private void ApplyButton_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show($"Description text is: {this.DescriptionText.Text}");
        }

        private void ResetButton_Click(object sender, RoutedEventArgs e)
        {
            this.AssemblyCheckbox.IsChecked = this.DrillCheckbox.IsChecked = this.FoldCheckbox.IsChecked = this.LaserCheckbox.IsChecked
                = this.LatheCheckbox.IsChecked = this.PlasmaCheckbox.IsChecked = this.PurchaseCheckbox.IsChecked
                = this.RollCheckbox.IsChecked = this.SawCheckbox.IsChecked = this.WeldCheckbox.IsChecked = false;
        }

        private void RefreshButton_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Checkbox_Checked(object sender, RoutedEventArgs e)
        {
            lenghtChecked.Add((string)((CheckBox)sender).Content);
            this.LengthText.Text = "";
            foreach (object o in lenghtChecked)
            {
                this.LengthText.Text += (string)o + " ";
            }
        }

        private void Checkbox_Unchecked(object sender, RoutedEventArgs e)
        {
            lenghtChecked.Remove((string)((CheckBox)sender).Content);
            this.LengthText.Text = "";
            foreach (object o in lenghtChecked)
            {
                this.LengthText.Text += (string)o + " ";
            }

        }

        private void ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            string item = (string)((ComboBoxItem)((ComboBox)sender).SelectedValue).Content;
            StatusText.Text = item;
        }
    }
}
