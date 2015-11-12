using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace BookStore.Models {
    public class Book {
        public string Title { get; set; }
        public string Author { get; set; }
        public double Price { get; set; }
        public DateTime PublicationDate { get; set; }
        public int UniqueNumber { get; set; }

    }
}