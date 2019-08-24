namespace Data
{
    using System;
    using System.Data.Entity;
    using System.Collections.Generic;
    using System.Linq;
    using System.ComponentModel.DataAnnotations.Schema;

    [Table("Team", Schema = "User")]
    public class Team
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public User Leader { get; set; }
        public virtual ICollection<User> Members { get; set; }
        public virtual ICollection<Project> ProjectEnvolved { get; set; }
    }
}