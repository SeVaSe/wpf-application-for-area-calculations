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
    /// Логика взаимодействия для Sphera_Wind.xaml
    /// </summary>
    public partial class Sphera_Wind : Window
    {
        public Sphera_Wind()
        {
            InitializeComponent();
        }

        private void vichisl_spher_click(object sender, RoutedEventArgs e)
        {
            try
            {
                double r = Convert.ToDouble(r_vvod.Text);
                double v_resh = (1.3 * 3.14) * Math.Pow(r, 3);
                TxtBl_V.Text = Convert.ToString(Math.Round(v_resh, 3));

                double r1 = Convert.ToDouble(r_vvod.Text);
                double s_resh = 4 * Math.PI * Math.Pow(r1, 2);
                TxtBl_S.Text = Convert.ToString(Math.Round(s_resh, 3));
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
