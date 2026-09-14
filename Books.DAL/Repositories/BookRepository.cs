using Books.DAL.Abstract.Interfaces;
using Books.DAL.Abstract.Models;

namespace Books.DAL.Repositories;

public class BookRepository : IBookRepository
{
    public List<Book> GetBooksFromXml(string path)
    {
        // todo use xml serializer
        // todo user Parallel.ForEach
        
        throw new NotImplementedException();
    }

    public bool SaveBooksToXml(string path, List<Book> books)
    {
        // todo use xml serializer
        
        throw new NotImplementedException();
    }
}