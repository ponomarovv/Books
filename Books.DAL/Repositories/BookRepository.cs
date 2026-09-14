using Books.DAL.Abstract.Interfaces;
using Books.DAL.Abstract.Models;

namespace Books.DAL.Repositories;

public class BookRepository : IBookRepository
{
    public List<Book> GetBooksFromXml(string path)
    {
        throw new NotImplementedException();
    }
}