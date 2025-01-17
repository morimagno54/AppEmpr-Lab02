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

namespace App1
{
    /// <summary>
    /// Lógica de interacción para Menu.xaml
    /// </summary>
    public partial class Menu : Window
    {
        public Menu()
        {
            InitializeComponent();
        }

        OpIngresos opIngresos = new OpIngresos();
        RegConductores regConductores = new RegConductores();

        private void btnOpIngresos_Click(object sender, RoutedEventArgs e)
        {
            opIngresos.Show();
        }

        private void btnConductores_Click(object sender, RoutedEventArgs e)
        {
            regConductores.Show();
        }
    }
}
