using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace QLSach.Models
{
    public class Books
    {
        public virtual int BooksId { set; get; }

        public virtual int PublishingId { set; get; }

        public virtual int AuthorId { set; get; }

        public virtual string Title { get; set; }

        public virtual decimal Price { get; set; }

        public virtual int PubYear { set; get; }

        public Author Author { get; set; }

        public Publishing Publishing { get; set; }
    }
}