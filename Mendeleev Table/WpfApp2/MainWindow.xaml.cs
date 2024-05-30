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

namespace WpfApp2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Event_MouseDown(object sender, MouseButtonEventArgs e)
        {
            MessageBox.Show($"Atomic number {((sender as StackPanel).Children[0] as TextBlock).Text}, Symbol {((sender as StackPanel).Children[1] as TextBlock).Text}, atomic weight {((sender as StackPanel).Children[3] as TextBlock).Text}", $"{((sender as StackPanel).Children[2] as TextBlock).Text} info");
            
        }
    }
}
