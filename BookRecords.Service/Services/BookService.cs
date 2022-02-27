using AutoMapper;
using BookRecords.Core;
using BookRecords.Core.DTOs;
using BookRecords.Core.Repositories;
using BookRecords.Core.Services;
using BookRecords.Core.UnitOfWork;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookRecords.Service.Services
{
    public class BookService : Service<Book>, IBookService
    {
        private readonly IBookRepository _bookRepository;
        private readonly IMapper _mapper;
        public BookService(IGenericRepository<Book> repository, IUnitOfWork unitOfWork, IBookRepository bookRepository, IMapper mapper) : base(repository, unitOfWork)
        {
            _bookRepository = bookRepository;
            _mapper = mapper;

        }        

        public List<BookWithAuthorDto> GetBookWithAuthor()
        {
            var list = _bookRepository.GetBookWithAuthor();
            var mappedList = _mapper.Map<List<BookWithAuthorDto>>(list);
            return mappedList;
        }        
    }
}
