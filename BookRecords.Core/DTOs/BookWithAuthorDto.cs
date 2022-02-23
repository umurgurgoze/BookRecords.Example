using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookRecords.Core.DTOs
{
    public class BookWithAuthorDto : BookDto
    {
        public AuthorDto Author { get; set; }
    }
}
