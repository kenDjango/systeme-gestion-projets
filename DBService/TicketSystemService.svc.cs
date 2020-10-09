using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace DBService
{
    // REMARQUE : vous pouvez utiliser la commande Renommer du menu Refactoriser pour changer le nom de classe "Service1" dans le code, le fichier svc et le fichier de configuration.
    // REMARQUE : pour lancer le client test WCF afin de tester ce service, sélectionnez Service1.svc ou Service1.svc.cs dans l'Explorateur de solutions et démarrez le débogage.
    public class TicketSystemService : ITicketSystemService
    {
        public int createTicket(DTicket ticket, int projectId, int creatorId)
        {
            try
            {
                using (var entities = new DDBEntitie())
                {
                    Console.WriteLine("dans le service web " + ticket.State);

                    State state = entities.States.Where((s) => s.StateName == ticket.State).ToArray()[0];
                    Project project = entities.Projects.Where((p) => p.Id == projectId).First();
                    User creator = entities.Users.Where((u) => u.Id == creatorId).First();

                    entities.Tickets.Add(new Ticket()
                    {
                        Title = ticket.Title,
                        Description = ticket.Description,
                        Date = ticket.Date,
                        Project = project,
                        Creator = creator,
                        Owner = creator,
                        id_state = state.Id

                    });

                    int newticket = entities.Tickets.OrderByDescending(i => i.Id).First().Id;

                    entities.SaveChanges();

                    return newticket;
                }
            }
            catch (Exception e)
            {
                return -1;
            }
        }

        public DUser connectAsUser(string name, string password)
        {
            try
            {
                using (var entities = new DDBEntitie())
                {
                    ObservableCollection<DProject> projects = new ObservableCollection<DProject>();
                    var u = entities.Users.First((elem) => elem.Username == name && elem.Password == password);
                    foreach (Project p in u.ProjectMember)
                    {
                        ObservableCollection<DTicket> tickets = new ObservableCollection<DTicket>();
                        foreach (Ticket t in p.Tickets)
                        {
                            tickets.Add(new DTicket()
                            {
                                Title = t.Title,
                                Description = t.Description,
                                Date = t.Date,
                                State = t.State.StateName,
                                Creator =  t.Creator.Username,
                                Owner = t.Owner.Username,
                                Id = t.Id
                            });
                        }

                        projects.Add(new DProject()
                        {
                            Id = p.Id,
                            Name = p.Name,
                            Owner = p.Owner.Username,
                            Description = p.Description,
                            Tickets = tickets
                        });
                    }
                    return new DUser() { Username = u.Username, projectsMember = projects, Id = u.Id };
                }
            }
            catch
            {
                return null;
            }
        }

        public bool editTicket(int ticketId, string editTitle, string editDescription, string editState)
        {
            try
            {
                using (var entities = new DDBEntitie())
                {
                    Ticket ticket  = entities.Tickets.Where((t) => t.Id == ticketId).ToArray()[0];
                    ticket.Title = editTitle;
                    ticket.Description = editDescription;
                    ticket.State = entities.States.Where((s) => s.StateName == editState).ToArray()[0];
                    entities.SaveChanges();
                    return true;
                }
            }
            catch(Exception e)
            {
                return false;
            }
        }

        private State StateHelper(string state)
        {
            State res;
            using (var entities = new DDBEntitie())
            {
                res = entities.States.Where((s) => s.StateName == state).ToArray()[0];
            }
            return res;
        }
    }
}
