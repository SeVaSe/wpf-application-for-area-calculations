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
using System.Windows.Shapes;

namespace _1pr
{
    /// <summary>
    /// Логика взаимодействия для Konus_Wind.xaml
    /// </summary>
    public partial class Konus_Wind : Window
    {
        public Konus_Wind()
        {
            InitializeComponent();
        }

        private void vichisl_2_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                double R = Convert.ToDouble(TxtBox_R.Text);
                double H = Convert.ToDouble(TxtBox_H.Text);
                double l = Math.Sqrt(R * R + H * H);

                double resh_osn = Math.PI * Math.Pow(R, 2);
                double resh_bok = Math.PI * R * l;
                double resh_obch = resh_bok + resh_osn;
                double resh_v = 0.3 * resh_osn * H;

                TxtBl_S_osn.Text = Convert.ToString(Math.Round(resh_osn, 3));
                TxtBl_S_bok.Text = Convert.ToString(Math.Round(resh_bok, 3));
                TxtBl_S_obch.Text = Convert.ToString(Math.Round(resh_obch, 3));
                TxtBL_V.Text = Convert.ToString(Math.Round(resh_v, 3));
            }
            catch 
            {
                MessageBox.Show("Вы ввели не правильные значения, исправьте это!", "Ошибка значений!");

            }
            
        }

        private void back1_Click(object sender, RoutedEventArgs e)
        {
            MainWindow main = new MainWindow();
            main.Show();
            Hide();
        }

        
    }
}
