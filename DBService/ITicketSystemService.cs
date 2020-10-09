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
    // REMARQUE : vous pouvez utiliser la commande Renommer du menu Refactoriser pour changer le nom d'interface "IService1" à la fois dans le code et le fichier de configuration.
    [ServiceContract]
    public interface ITicketSystemService
    {

        [OperationContract]
        int createTicket(DTicket ticket, int projectId, int creatorId);

        [OperationContract]
        DUser connectAsUser(string name, string password);

        [OperationContract]
        bool editTicket(int ticketId, string editTitle, string editDescription,string editState);

    }


    // Utilisez un contrat de données comme indiqué dans l'exemple ci-après pour ajouter les types composites aux opérations de service.
    [DataContract]
    public class DUser
    {
        [DataMember]
        public int Id { get; set; }

        [DataMember]
        public string Username { get; set; }

        [DataMember]
        public ObservableCollection<DProject> projectsMember { get; set; }

    }

    [DataContract]
    public class DTicket
    {

        [DataMember]
        public int Id { get; set; }

        [DataMember]
        public string Title { get; set; }

        [DataMember]
        public string Description { get; set; }

        [DataMember]
        public Nullable<System.DateTime> Date { get; set; }

        [DataMember]
        public string State { get; set; }

        [DataMember]
        public string Creator { get; set; }

        [DataMember]
        public string Owner { get; set; }
    }

    [DataContract]
    public class DProject
    {
        [DataMember]
        public int Id { get; set; }

        [DataMember]
        public string Name { get; set; }

        [DataMember]
        public string Owner { get; set; }

        [DataMember]
        public string Description { get; set; }

        [DataMember]
        public ObservableCollection<DTicket> Tickets { get; set; }
    }
}
