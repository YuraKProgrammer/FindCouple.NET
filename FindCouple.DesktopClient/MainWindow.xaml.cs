using FindCouple.DesktopClient.Windows;
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

namespace FindCouple.DesktopClient
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

        private void _startGame(object sender, RoutedEventArgs e)
        {
            var window = new GameWindow(GetFieldSize());
            window.Show();
        }
        
        private int GetFieldSize()
        {
            if (_4.IsChecked == true)
            {
                return 4;
            }
            if (_6.IsChecked == true)
            {
                return 6;
            }
            if (_8.IsChecked == true)
            {
                return 8;
            }
            if (_10.IsChecked == true)
            {
                return 10;
            }
            if (_12.IsChecked == true)
            {
                return 12;
            }
            if (_14.IsChecked == true)
            {
                return 14;
            }
            if (_16.IsChecked == true)
            {
                return 16;
            }
            if (_18.IsChecked == true)
            {
                return 18;
            }
            return 4;
        }
    }
}
