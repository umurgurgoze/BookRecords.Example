using BookRecords.Core.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookRecords.Core.Services
{
    public interface IBookService : IService<Book>
    {
        List<BookWithAuthorDto> GetBookWithAuthor();
    }
}
