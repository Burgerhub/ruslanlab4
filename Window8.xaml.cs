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

namespace ruslanprackt4var10
{
    /// <summary>
    /// Логика взаимодействия для Window8.xaml
    /// </summary>
    public partial class Window8 : Window
    {
        public Window8()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            int A = int.Parse(vod.Text);
            int B = int.Parse(vod1.Text);




            int remainder = 0;
            while (B != 0)
            {
                remainder = A % B;
                A = B;
                B = remainder;
            }



            otv.Text = "НОД: " + A;
        }
    }
}
