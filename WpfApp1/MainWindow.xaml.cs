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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfApp1
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            MakeTheMenu();
        }

        private void MakeTheMenu()
        {
            MenuItem[] menuItems = new MenuItem[5];
            string guacamolePrise;

            for (int i=0; i<5; i++)
            {
                menuItems[i] = new MenuItem();
                if (i >= 3)
                {
                    menuItems[i].Bread = new string[] { "plain bagel", "onion bagel",
                        "pumpernickel bagel", "everything bagel" };
                }
                menuItems[i].Generate();
            }
            item1.Text = menuItems[0].Description;
            price1.Text = menuItems[0].Price;
            item2.Text = menuItems[1].Description;
            price2.Text = menuItems[1].Price;
            item3.Text = menuItems[2].Description;
            price3.Text = menuItems[2].Price;
            item4.Text = menuItems[3].Description;
            price4.Text = menuItems[3].Price;
            item5.Text = menuItems[4].Description;
            price5.Text = menuItems[4].Price;
            item6.Text = menuItems[5].Description;
            price6.Text = menuItems[5].Price;

            MenuItem specialMenuItem = new MenuItem();
            specialMenuItem.Proteins = new string[] { "Organic ham", "Mushroom patty", "Mortadella" };
            specialMenuItem.Bread = new string[] { "a gluten free roll", "a wrap", "pita" };
            specialMenuItem.Condiments = new string[] { "dijon mustard", "miso dressing", "au jus" };
            
        }
    }
}