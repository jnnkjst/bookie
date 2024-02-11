using DataAccess.Data;
using DataAccess.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Bookie.Controllers;

[ApiController]
[Route("[controller]")]
public class BookController : ControllerBase
{
    private readonly BookContext _bookContext;

    public BookController(BookContext bookContext)
    {
        _bookContext = bookContext;
    }

    [HttpGet]
    public async Task<IEnumerable<Book>> Get()
    {
        return await _bookContext.Books.AsQueryable().ToListAsync();
    }

    [HttpDelete]
    public async void Delete(Guid bookId)
    {
        var book = await _bookContext.FindAsync<Book>(bookId);

        if (book == null)
        {
            throw new Exception();
        }

        _bookContext.Books.Remove(book);
    }
}