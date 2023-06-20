using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MovieApp.Movies
{
    public class Movie
    {
        public int Id { get; set; }
        public int CategoryId { get; set; }
        public string MovieName { get; set; }
        public int MovieYear { get; set; }
        public string MoviePicture { get; set; }
        public string Description { get; set; }
        public string AuthorName { get; set; }

    }
}