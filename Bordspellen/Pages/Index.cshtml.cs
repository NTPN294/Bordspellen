using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Bordspellen.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;

        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }


        public List<Event> Events { get; set; }
        public void OnGet()
        {
            Events = new List<Event>
            {
              new Event(1, "Alice", DateTime.Now.AddDays(5)),
new Event(2, "Bob", DateTime.Now.AddDays(2)),
new Event(3, "Charlie", DateTime.Now.AddDays(1)),
new Event(4, "David", DateTime.Now.AddDays(-1)),
new Event(5, "Eve", DateTime.Now.AddDays(-2)),
new Event(6, "f", DateTime.Now.AddDays(-3)),


            };
        }
    }
}
