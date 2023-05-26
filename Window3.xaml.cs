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
    /// Логика взаимодействия для Window3.xaml
    /// </summary>
    public partial class Window3 : Window
    {
        public Window3()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            int n = int.Parse(vod.Text);
            int x = int.Parse(vod1.Text);
            bool isPowerOfThree = false;

            while (x <= n)
            {
                if (x == n)
                {
                    isPowerOfThree = true;
                    break;
                }

                x *= 3;
            }

            otv.Text = $"{isPowerOfThree}";
        }
    }
}
