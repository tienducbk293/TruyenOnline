namespace Model.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("AnhHungXaDieu")]
    public partial class AnhHungXaDieu
    {
        public int ID { get; set; }

        public int ChapNumber { get; set; }

        [Required]
        [StringLength(255)]
        public string ChapName { get; set; }

        [Column(TypeName = "ntext")]
        [Required]
        public string Content { get; set; }
    }
}
