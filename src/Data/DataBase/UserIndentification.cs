namespace Data
{
    using System;
    using System.Data.Entity;
    using System.Collections.Generic;
    using System.Linq;
    using System.ComponentModel.DataAnnotations;
    public class UserIndentification
    {
        public Guid Id { get; set; }
        public string Serial { get; set; }
        public int Number { get; set; }
        public int CNP { get; set; }
        public Guid UserID { get; set; }
        [Required]
        public virtual User User { get; set; }
    }
}