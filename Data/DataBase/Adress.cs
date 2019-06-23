namespace Data
{
    using System;
    using System.Data.Entity;
    using System.Collections.Generic;
    using System.Linq;

    public class Adress
    {
        public Guid Id { get; set; }
        public PrivacyLevel Privacy { get; set; }
        public Judet Judet { get; set; }
        public string City { get; set; }
        public string Streat { get; set; }
        public int Nr { get; set; }
        public string Line_2 { get; set; }
        
    }
}