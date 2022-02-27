using BookRecords.Core;
using BookRecords.Core.DTOs;
using BookRecords.Core.Services;
using Microsoft.AspNetCore.Mvc;

namespace BookRecords.Web.Controllers
{
    public class AuthorController : Controller
    {
        private IAuthorService _service;
        public AuthorController(IAuthorService service)
        {
            _service = service;
        }
        public IActionResult Update(int id)
        {
            var value = _service.GetById(id);
            return View("Update", value);
        }
        [HttpPost]
        public IActionResult Update(AuthorDto author)
        {
           
            var value = _service.GetById(author.Id);
            value.Name = author.Name;
            _service.Update(value);
            return RedirectToAction("Index", "Admin");
        }
    }
}
