namespace Data
{
    using System;
    using System.Data.Entity;
    using System.Collections.Generic;
    using System.Linq;
    using System.ComponentModel.DataAnnotations.Schema;

    [Table("User", Schema = "User")]
    public class Participant
    {
        public int Id { get; set; }
        public string Nume { get; set; }
        public string Prenume { get; set; }
        public bool IsMan { get; set; }
        public int Age { get; set; }

        public string Email { get; set; }
        public string Telefon { get; set; } 
        public string Facebook { get; set; } 
        public string AlteRetele { get; set; } 

        public Participant_status Status { get; set; }
        public bool Abonat { get; set; }
        public string PassWord { get; set; }

        public virtual ICollection<Activitate> ActivitatiTerminate { get; set; }
        public virtual ICollection<Premiu> PremiiLuate { get; set; }
    }
    
}