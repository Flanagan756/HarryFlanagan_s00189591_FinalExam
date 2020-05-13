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

namespace HarryFlanagan_s00189591
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        ModelExamContainer db = new ModelExamContainer();
        public MainWindow()
        {
            InitializeComponent();

       
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            //Put Phones from databse into listbox
            var query = from p in db.Phones
                        select p;

            lbxPhones.ItemsSource = query.ToList();
        }
    }
}
