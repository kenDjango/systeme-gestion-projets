using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace SMInterface
{
    class UserVM: INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        public PMService.DUser dUser;



        public bool connectUser(string username, string password)
        {
            var DBClient = new PMService.TicketSystemServiceClient();
            dUser = DBClient.connectAsUser(username, password);
            if (dUser != null)
                return true;
            return false;

        }

        public UserVM()
        {
        }

        ICommand connectAsUser;
        public ICommand ConnectAsUser
        {
            get
            {
                if (connectAsUser == null)
                {
                    connectAsUser = new RelayCommand<object>((obj) =>
                    {
                        var DBClient = new PMService.TicketSystemServiceClient();
                        //dUser = DBClient.connectAsUser(username, password);
                    });
                }
                return connectAsUser;
            }
        }
    }
}
