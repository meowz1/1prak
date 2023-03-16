﻿using System;
using System.Collections.Generic;
using System.Data;
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
using WpfApp1.mafonDataSetTableAdapters;

namespace WpfApp1
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    
    public partial class MainWindow : Window
    {

        city_TableAdapter mir = new city_TableAdapter();
        callsTableAdapter kir = new callsTableAdapter();
        public MainWindow()
        {
            InitializeComponent();
            xxx.ItemsSource = mir.GetData();

            ComboBox1.ItemsSource = kir.GetData();
            ComboBox1.DisplayMemberPath = "number_of_minutes";

        }

        private void ComboBox1_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            object cell = (ComboBox1.SelectedItem as DataRowView).Row[0];
            MessageBox.Show(cell.ToString());
        }
    }
}
