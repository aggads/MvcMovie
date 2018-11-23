using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace MvcMovie.Models
{
    public class SerieGenreViewModel
    {
        public List<Serie> Series;
        public SelectList Genres;
        public string SerieGenre { get; set; }
        public string SearchString { get; set; }
    }
}
