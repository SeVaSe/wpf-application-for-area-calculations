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
    /// Логика взаимодействия для Celindr_Wind.xaml
    /// </summary>
    public partial class Celindr_Wind : Window
    {
        public Celindr_Wind()
        {
            InitializeComponent();
        }

        

        private void back1_Click(object sender, RoutedEventArgs e)
        {
            MainWindow main = new MainWindow();
            main.Show();
            Hide();
        }

        private void vichisl_3_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                double R = double.Parse(TxtBox_R1.Text);
                double H = double.Parse(TxtBox_H1.Text);

                double resh_osn = Math.Pow(R, 2);
                double resh_bok = 2 * R * H;
                double resh_obch = resh_bok + (2 * resh_osn);
                double resh_v = 2 * R * (H + R);

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
    }
}
