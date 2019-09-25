namespace Data
{
    using System;
    using System.Data.Entity;
    using System.Collections.Generic;
    using System.Linq;
    using System.ComponentModel.DataAnnotations.Schema;

    [Table("Exams", Schema = "Quiz")]
    public class Exam
    {
        public int Id { get; set; }
        public bool Verdict { get; set; }
        public int RaspunsuriCorecte { get; set; }
        public string ColectData { get; set; }
        public virtual Quiz Chestionar { get; set; }
    }
}