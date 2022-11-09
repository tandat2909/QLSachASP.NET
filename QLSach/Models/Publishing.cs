using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace QLSach.Models
{
    public class Publishing
    {
        public virtual int PublishingId { get; set; }

        public virtual string Name { set; get; }

        public virtual List<Books> Books { set; get; }


    }
}