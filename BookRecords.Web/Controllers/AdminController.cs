using BookRecords.Core;
using BookRecords.Core.Services;
using BookRecords.Repository;
using Microsoft.AspNetCore.Mvc;

namespace BookRecords.Web.Controllers
{
    public class AdminController : Controller
    {
        private readonly IBookService _service;        

        public AdminController(IBookService service)
        {
            _service = service;           
        }
        
        public IActionResult Index()
        {     
            var books = _service.GetBookWithAuthor();
            return View(books);
        }
    }
}
