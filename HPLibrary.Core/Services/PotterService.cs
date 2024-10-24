using HPLibrary.Core.Abstracts;
using HPLibrary.Core.Api;
using HPLibrary.Core.Contracts;
using Microsoft.Extensions.Logging;
using Refit;

namespace HPLibrary.Core.Services
{
    public sealed class PotterService : IPotterService
    {
        private readonly IPotterApi _potterApi;
        private readonly ILogger<PotterService> _logger;

        public PotterService(ILoggerFactory loggerFactory)
        {
            _logger = loggerFactory.CreateLogger<PotterService>();
            _potterApi = RestService.For<IPotterApi>("https://potterapi-fedeperin.vercel.app/");
        }

        public Result<Book[]> GetBooks()
        {
            var books = _potterApi.GetBooks("en").GetAwaiter().GetResult();
            return Result<Book[]>.Success(books);
        }
    }
}
