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

namespace TweedeProject
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        int iCount = 0;
        private void btnCounter_Click(object sender, RoutedEventArgs e)
        {
            iCount++;
            lblCounter.Content = iCount.ToString();
        }



        private void btnHelloWorld_Click(object sender, RoutedEventArgs e)
        {
            lblHelloWorld.Content = "Hello World";
        }
    }
}
