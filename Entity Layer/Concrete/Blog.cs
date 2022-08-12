using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity_Layer.Concrete
{
  public  class Blog
    {
        [Key]
        public int BlogID { get; set; }
        public String BlogTitle { get; set; }
        public String BlogContent { get; set; }
        public String BlogThumbnailImage { get; set; }
        public String BlogImage { get; set; }
        public DateTime CreateDate{ get; set; }
        public bool BlogStatus{ get; set; }
        public int CategoryID { get; set; }
        public Category Category { get; set; }
        public List<Comment> Comments { get; set; }
    }
}
