using Books.BLL.Abstract.Interfaces.IServices;
using Books.BLL.Abstract.Models;

namespace Books.BLL.Services;

public class BookService : IBookService
{
    private readonly string _input;

    public BookService(string input)
    {
        _input = input;
    }
    public List<BookModel> GetBooks()
    {
        throw new NotImplementedException();
    }

    public List<BookModel> SortBooks(string sortyBy, string sortOrder)
    {
        throw new NotImplementedException();
    }

    public bool BookSearch(string input)
    {
        // todo basic search 
        
        throw new NotImplementedException();
    }
}