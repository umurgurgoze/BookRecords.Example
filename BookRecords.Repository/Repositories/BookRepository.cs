using BookRecords.Core;
using BookRecords.Core.Repositories;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookRecords.Repository.Repositories
{
    public class BookRepository : GenericRepository<Book>, IBookRepository
    {
        public BookRepository(AppDbContext context) : base(context)
        {
        }

        public List<Book> GetBookWithAuthor()
        {
            return _context.Books.Include(x=> x.Author).ToList();
        }
    }
}
