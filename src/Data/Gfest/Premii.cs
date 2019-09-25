namespace Data
{
    using System;
    using System.Data.Entity;
    using System.Collections.Generic;
    using System.Linq;
    using System.ComponentModel.DataAnnotations.Schema;

    [Table("Premii", Schema = "Pub")]
    public class Premiu
    {
        public int Id { get; set; }

        public int NrIvent { get; set; }
        public int Value { get; set; }
        public string Nume { get; set; }
        public string Descriere { get; set; }
        public string Extras { get; set; }

        public string Path_Icon { get; set; }

        public bool Disponibil { get; set; }
        public virtual Participant Owner { get; set; }
    }
}