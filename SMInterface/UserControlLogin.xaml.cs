using MaterialDesignThemes.Wpf;
using System;
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
    /// Logique d'interaction pour UserControlLogin.xaml
    /// </summary>
    public partial class UserControlLogin : UserControl
    {
        public UserControlLogin()
        {
            InitializeComponent();
        }

        private void Button_LogIn(object sender, RoutedEventArgs e)
        {

            var vm = UserVM.Instance;

            if (vm.connectUser(username.Text, password.Password))
            {
                LoginDialog.IsOpen = false;
                vm.grid.Children.Clear();
                vm.grid.Children.Add(vm.userControlProjects);
            }
            else
            {
                LoginDialog.IsOpen = true;
            }
        }
    }
}
