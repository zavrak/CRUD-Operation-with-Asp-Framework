namespace Case.Models.DataModel
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("EnmDepartman")]
    public partial class EnmDepartman
    {
        [Key]
        public int DepartmantId { get; set; }

        public int? DepartmanCode { get; set; }

        [StringLength(100)]
        public string DepartmantName { get; set; }
    }
}
