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
    /// Logique d'interaction pour UserControlProjects.xaml
    /// </summary>
    public partial class UserControlProjects : UserControl
    {
        public UserControlProjects()
        {
            InitializeComponent();
        }

        private void ListeProjects_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

            //Console.WriteLine((listeProjects.SelectedItem as PMService.DProject).Description);
            var vm = UserVM.Instance;
            if(listeProjects.SelectedItem != null)
            {
                vm.SelectedProject = listeProjects.SelectedItem as PMService.DProject;
                vm.grid.Children.Clear();
                vm.grid.Children.Add(new UserControlProjectView());
            }

        }
    }
}
