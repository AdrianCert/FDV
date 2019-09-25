using System.ComponentModel.DataAnnotations;

namespace Data
{
    using System;
    using System.Data.Entity;
    using System.Collections.Generic;
    using System.Linq;


    public class Gfest2019 : DbContext
    {
        public Gfest2019()
            : base("name=Gfest2019")
        {
        }
        public DbSet<Participant> Participanti { get; set; }
        public DbSet<Premiu> Premii { get; set; }
        public DbSet<Admin> Admins { get; set; }
        public DbSet<Activitate> Activitati { get; set; }
        public DbSet<Exam> Exams { get; set; }
        public DbSet<Quiz> Quizs { get; set; }
        public DbSet<Intrebare> Intrebari { get; set; }
    }
}