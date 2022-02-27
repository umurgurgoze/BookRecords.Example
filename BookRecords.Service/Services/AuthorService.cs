using AutoMapper;
using BookRecords.Core;
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
    public class AuthorService : Service<Author>, IAuthorService
    {
        private readonly IAuthorRepository _authorRepository;
        private readonly IMapper _mapper;
        public AuthorService(IGenericRepository<Author> repository, IUnitOfWork unitOfWork, IAuthorRepository authorRepository, IMapper mapper) : base(repository, unitOfWork)
        {
            _authorRepository = authorRepository;
            _mapper = mapper;

        }
    }
}
