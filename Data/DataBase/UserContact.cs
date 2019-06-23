namespace Data
{
    using System;
    using System.Data.Entity;
    using System.Collections.Generic;
    using System.Linq;
    using System.ComponentModel.DataAnnotations;

    public class UserContact
    {
        public Guid Id { get; set; }
        public ICollection<UserSocial> Socials { get; set; }
        public ICollection<UserMail> Mails { get; set; }
        public ICollection<UserNumber> Numbers { get; set; }
        public Guid UserId { get; set; }
        [Required]
        public virtual User User { get; set; }
    }
    public class UserMail
    {
        public Guid Id { get; set; }
        public PrivacyLevel Privacy { get; set; }
        public string Mail { get; set; }
    }
    public class UserNumber
    {
        public Guid Id { get; set; }
        public PrivacyLevel Privacy { get; set; }
        public int Number { get; set; }
    }
    public class UserSocial
    {
        public Guid Id { get; set; }
        public string ShortName { get; set; }
        public string FullName { get; set; }
        public SocialContest SocialName { get; set; }
        public PrivacyLevel Privacy { get; set; }
    }
}