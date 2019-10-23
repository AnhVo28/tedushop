namespace TeduShop.Model.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;
    using TeduShop.Model.Abstract;

    [Table("PostCategories")]
    public class PostCategory: Auditable
    {
 

        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }

        [Required]
        [MaxLength(256)]
        public string Name { get; set; }

        [Required]
        [Column(TypeName ="varchar")]
        [MaxLength(256)]
        public string Alias { get; set; }

        public int? ParentID { get; set; }

        public int? DisplayOrder { get; set; }

        [MaxLength(500)]
        public string Description { get; set; }


        [MaxLength(500)]
        public string Image { get; set; }

        public bool? HomeFlag { get; set; }

       
        public virtual IEnumerable<Post> Posts { get; set; }
    }
}
