namespace Data
{
    using System;
    using System.Data.Entity;
    using System.Collections.Generic;
    using System.Linq;

    public class User
    {
        public Guid Id { get; set; }
        public string Nume { get; set; }
        public string Prenume { get; set; }
        // Indentification User
        public Guid UserIndentificationId { get; set; }
        public virtual UserIndentification UserIndentification { get; set; }
        // Contact User
        public Guid ContactId { get; set; }
        public virtual UserContact Contact { get; set; }

        // Adresses & MainAdress
        public Guid MainAdressId { get; set; }
        public Adress MainAdress { get; set; }
        public virtual ICollection<Adress> Adresses { get; set; }

        public virtual ICollection<Project> Proiects { get; set; }
        public virtual ICollection<Team> Teams { get; set; }
    }
}