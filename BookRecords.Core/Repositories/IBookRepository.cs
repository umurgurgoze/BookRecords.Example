using BookRecords.Core.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookRecords.Core.Repositories
{
    public interface IBookRepository:IGenericRepository<Book>
    {
        List<Book> GetBookWithAuthor();
            

    }
}
