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

namespace EventRouting_Example
{
    /// <summary>
    /// MainWindow.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class MainWindow_Tunneling : Window
    {
        string mouseActivity = string.Empty;

        public MainWindow_Tunneling()
        {
            InitializeComponent();
        }

        private void Window_PreviewMouseDown(object sender, MouseButtonEventArgs e)
        {
            mouseActivity = "PreviewMouseDown Window \n";
            MessageBox.Show(mouseActivity);
        }

        private void StackPanel_PreviewMouseDown(object sender, MouseButtonEventArgs e)
        {
            mouseActivity = "PreviewMouseDown Stack \n";
            MessageBox.Show(mouseActivity);
        }

        private void Button_PreviewMouseDown(object sender, MouseButtonEventArgs e)
        {
            mouseActivity = "PreviewMouseDown Button \n";
            MessageBox.Show(mouseActivity);
        }
    }
}
