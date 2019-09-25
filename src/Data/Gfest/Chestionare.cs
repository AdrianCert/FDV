namespace Data
{
    using System;
    using System.Data.Entity;
    using System.Collections.Generic;
    using System.Linq;
    using System.ComponentModel.DataAnnotations.Schema;

    [Table("Chestionare", Schema = "Quiz")]
    public class Quiz
    {
        public int Id { get; set; }
        public string Nume { get; set; }
        public string Descriere { get; set; }

        public string Path_Icon { get; set; }

        public virtual ICollection<Intrebare> Intrebari { get; set; }
    }
}