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


namespace Yatzy
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
        
        private void Button_Click(object sender, RoutedEventArgs e)
        {

            YatzyEngine Engine = new YatzyEngine();
            var ListOfdices = Engine.FiveDices();
            Engine.totalScoreFromThrow(Engine.Kasta(ListOfdices));
          
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Player Leffe = new Player();
            Leffe.Name = "Leffe Jansson";
                       
        }
    }
}
