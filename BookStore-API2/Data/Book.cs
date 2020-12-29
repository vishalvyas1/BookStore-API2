﻿using System.ComponentModel.DataAnnotations.Schema;

namespace BookStore_API2.Data
{
    [Table ("Books")]
    public class Book
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public int? Year { get; set; }
        public string Isbn { get; set; }
        public string Summary { get; set; }
        public string Image { get; set; }
        public int? AuthorId { get; set; }
        public double? Price { get; set; }

        public virtual Author Author { get; set; }
    }
}