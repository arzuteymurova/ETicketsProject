using Entities.Concrete;

namespace MvcWebUI.Models
{
    public class MovieViewModel
    {
        public Movie Movie { get; set; }
        public List<Movie> Movies { get; set; }
    }
}
