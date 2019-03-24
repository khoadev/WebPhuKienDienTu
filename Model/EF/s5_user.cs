namespace Model.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class s5_user
    {
        public int id { get; set; }

        public string name { get; set; }

        [Required]
        public string account { get; set; }

        [Required]
        [StringLength(50)]
        public string password { get; set; }

        public int? cate { get; set; }

        public int? active { get; set; }
    }
}
