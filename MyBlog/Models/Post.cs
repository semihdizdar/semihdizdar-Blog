using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace MyBlog.Models
{

    [Table("Post")]
    public class Post
    {

        public Post()
        {
            PostDate = DateTime.Now;
        }

        [Key]
        public int PostID { get; set; }

        [Display(Name ="Başlık")]
        [Required]
        public string Title { get; set; }

        [Display(Name = "Tarih")]
        public DateTime PostDate { get; set; }

        [Display(Name = "İçerik Yazısı")]
        public string Content { get; set; }
        [Display(Name = "Kategori")]
        public int CategoryID { get; set; }

        [Display(Name = "Tag")]
        public string Tags { get; set; }

        [Display(Name = "Alt konu başlığı")]
        public string ShortIntro { get; set; }

        [Display(Name = "Url Uzantısı")]
        public string UrlExtension { get; set; }

        [Display(Name = "Yayınla")]
        public bool Publish { get; set; }

        [Display(Name = "Yorumları Etkinleştir")]
        public bool CommentsEnabled { get; set; }

        [ForeignKey("CategoryID")]
        [Display(Name = "Kategori")]
        public Category PostCategory { get; set; }

        public ICollection<Comment> Comments { get; set; }


    }
}