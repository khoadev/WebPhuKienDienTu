namespace Model.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class s5_order_detail
    {
        public int id { get; set; }

        public int id_order { get; set; }

        public string name { get; set; }

        public int? qty { get; set; }

        [Column(TypeName = "money")]
        public decimal? price { get; set; }

        public double? discount { get; set; }
    }
}
