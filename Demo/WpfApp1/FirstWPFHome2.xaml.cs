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
    /// Interaction logic for FirstWPFHome.xaml
    /// </summary>
    public partial class FirstWPFHome : Page
    {
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            // View Expense Report  
            FirstWPFReportPage AddressReportPage = new FirstWPFReportPage(this.peopleListBox.SelectedItem);
            this.NavigationService.Navigate(AddressReportPage);

        }
        public FirstWPFHome()
        {
            InitializeComponent();
        }
    }
}
