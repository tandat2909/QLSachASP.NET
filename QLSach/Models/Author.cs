using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace QLSach.Models
{
    public class Author
    {
      
        public virtual int AuthorId { get; set; }
        [Display(Name="Ten Tac Gia")]
        public virtual string Name { set; get; }

        public virtual List<Books> Books { set; get; }

    }
}