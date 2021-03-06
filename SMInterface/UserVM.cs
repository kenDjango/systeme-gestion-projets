﻿using System;
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

        public PMService.DTicket selectedTicket;

        public PMService.DProject selectedProject;
        public int test = 0;

        public Grid grid;

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

        public PMService.DUser CurrentUser
        {
            get
            {
                return currentUser;
            }
            set
            {
                if (currentUser != value)
                {
                    currentUser = value;
                    NotifyPropertyChanged();
                }
            }
        }

        public PMService.DTicket SelectedTicket
        {
            get
            {
                return selectedTicket;
            }
            set
            {
                if (selectedTicket != value)
                {
                    selectedTicket = value;
                    NotifyPropertyChanged();
                }
            }
        }


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

        public ObservableCollection<PMService.DTicket> TicketListInProgress
        {
            get
            {
                return ticketListInProgress;
            }
            set
            {
                if (ticketListInProgress != value)
                {
                    ticketListInProgress = value;
                    NotifyPropertyChanged();
                }
            }
        }

        public ObservableCollection<PMService.DTicket> TicketListDone
        {
            get
            {
                return ticketListDone;
            }
            set
            {
                if (ticketListDone != value)
                {
                    ticketListDone = value;
                    NotifyPropertyChanged();
                }
            }
        }

        public int ListToDoSize
        {
            get
            {
                return TicketListToDo.Count;
            }

        }

        public int ListInProgressSize
        {
            get
            {
                return TicketListInProgress.Count;
            }
        }

        public int ListDoneSize
        {
            get
            {
                return TicketListDone.Count;
            }
        }


        public bool connectUser(string username, string password)
        {
            var DBClient = new PMService.TicketSystemServiceClient();
            currentUser =  DBClient.connectAsUser(username, password);
            DBClient.Close();
            if (currentUser != null)
            {
                projects = new ObservableCollection<PMService.DProject>(currentUser.projectsMember);
                return true;
            }
            return false;

        }

        
        public bool editTicket(PMService.DTicket ticket, string oldState)
        {
            var DBClient = new PMService.TicketSystemServiceClient();
            bool res = DBClient.editTicket(ticket.Id, ticket.Title, ticket.Description, ticket.State);
            if (res)
            {
                removeAddTicket(oldState, ticket);
            }
            DBClient.Close();
            return res;
        }


        private void removeAddTicket(string oldState, PMService.DTicket ticket)
        {
            switch (ticket.State)
            {
                case "TODO":
                    TicketListToDo.Add(ticket);
                    PropertyChanged(this, new PropertyChangedEventArgs("ListToDoSize"));
                    break;
                case "WIP":
                    TicketListInProgress.Add(ticket);
                    PropertyChanged(this, new PropertyChangedEventArgs("ListInProgressSize"));
                    break;
                case "DONE":
                    TicketListDone.Add(ticket);
                    PropertyChanged(this, new PropertyChangedEventArgs("ListDoneSize"));
                    break;
                default:
                    break;
            }

            switch (oldState)
            {
                case "TODO":
                    TicketListToDo.Remove(ticket);
                    PropertyChanged(this, new PropertyChangedEventArgs("ListToDoSize"));
                    break;
                case "WIP":
                    TicketListInProgress.Remove(ticket);
                    PropertyChanged(this, new PropertyChangedEventArgs("ListInProgressSize"));
                    break;
                case "DONE":
                    TicketListDone.Remove(ticket);
                    PropertyChanged(this, new PropertyChangedEventArgs("ListDoneSize"));
                    break;
                case "NONE":
                    break;
            }
        }

        //DBClient.createTicket return new ticket id or -1 if error
        public int createTicket(PMService.DTicket ticket)
        {
            var DBClient = new PMService.TicketSystemServiceClient();
            int res = DBClient.createTicket(ticket,selectedProject.Id,currentUser.Id);

            if (res>=1)
            {
                ticket.Id = res;
                removeAddTicket("NONE", ticket);
                var tickets = new List<PMService.DTicket>(selectedProject.Tickets);
                tickets.Add(ticket);
                selectedProject.Tickets = tickets.ToArray();
            }
            DBClient.Close();
            return res;
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
