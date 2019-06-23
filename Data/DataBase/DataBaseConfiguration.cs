using System.ComponentModel.DataAnnotations;

namespace Data
{
    using System;
    using System.Data.Entity;
    using System.Collections.Generic;
    using System.Linq;


    public class DataBase : DbContext
    {
        public DataBase()
            : base("name=DataBase")
        {
        }
        public DbSet<User> Users { get; set; }
        public DbSet<UserIndentification> UserIndentifications { get; set; }
        public DbSet<UserContact> UserContacts { get; set; }
        public DbSet<UserMail> UserMails { get; set; }
        public DbSet<UserNumber> UserNumbers { get; set; }
        public DbSet<UserSocial> Socials { get; set; }
        public DbSet<Adress> Adresses { get; set; }
        public DbSet<Team> Teams { get; set; }
        public DbSet<Project> Projects { get; set; }
        public DbSet<Activity> Activities { get; set; }
    }
}