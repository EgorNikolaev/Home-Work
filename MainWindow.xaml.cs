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

namespace Wpf_Exponentiation
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

        private void ResButt(object sender, RoutedEventArgs e)
        {
            bool flagNum = false, flagDeg = false;

            try
            {
                int number = Convert.ToInt32(tbNumb.Text);
                if (number <= 47 || number >= 58)
                {
                    flagNum = true;
                }
                else { MessageBox.Show("Ввод не коректен"); }
                int degree = Convert.ToInt32(tbDegree.Text);
                if (degree <= 47 || degree >= 58)
                {
                    flagDeg = true;
                }
                else { MessageBox.Show("Ввод не коректен"); }
                if (flagDeg & flagNum)
                {
                    tbResText.Text = Convert.ToString(Math.Pow(Convert.ToInt32(tbNumb.Text), Convert.ToInt32(tbDegree.Text)));
                }
            }
            catch { MessageBox.Show("Не коректные данные"); }


        }
    }
}
