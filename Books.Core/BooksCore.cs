using Books.BLL.Abstract.Models;
using Microsoft.Extensions.DependencyInjection;

namespace Books.Core;

public class BooksCore
{
    public static List<BookModel> Books = new();
    
    public void RegisterAllDi(ref IServiceCollection  services)
    {
        
    }
}