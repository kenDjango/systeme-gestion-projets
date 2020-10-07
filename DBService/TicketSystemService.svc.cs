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
        public bool createTicket()
        {
            throw new NotImplementedException();
        }

        public string GetData(int value)
        {
            string res = "";
            using (var entities = new DBEntities())
            {
                var u = entities.Users.FirstOrDefault(
                    (user) => user.Username == "ken");

                foreach(Project p in u.ProjectMember)
                {
                    res += ($"Nom : {p.Name}, Prénom : {p.Owner.Username} \n");
                }
            }
            return res;
        }

        public DUser connectAsUser(string name, string password)
        {
            try
            {
                using (var entities = new DBEntities())
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
                                Descritpion = t.Descritpion,
                                Date = t.Date,
                                State = t.State.StateName,
                                Creator =  t.Creator.Username,
                                Owner = t.Owner.Username,
                                Id = t.Id
                            });
                        }

                        projects.Add(new DProject()
                        {
                            Name = p.Name,
                            Owner = p.Owner.Username,
                            Description = p.Description,
                            Tickets = tickets
                        });
                    }
                    return new DUser() { Username = u.Username, projectsMember = projects };
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
                using (var entities = new DBEntities())
                {
                    Ticket ticket  = entities.Tickets.Where((t) => t.Id == ticketId).ToArray()[0];
                    ticket.Title = editTitle;
                    ticket.Descritpion = editDescription;
                    ticket.State = entities.States.Where((s) => s.StateName == editState).ToArray()[0];
                    entities.SaveChanges();
                    return true;
                }
            }
            catch(Exception e)
            {
                Console.WriteLine(e);
                return false;
            }
        }

        private State StateHelper(string state)
        {
            State res;
            using (var entities = new DBEntities())
            {
                res = entities.States.Where((s) => s.StateName == state).ToArray()[0];
            }
            return res;
        }
    }
}
