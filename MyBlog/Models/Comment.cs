using System.ComponentModel.DataAnnotations.Schema;

namespace MyBlog.Models
{

    [Table("Comment")]
    public class Comment
    {

        public int CommentID { get; set; }


        public int PostID { get; set; }

        public string Name { get; set; }

        public string WebSite { get; set; }

        public string Message { get; set; }

        public int Up { get; set; }

        public int Down { get; set; }

        [NotMapped]
        public int Vote { get { return Up - Down; } }


    }
}