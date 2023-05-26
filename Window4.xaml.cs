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
    /// Логика взаимодействия для Window4.xaml
    /// </summary>
    public partial class Window4 : Window
    {
        public Window4()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            double p = int.Parse(vod.Text);
            double distance =int.Parse(vod.Text);
            double totalDistance = int.Parse(vod.Text);
            int day = 1;

            while (totalDistance <= 200)
            {
                distance *= (1 + p / 100);
                totalDistance += distance;
                day++;
            }

            otv.Text = $"Количесвто дней {day}";
            otv.Text = $"Сумарный пробег {totalDistance}";
            

        }
    }
}
