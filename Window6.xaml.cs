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
    /// Логика взаимодействия для Window6.xaml
    /// </summary>
    public partial class Window6 : Window
    {
        public Window6()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            int tasks = int.Parse(vod.Text);

            string description = "";

            if (tasks >= 10 && tasks <= 20) 
            {
                switch (tasks)
                {
                    case 10:
                        description = "десять учебных заданий";
                        break;
                    case 11:
                        description = "одиннадцать учебных заданий";
                        break;
                    case 12:
                        description = "двенадцать учебных заданий";
                        break;
                    case 13:
                        description = "тринадцать учебных заданий";
                        break;
                    case 14:
                        description = "четырнадцать учебных заданий";
                        break;
                    case 15:
                        description = "пятнадцать учебных заданий";
                        break;
                    case 16:
                        description = "шестнадцать учебных заданий";
                        break;
                    case 17:
                        description = "семнадцать учебных заданий";
                        break;
                    case 18:
                        description = "восемнадцать учебных заданий";
                        break;
                    case 19:
                        description = "девятнадцать учебных заданий";
                        break;
                    case 20:
                        description = "двадцать учебных заданий";
                        break;
                }
            }
            else 
            {
                int tens = tasks / 10;
                int ones = tasks % 10;

                switch (tens)
                {
                    case 2:
                        description = "двадцать ";
                        break;
                    case 3:
                        description = "тридцать ";
                        break;
                    case 4:
                        description = "сорок ";
                        break;
                }

                switch (ones)
                {
                    case 1:
                        description += "одно учебное задание";
                        break;
                    case 2:
                        description += "два учебных задания";
                        break;
                    case 3:
                        description += "три учебных задания";
                        break;
                    case 4:
                        description += "четыре учебных задания";
                        break;
                    case 5:
                        description += "пять учебных заданий";
                        break;
                    case 6:
                        description += "шесть учебных заданий";
                        break;
                    case 7:
                        description += "семь учебных заданий";
                        break;
                    case 8:
                        description += "восемь учебных заданий";
                        break;
                    case 9:
                        description += "девять учебных заданий";
                        break;
                }
            }

          otv.Text = $"{description}";
        }
    }
}
