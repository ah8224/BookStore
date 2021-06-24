using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookStore.Models
{
    interface IBookRepository
    {
        bool AddBook(Book model);
    }
}
