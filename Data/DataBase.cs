namespace Data
{
    using System;
    using System.Data.Entity;
    using System.Collections.Generic;
    using System.Linq;

    public class DataBase : DbContext
    {
        // Your context has been configured to use a 'DataBase' connection string from your application's 
        // configuration file (App.config or Web.config). By default, this connection string targets the 
        // 'Data.DataBase' database on your LocalDb instance. 
        // 
        // If you wish to target a different database and/or database provider, modify the 'DataBase' 
        // connection string in the application configuration file.
        public DataBase()
            : base("name=DataBase")
        {
        }

        // Add a DbSet for each entity type that you want to include in your model. For more information 
        // on configuring and using a Code First model, see http://go.microsoft.com/fwlink/?LinkId=390109.

        // public virtual DbSet<MyEntity> MyEntities { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Adress> Adresses { get; set; }
        public DbSet<Contact_Date> Contact_Dates { get; set; }
        public DbSet<Indentification_Date> Indentification_Dates { get; set; }
    }

    public class User
    {
        public Guid Id { get; set; }
        public string Nume { get; set; }
        public string Prenume { get; set; }
        public Guid Adress_Id { get; set; }
        public virtual ICollection<Adress> Adresses { get; set; }

    }
    public class Adress
    {
        public Guid Id { get; set; }
        public string Strada { get; set; }
        public int Nr { get; set; }
        public string Line_2 { get; set; }
        public string Localitate { get; set; }
        public Judet Judet { get; set; }
    }
    public enum Judet
    {
        București,
        Iași,
        Prahova,
        Cluj,
        Constanța,
        Timiș,
        Dolj,
        Suceava,
        Bacău,
        Argeș,
        Bihor,
        Mureș,
        Galați,
        Brașov,
        Dâmbovița,
        Neamț,
        Maramureș,
        Buzău,
        Olt,
        Arad,
        Hunedoara,
        Botoșani,
        Vaslui,
        Sibiu,
        Vâlcea,
        Teleorman,
        Ilfov,
        Gorj,
        Alba,
        Vrancea,
        Satu_Mare,
        Brăila,
        Harghita,
        Bistrița_Năsăud,
        Caraș_Severin,
        Călărași,
        Giurgiu,
        Ialomița,
        Mehedinți,
        Sălaj,
        Tulcea,
        Covasna
    }
    public class Contact_Date
    {
        public Guid Id { get; set; }
        public string Mail { get; set; }
        public int[] Phone { get; set; }
        public string[] SocialLinks { get; set; }
        public Guid UserId { get; set; }
        public virtual User User { get; set; }
    }
    public class Indentification_Date
    {
        public Guid Id { get; set; }
        public string Serie_CI { get; set; }
        public string Number_CI { get; set; }
        public int CNP { get; set; }
        public Guid UserID { get; set; }
        public virtual User User { get; set; }
    }
}