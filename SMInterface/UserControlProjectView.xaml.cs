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
    /// Logique d'interaction pour UserControlProjectView.xaml
    /// </summary>
    public partial class UserControlProjectView : UserControl
    {
        public UserControlProjectView()
        {
            DataContext = UserVM.Instance;
            InitializeComponent();
        }


        private void Liste_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var list = sender as ListBox;
            var ticket = list.SelectedItem as PMService.DTicket;
            (DataContext as UserVM).SelectedTicket = ticket;
            setComboBoxState(ticket.State);
            EditDialog.IsOpen = true;
        }


        private void setComboBoxState(string state)
        {
            switch (state)
            {
                case "TODO":
                    comboxState.SelectedIndex = 0;
                    break;
                case "WIP":
                    comboxState.SelectedIndex = 1;
                    break;
                case "DONE":
                    comboxState.SelectedIndex = 2;
                    break;
                
            }
        }

        private void Edit_Click(object sender, RoutedEventArgs e)
        {
            var ticket = (DataContext as UserVM).SelectedTicket;
            ticket.State = comboxState.Text;

            Console.WriteLine(ticket.Title);

            Console.WriteLine(ticket.Descritpion);
            (DataContext as UserVM).editTicket(ticket.Id, ticket.Title,ticket.Descritpion,ticket.State);
        }
    }
}
