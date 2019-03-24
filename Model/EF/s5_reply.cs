namespace Model.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class s5_reply
    {
        public int id { get; set; }

        public int id_comment { get; set; }

        public int id_user { get; set; }

        [StringLength(50)]
        public string name { get; set; }

        [Column(TypeName = "ntext")]
        public string cont { get; set; }

        public DateTime? date { get; set; }
    }
}
