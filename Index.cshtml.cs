using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Movies.Pages;


namespace Movies.Pages
{
}
public class IndexModel : PageModel
{

    public List <Movies1> Movies { get; set; } = new List <Movies1>();
    public string MainTitle { get; set; }
    public string[] Movies1 { get; set; }

    public void OnGet()
    {

        Movies.Add(new Movies1
        {
            MovieId = "j235z",
            Title = "Booty Call",
            Director = "Jamiee Foxx",
            Rating = 87.5
        });
        Movies.Add(new Movies1
        {
            MovieId = "2hj3",
            Title = "Black Panther",
            Director = "Kenyatta Hayes",
            Rating = 2.3
        });
        Movies.Add(new Movies1
        {
            MovieId = "234hjke",
            Title = "Coming To America 2",
            Director = "Charlie Murphy",
            Rating = 90.3
        });

        MainTitle = "Movie Time!";
        Movies1 = new string[] { "Booty Call", "Black Panther", "Coming To America 2" };
            

    }
}
