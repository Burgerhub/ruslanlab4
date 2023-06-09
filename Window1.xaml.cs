﻿using System;
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
    /// Логика взаимодействия для Window1.xaml
    /// </summary>
    public partial class Window1 : Window
    {
        public Window1()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            int age = int.Parse(vod.Text);
            int tens = age / 10;
            int ones = age % 10;
            string description = "";

            if (tens == 2)
            {
                description = "двадцать ";
            }
            else if (tens == 3)
            {
                description = "тридцать ";
            }
            else if (tens == 4)
            {
                description = "сорок ";
            }
            else if (tens == 5)
            {
                description = "пятьдесят ";
            }

            switch (ones)
            {
                case 1:
                    description += "один год";
                    break;
                case 2:
                    description += "два года";
                    break;
                case 3:
                    description += "три года";
                    break;
                case 4:
                    description += "четыре года";
                    break;
                case 5:
                    description += "пять лет";
                    break;
                case 6:
                    description += "шесть лет";
                    break;
                case 7:
                    description += "семь лет";
                    break;
                case 8:
                    description += "восемь лет";
                    break;
                case 9:
                    description += "девять лет";
                    break;
                default:
                    description += "лет";
                    break;
            }

            otv.Text = $"{description}";
        }
    }
}
