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

namespace _1pr
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void sphera_click(object sender, RoutedEventArgs e)
        {
            Sphera_Wind sphera_wind = new Sphera_Wind();   
            sphera_wind.Show();
            Hide();
        }

        private void konus_Click(object sender, RoutedEventArgs e)
        {
            Konus_Wind konus_wind = new Konus_Wind();
            konus_wind.Show();
            Hide();
        }

        private void celindr_Click(object sender, RoutedEventArgs e)
        {
            Celindr_Wind celindr_wind = new Celindr_Wind();
            celindr_wind.Show();
            Hide();
        }

        private void usuch_konus_Click(object sender, RoutedEventArgs e)
        {
            Usech_Konus usech_konus= new Usech_Konus(); 
            usech_konus.Show(); 
            Hide();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MessageBoxResult Result = MessageBox.Show("Закрыть приложение ?", "Выход", MessageBoxButton.YesNo);
            if (Result == MessageBoxResult.Yes) { Environment.Exit(0); }
            else { }
        }

        
    }
}
