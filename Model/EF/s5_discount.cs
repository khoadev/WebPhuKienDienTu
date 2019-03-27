namespace Model.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class s5_discount
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int id { get; set; }

        public int? id_product { get; set; }

        public DateTime? date_start { get; set; }

        public DateTime? date_end { get; set; }

        public double? per { get; set; }
    }
}
