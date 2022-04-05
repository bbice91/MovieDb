using System;

namespace MovieDatabase.Models
{
    public class MovieViewModel
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public int Genre { get; set; }
        public double Runtime { get; set; }
    }
}
