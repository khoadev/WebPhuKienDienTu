namespace Model.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class s5_order
    {
        public int id { get; set; }

        public int? id_user { get; set; }

        public int? active { get; set; }

        public DateTime? date { get; set; }
    }
}
