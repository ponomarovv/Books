using Books.DAL.Abstract.Models;

namespace Books.DAL.Abstract.Interfaces;

public interface IBookRepository
{
    List<Book> GetBooksFromXml(string path);
}