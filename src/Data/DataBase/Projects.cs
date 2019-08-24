namespace Data
{
    using System;
    using System.Data.Entity;
    using System.Collections.Generic;
    using System.Linq;
    using System.IO;
    using System.ComponentModel.DataAnnotations.Schema;

    [Table("Project", Schema = "Project")]
    public class Project
    {
        public Guid Id { get; set; }
        public string Nume { get; set; }
        public string Descriere { get; set; }
        public virtual ICollection<Team> Teams { get; set; }
        public virtual ICollection<Activity> Activities { get; set; }
    }
    [Table("Activity", Schema = "Project")]
    public class Activity
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }

        public bool Dependency { get; set; }
        public Activity DependecyActivity { get; set; }

        public User Responsable { get; set; }
        public virtual ICollection<User> Team { get; set; }

    }
}