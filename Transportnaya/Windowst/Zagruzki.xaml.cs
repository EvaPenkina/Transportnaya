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

namespace Transportnaya.Windowst
{
    /// <summary>
    /// Логика взаимодействия для Zagruzki.xaml
    /// </summary>
    public partial class Zagruzki : Window
    {
        public Zagruzki()
        {
            InitializeComponent();
        }

     
        private void BackZ_Click(object sender, RoutedEventArgs e)
        {
            Meny window = new Meny();
            window.Show();
            Close();
        }

        private void DeletZ_Click(object sender, RoutedEventArgs e)
        {

        }

        private void AddZ_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
