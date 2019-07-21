namespace Data
{
    using System;
    using System.Data.Entity;
    using System.Collections.Generic;
    using System.Linq;

    public class Team
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public Guid LeaderId { get; set; }
        public User Leader { get; set; }
        public virtual ICollection<User> TeamMembers { get; set; }
        public virtual ICollection<Project> ProjectEnvolved { get; set; }
    }
}