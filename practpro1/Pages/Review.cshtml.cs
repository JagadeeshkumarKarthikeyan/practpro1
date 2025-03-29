using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using practpro1.model;

namespace practpro1.Pages
{

    public class ReviewModel : PageModel
    {
        public DatabaseContext _databasecontext;
        public ReviewModel()
        {
            _databasecontext = new DatabaseContext();

        }

        [BindProperty]
        public getmodel _review { get; set; }


        public void OnGet()
        {
        }

        public void OnPost()
        {
            {
                _databasecontext.review.Add(_review);
                _databasecontext.SaveChanges();
            }
        }

    }
}

