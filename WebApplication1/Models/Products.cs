namespace WebApplication1.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Products
    {
        public int ID { get; set; }

        [Required]
        [StringLength(150)]
        public string Name { get; set; }

        [StringLength(200)]
        public string Description { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? Commission { get; set; }

        [Column(TypeName = "numeric")] 
        public decimal Price { get; set; }

        public int FK_Companies_Products { get; set; }

        public virtual Companies Companies { get; set; }
    }
}
