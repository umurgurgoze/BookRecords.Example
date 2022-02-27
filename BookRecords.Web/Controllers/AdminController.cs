using AutoMapper;
using BookRecords.Core;
using BookRecords.Core.DTOs;
using BookRecords.Core.Services;
using Microsoft.AspNetCore.Mvc;

namespace BookRecords.Web.Controllers
{
    public class AdminController : Controller
    {
        private readonly IBookService _service;
        private readonly IMapper _mapper;
        private readonly IAuthorService _authorService;

        public AdminController(IBookService service, IMapper mapper, IAuthorService authorService)
        {
            _service = service;
            _mapper = mapper;
            _authorService = authorService;
        }

        public IActionResult Index()
        {
            var books = _service.GetBookWithAuthor();
            return View(books);
        }
        public IActionResult Add()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Add(Book book)
        {
            _service.Insert(book);
            return RedirectToAction("Index");
        }
        public IActionResult Delete(int id)
        {
            var delete = _service.GetById(id);
            _service.Delete(delete);
            return RedirectToAction("Index");
        }        
    }
}
