using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MovieApp.MovieComments
{
    public class MovieComment
    {
        public int Id { get; set; }
        public string UserName { get; set; }
        public int Scor { get; set; }
        public int MovieId { get; set; }
    }
}