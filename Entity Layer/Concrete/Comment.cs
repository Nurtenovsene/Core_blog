using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity_Layer.Concrete
{
   public class Comment
    {
        [Key]
        public int CommentID { get; set; }
        public String CommentUserName { get; set; }
        public String CommentTitle { get; set; }
        public String CommentContent { get; set; }
        public DateTime CommentConte { get; set; }
        public bool CommentStatus { get; set; }
        public int BlogID { get; set; }
        public Blog Blog{ get; set; }
    }
}
