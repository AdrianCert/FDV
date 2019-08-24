namespace Data
{
    using System;
    using System.Data.Entity;
    using System.Collections.Generic;
    using System.Linq;
    using System.ComponentModel.DataAnnotations.Schema;

    [Table("User", Schema = "User")]
    public class User
    {
        public Guid Id { get; set; }
        public string Nume { get; set; }
        public string Prenume { get; set; }
        public UserContact Contact { get; set; }
        public Adress MainAdress { get; set; }
        public virtual ICollection<Adress> Adresses { get; set; }

        public virtual ICollection<Project> Proiects { get; set; }
        public virtual ICollection<Team> Teams { get; set; }
    }
}