namespace PrintumCommerce.Models.Access
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("PRO98 Propiedades")]
    public partial class PRO98_Propiedades
    {
        [StringLength(255)]
        public string Cod_PRO { get; set; }

        [Column(TypeName = "ntext")]
        public string Informacion { get; set; }

        [Key]
        public int idCode { get; set; }

        public virtual PRO1_Productos PRO1_Productos { get; set; }
    }
}
