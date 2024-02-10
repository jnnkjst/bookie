using DataAccess.Models;
using Microsoft.AspNetCore.Mvc;

namespace Bookie.Controllers;

[ApiController]
[Route("[controller]")]
public class BookController : ControllerBase
{
    private readonly ILogger<BookController> _logger;

    public BookController(ILogger<BookController> logger)
    {
        _logger = logger;
    }

    [HttpGet]
    public IEnumerable<Book> Get()
    {
        throw new Exception();
    }
}