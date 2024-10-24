using HPLibrary.Core.Abstracts;
using HPLibrary.Core.Contracts;

namespace HPLibrary.Core.Services
{
    public interface IPotterService
    {
        Result<Book[]> GetBooks();
    }
}
