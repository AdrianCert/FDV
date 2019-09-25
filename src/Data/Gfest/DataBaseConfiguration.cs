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
        public DbSet<User> Users { get; set; }
}