namespace Data
{
    using System;
    using System.Data.Entity;
    using System.Collections.Generic;
    using System.Linq;

    public class Project
    {
        public Guid Id { get; set; }
        public string Nume { get; set; }
        public string Descriere { get; set; }
        public virtual ICollection<User> Team { get; set; }
        public virtual ICollection<Activity> Activities { get; set; }
    }
    public class Activity
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        //TimeLine 
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }

        // Dependency Task
        public bool Dependency { get; set; }
        public Guid ActivityId { get; set; }
        public Activity DependecyActivity { get; set; }

        // Team Work Activity
        public Guid ResponsableId { get; set; }
        public User Responsable { get; set; }
        public virtual ICollection<User> Team { get; set; }

    }
}