using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookStore.Models
{
    public class BookRepository : IBookRepository
    {
        BookDbContext _BookDbContext = null;
        public BookRepository(BookDbContext obj)
        {
            _BookDbContext = obj;
        }
        public bool AddBook(Book model)
        {
            try
            {
                _BookDbContext.Books.Add(model);
                _BookDbContext.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}
