using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MyBlog.Models
{

    [Table("Category")]
    public class Category
    {
        [Key]
        public int CategoryID { get; set; }

        [Display(Name ="Kategori Adı")]
        public string CategoryName { get; set; }

        public ICollection<Post> Posts { get; set; }
        [Display(Name = "Akif")]
        public bool Enabled { get; set; }
        [Display(Name = "Açıklama")]
        public string Description { get; set; }



    }
}