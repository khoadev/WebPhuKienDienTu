namespace Model.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class s5_product
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int id_cate { get; set; }

        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int id { get; set; }

        public string name { get; set; }

        [Column(TypeName = "money")]
        public decimal? price { get; set; }

        [Column(TypeName = "ntext")]
        public string info { get; set; }

        [Column(TypeName = "text")]
        public string img { get; set; }
    }
}
