using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Input;

namespace SMInterface
{
    class UserVM: INotifyPropertyChanged
    {
        public static UserVM instance;

        public event PropertyChangedEventHandler PropertyChanged;
        public PMService.DUser currentUser;
        public ObservableCollection<PMService.DProject> projects;

        public ObservableCollection<PMService.DTicket> ticketListToDo;
        public ObservableCollection<PMService.DTicket> ticketListInProgress;
        public ObservableCollection<PMService.DTicket> ticketListDone;

        public PMService.DProject selectedProject;
        public Grid grid;

        public UserControlProjects userControlProjects;

        public ObservableCollection<PMService.DProject> Projects
        {
            get
            {
                return projects;
            }
            set
            {
                if(projects != value)
                {
                    projects = value;
                    NotifyPropertyChanged();
                }
            }
        }

        public PMService.DProject SelectedProject
        {
            get
            {
                return selectedProject;
            }
            set
            {
                if (selectedProject != value)
                {
                    var todo = value.Tickets.Where((elem)=> elem.State == "TODO");
                    var wip = value.Tickets.Where((elem) => elem.State == "WIP");
                    var done = value.Tickets.Where((elem) => elem.State == "DONE");

                    ticketListToDo = new ObservableCollection<PMService.DTicket>(todo);
                    ticketListInProgress = new ObservableCollection<PMService.DTicket>(wip);
                    ticketListDone = new ObservableCollection<PMService.DTicket>(done);

                    selectedProject = value;
                    NotifyPropertyChanged();
                }
            }
        }

        public ObservableCollection<PMService.DTicket> TicketListToDo
        {
            get
            {
                return ticketListToDo;
            }
            set
            {
                if (ticketListToDo != value)
                {
                    ticketListToDo = value;
                    NotifyPropertyChanged();
                }
            }
        }

        private UserVM()
        {
            projects = new ObservableCollection<PMService.DProject>();
            userControlProjects = new UserControlProjects();
        }

        public static UserVM Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new UserVM();
                }
                return instance;
            }

        }


        public bool connectUser(string username, string password)
        {
            var DBClient = new PMService.TicketSystemServiceClient();
            currentUser = DBClient.connectAsUser(username, password);
            if (currentUser != null)
            {
                projects = new ObservableCollection<PMService.DProject>(currentUser.projectsMember);
                return true;
            }
            return false;

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

        ICommand selectProject;
        public ICommand SelectProject
        {
            get
            {
                if (selectProject == null)
                {
                    selectProject = new RelayCommand<PMService.DProject>((obj) =>
                    {
                        Console.WriteLine("SELECTED COMMAND");
                        selectedProject = obj;
                    });
                }
                return selectProject;
            }
        }


        private void NotifyPropertyChanged([CallerMemberName]string str = "")
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(str));
        }
    }
}
