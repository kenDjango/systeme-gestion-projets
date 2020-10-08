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

namespace SMInterface
{
    /// <summary>
    /// Logique d'interaction pour UserControlCreate.xaml
    /// </summary>
    public partial class UserControlCreate : UserControl
    {
        public UserControlCreate()
        {
            DataContext = UserVM.Instance;
            InitializeComponent();
        }

        private void Button_Create(object sender, RoutedEventArgs e)
        {
            PMService.DTicket ticket = new PMService.DTicket()
            {
                Title = "dsds",
                Descritpion = "dff",
                State = "dds",
                Creator = "dsd",
                Owner = "sds"
            };
        }
    }
}
