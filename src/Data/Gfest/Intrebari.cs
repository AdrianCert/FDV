namespace Data
{
    using System;
    using System.Data.Entity;
    using System.Collections.Generic;
    using System.Linq;
    using System.ComponentModel.DataAnnotations.Schema;

    [Table("Chestionare", Schema = "Quiz")]
    public class Intrebare
    {
        public int Id { get; set; }
        public string Enunt { get; set; }

        public bool Image { get; set; }
        public string Path_Icon { get; set; }

        public string Var1 { get; set; }
        public string Var2 { get; set; }
        public string Var3 { get; set; }
        public string Var4 { get; set; }

        public bool IstrueVar1 { get; set; }
        public bool IstrueVar2 { get; set; }
        public bool IstrueVar3 { get; set; }
        public bool IstrueVar4 { get; set; }

    }
}