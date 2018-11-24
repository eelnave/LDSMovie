using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;

namespace LDSMovie.Models
{
    public class MovieGenreViewModel
    {
        public List<MvcMovie.Models.Movie> Movies;
        public SelectList Genres;
        public string MovieGenre { get; set; }
        public string SearchString { get; set; }
    }
}
