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

    }
}
