namespace Data
{
    using System;
    using System.Data.Entity;
    using System.Collections.Generic;
    using System.Linq;
    using System.ComponentModel.DataAnnotations.Schema;

    [Table("Admins", Schema = "Adm")]
    public class Admin
    {
        public int Id { get; set; }
        public string Nume { get; set; }
        public string Data { get; set; }

        public string Password { get; set; }
}