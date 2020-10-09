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
            string user = (DataContext as UserVM).currentUser.Username;
            PMService.DTicket ticket = new PMService.DTicket()
            {
                Title = ticketTitle.Text,
                Description = ticketDescription.Text,
                State = comboxState.Text,
                Creator = user,
                Owner = user,
                Date = DateTime.Now
            };
            int result = (DataContext as UserVM).createTicket(ticket);

            if (result > 1)
            {
                createDialog.IsOpen = true;
                success.Visibility = Visibility.Visible;
                failure.Visibility = Visibility.Hidden;
                icon.Kind = MaterialDesignThemes.Wpf.PackIconKind.Done;
            }
            else
            {
                createDialog.IsOpen = true;
                success.Visibility = Visibility.Hidden;
                failure.Visibility = Visibility.Visible;
                icon.Kind = MaterialDesignThemes.Wpf.PackIconKind.Error;
            }
        }
    }
}
