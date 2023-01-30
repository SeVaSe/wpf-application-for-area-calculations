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
    /// Логика взаимодействия для Usech_Konus.xaml
    /// </summary>
    public partial class Usech_Konus : Window
    {
        public Usech_Konus()
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
                double R1 = double.Parse(TxtBox_R1.Text);
                double R2 = double.Parse(TxtBox_R2.Text);
                double H = double.Parse(TxtBox_H.Text);

                double l = Math.Sqrt(Math.Pow((R1 - R2), 2) + Math.Pow(H, 2));

                double resh_S1 = Math.PI * Math.Pow(R1, 2);
                double resh_S2 = Math.PI * Math.Pow(R2, 2);
                double resh_bok = Math.PI * l * (R1 + R2);
                double resh_V = 1.046 * H * (Math.Pow(R1, 2) + R1 * R2 + Math.Pow(R2, 2));

                TxtBl_S1.Text = Math.Round(resh_S1, 3).ToString();
                TxtBl_S2.Text = Math.Round(resh_S2, 3).ToString();
                TxtBl_bok.Text = Math.Round(resh_bok, 3).ToString();
                TxtBL_V.Text = Math.Round(resh_V, 3).ToString();
            }
            catch 
            {
                MessageBox.Show("Вы ввели не правильные значения, исправьте это!", "Ошибка значений!");
            }
            
        }
    }
}
