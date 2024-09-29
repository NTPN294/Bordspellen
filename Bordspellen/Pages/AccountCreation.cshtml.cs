using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Bordspellen.Pages
{
    public class AccountCreationModel : PageModel
    {

        public List<String> Genders { get; set; }
        public void OnGet()
        {
            Genders = new List<String>();
            foreach (var gender in Enum.GetValues(typeof(Gender)))
            {
                Genders.Add(gender.ToString());
            }
        }


    }
}
