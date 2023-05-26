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
    /// Логика взаимодействия для Window2.xaml
    /// </summary>
    public partial class Window2 : Window
    {
        public Window2()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            int element = int.Parse(vod.Text);
            double value = int.Parse(vod1.Text);
            double a, c, h, S;

            switch (element)
            {
                case 1:
                    a = value;
                    c = a * Math.Sqrt(2);
                    h = c / 2;
                    S = c * h / 2;
                    otv.Text = $"Гипотенуза {c}";
                    otv.Text = $"Высота {h}";
                    otv.Text = $"Площадь {S}";
                    break;
                case 2:
                    c = value;
                    a = c / Math.Sqrt(2);
                    h = c / 2;
                    S = c * h / 2;
                    otv.Text = $"Катет {a}";
                    otv.Text = $"Высота {h}";
                    otv.Text = $"Площадь {S}";
                    break;
                case 3:
                    h = value;
                    c = h * 2;
                    a = c / Math.Sqrt(2);
                    S = c * h / 2;
                    otv.Text = $"Катет {a}";
                    otv.Text = $"Гипотенуза {c}";
                    otv.Text = $"Площадь {S}";
                    break;
                case 4:
                    S = value;
                    c = Math.Sqrt(S * 2);
                    h = c / 2;
                    a = c / Math.Sqrt(2);
                    otv.Text = $"Катет {a}";
                    otv.Text = $"Гипотенуза {c}";
                    otv.Text = $"Высота {h}";
                    break;
                default:
                    otv.Text = $"Некоректный номер ввода";
                    break;
            }

        }
    }
}
