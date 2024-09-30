using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Bordspellen.Pages
{
    public class SearchModel : PageModel
    {
        public EventRepo EventRepo { get; set; }
        public List<String> Genres { get; set; }
        public void OnGet()
        {
            EventRepo = new EventRepo();
            Genres = new List<String>();
            foreach (var genre in Enum.GetValues(typeof(Genre)))
            {
                Genres.Add(genre.ToString());
            }
        }
    }
}
