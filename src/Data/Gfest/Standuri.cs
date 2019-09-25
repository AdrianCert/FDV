namespace Data
{
    using System;
    using System.Data.Entity;
    using System.Collections.Generic;
    using System.Linq;
    using System.ComponentModel.DataAnnotations.Schema;

    [Table("Activitati", Schema = "Pub")]
    public class Activitate
    {
        public int Id { get; set; }
        public string Nume { get; set; }
        public string Descriere { get; set; }

        public string Path_Icon { get; set; }

        public virtual Activitate BlockAct { get; set; }
    }
}