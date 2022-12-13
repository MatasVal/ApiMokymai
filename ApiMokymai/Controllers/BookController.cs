using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ApiMokymai.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BookController : ControllerBase
    {
        List<Book> books = new List<Book> 
        { 
                new Book { Id = 1, Title = "Penkiu ziedu knyga", Author = "Miyamoto Musashi", Year = 1999 },
                new Book { Id = 2, Title = "Penkiolikos metu kapitonas", Author = "Jules Verne", Year = 2002 },
                new Book { Id = 3, Title = "Vilnius: savas ir svetimas", Author = "Laimonas Briedis", Year = 2005 },
                new Book { Id = 4, Title = "Tevas Braunas", Author = "Gilbert Keith Chesterton", Year = 2006 },
                new Book { Id = 5, Title = "Persian Fire", Author = "Tom Holland", Year = 2005 },
                new Book { Id = 6, Title = "Tylos zona", Author = "Stephen King", Year = 1979 },
                new Book { Id = 7, Title = "Krikstatevis", Author = "Mario Puzo", Year = 1969 },
                new Book { Id = 8, Title = "Man's Search for Meaning", Author = "Viktor E. Frankl", Year = 1946 },
                new Book { Id = 9, Title = "The Score Takes Care of Itself", Author = "Bill Walsh", Year = 2009 },
                new Book { Id = 10, Title = "Trys muskietininkai", Author = "Aleksandras Diuma", Year = 1844 }
        };

        [HttpGet]
        public List<Book> GetMyBooks()
        {
            return books;
        }

        [HttpGet("{id}")]
        public Book? GetById(int id)
        { 
            return books.FirstOrDefault(b => b.Id == id);
        }

        [HttpGet("pagalpavadinima/{title}")]
        public Book? GetByTitle(string title)
        {
            return books.FirstOrDefault(b => b.Title == title);
        }

        [HttpGet("pagalpavadinimairmetus")]
        public Book? GetByTitleAnYear(string title, int year)
        {
            return books.FirstOrDefault(b => b.Title == title && b.Year == year);
        }
    }
}
