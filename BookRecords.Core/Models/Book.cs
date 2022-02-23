using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookRecords.Core
{
    public class Book : BaseEntity
    {
        public int AuthorId { get; set; }
        public Author Author { get; set; }
    }
}
