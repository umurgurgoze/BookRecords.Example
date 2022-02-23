using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookRecords.Core
{
    public class Author : BaseEntity
    {        
        public ICollection<Book> Books { get; set; }
        
    }
}
