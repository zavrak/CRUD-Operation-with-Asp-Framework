namespace Case.Models.DataModel
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("EnmUnvan")]
    public partial class EnmUnvan
    {
        public int Id { get; set; }

        public int? UnvanCode { get; set; }

        [StringLength(100)]
        public string UnvanAd { get; set; }
    }
}
