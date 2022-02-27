using BookRecords.Core;
using BookRecords.Core.Services;
using Microsoft.AspNetCore.Mvc;

namespace BookRecords.Web.Controllers
{
    public class BookController : Controller
    {
        private IBookService _service;
        public BookController(IBookService service)
        {
            _service = service;            
        }
        public IActionResult Update(int id)
        {
            var value = _service.GetById(id);
            return View("Update",value);
        }
        [HttpPost]
        public IActionResult Update(Book book)
        {
            var value = _service.GetById(book.Id);
            value.Id = book.Id;
            value.Name = book.Name;
            _service.Update(value);
            return RedirectToAction("Index","Admin");
        }

    }
}
