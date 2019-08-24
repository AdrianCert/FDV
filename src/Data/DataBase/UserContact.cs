namespace Data
{
    using System;
    using System.Data.Entity;
    using System.Collections.Generic;
    using System.Linq;
    using System.ComponentModel.DataAnnotations.Schema;

    [Table("User", Schema = "UserContact")]
    public class UserContact
    {
        public Guid Id { get; set; }
        public virtual ICollection<UserSocial> Socials { get; set; }
        public virtual ICollection<UserMail> Mails { get; set; }
        public virtual ICollection<UserNumber> Numbers { get; set; }
        public User User { get; set; }
    }
    [Table("Mails", Schema = "UserContact")]
    public class UserMail
    {
        public Guid Id { get; set; }
        public PrivacyLevel Privacy { get; set; }
        public string Mail { get; set; }
    }
    [Table("Phones", Schema = "UserContact")]
    public class UserNumber
    {
        public Guid Id { get; set; }
        public PrivacyLevel Privacy { get; set; }
        public int Number { get; set; }
    }
    [Table("Socials", Schema = "UserContact")]
    public class UserSocial
    {
        public Guid Id { get; set; }
        public string CoverURL { get; set; }
        public string FullURL { get; set; }
        public SocialContest SocialName { get; set; }
        public PrivacyLevel Privacy { get; set; }
    }
}