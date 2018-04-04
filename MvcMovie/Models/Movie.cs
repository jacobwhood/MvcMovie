using System;

namespace MvcMovie.Models
{
    public class Movie
    {
        // ID is required as primary key in database
        public int ID { get; set; }
        public string Title { get; set; }
        public DateTime ReleaseDate { get; set; }
        public string Genre { get; set; }
        public decimal Price { get; set; }
    }
}