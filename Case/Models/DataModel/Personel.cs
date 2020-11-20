namespace Case.Models.DataModel
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Personel")]
    public partial class Personel
    {
        public int Id { get; set; }

        public int SicilNo { get; set; }

        [Required]
        [StringLength(150)]
        public string Ad { get; set; }

        [Required]
        [StringLength(150)]
        public string Soyad { get; set; }

        [Column(TypeName = "date")]
        public DateTime IseGirisTarihi { get; set; }

        [Column(TypeName = "date")]
        public DateTime? IstenCikisTarihi { get; set; }

        [StringLength(200)]
        public string Email { get; set; }

        [StringLength(150)]
        public string EvTelefon { get; set; }

        [StringLength(100)]
        public string CepTelefonu { get; set; }

        [StringLength(20)]
        public string Cinsiyet { get; set; }
        [Display(Name = "Departman ")]
        public int DepartmanCode { get; set; }
        [Display(Name = "Unvan ")]
        public int UnvanCode { get; set; }
    }
}
