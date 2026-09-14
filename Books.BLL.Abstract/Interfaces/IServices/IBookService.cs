using Books.BLL.Abstract.Models;

namespace Books.BLL.Abstract.Interfaces.IServices;

public interface IBookService
{
    List<BookModel> GetBooks();
}