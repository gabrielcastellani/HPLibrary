using HPLibrary.Core.Contracts;
using Refit;

namespace HPLibrary.Core.Api
{
    internal interface IPotterApi
    {
        [Get("/{lang}/books")]
        Task<Book[]> GetBooks(string lang);
    }
}
