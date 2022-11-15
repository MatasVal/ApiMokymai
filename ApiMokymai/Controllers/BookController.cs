using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ApiMokymai.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BookController : ControllerBase
    {
        [HttpGet]
        public List<Book> GetMyBooks()
        {
            return new List<Book>
            {
                new Book{Id = 1, Pavadinimas= "Ziedu valdovas 1", Autorius = "R.R.Tolkien", LeidybosMetai = 1999},
                new Book{Id = 2, Pavadinimas= "Ziedu valdovas 2", Autorius = "R.R.Tolkien", LeidybosMetai = 2002},
                new Book{Id = 3, Pavadinimas= "Ziedu valdovas 3", Autorius = "R.R.Tolkien", LeidybosMetai = 2005},
                new Book{Id = 4, Pavadinimas= "Tevas Braunas", Autorius = "K. Kazkoks", LeidybosMetai = 2006},
                new Book{Id = 5, Pavadinimas= "Harka", Autorius = "N. Nepamenu", LeidybosMetai = 2007},
                new Book{Id = 6, Pavadinimas= "Tylos zona", Autorius = "N. Nezinau", LeidybosMetai = 2015},
                new Book{Id = 7, Pavadinimas= "Krikstatevis", Autorius = "V. Neatsimenu", LeidybosMetai = 2020},
                new Book{Id = 8, Pavadinimas= "Vienas muskietininkas", Autorius = "P. Primirsau", LeidybosMetai = 1995},
                new Book{Id = 9, Pavadinimas= "Du muskietininkai", Autorius = "I. Iskritoisgalvos", LeidybosMetai = 2001},
                new Book{Id = 10, Pavadinimas= "Trys muskietininkai", Autorius = "A. Diuma", LeidybosMetai = 2000}                
            };
        }

        [HttpGet("knygos/{id}")]
        public List<Person> GetMyBooks()
        { return ; }
    }
}
