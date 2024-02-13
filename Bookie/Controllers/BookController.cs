using Bookie.BackupSystems;
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
    private readonly FileBackup _fileBackup;

    public BookController(BookContext bookContext)
    {
        _bookContext = bookContext;
        _fileBackup = new FileBackup();
    }

    [HttpGet]
    public async Task<IEnumerable<Book>> Get()
    {
        return await _bookContext.Books.AsQueryable().ToListAsync();
    }

    [HttpDelete]
    public async Task<IActionResult> Delete(Guid bookId)
    {
        var book = await _bookContext.Books.FindAsync(bookId);

        if (book == null)
        {
            return StatusCode(500, $"Internal server error");
        }

        _bookContext.Books.Remove(book);
        await _bookContext.SaveChangesAsync();

        return Ok();
    }

    [HttpGet]
    [Route("Backup")]
    public async Task<IActionResult> GetBackup(Guid bookId)
    {
        var book = await _bookContext.Books.FindAsync(bookId);

        if (book == null)
        {
            return StatusCode(500, $"Internal server error");
        }

        try
        {
            _fileBackup.BackupBook(book);
            return Ok();
        }
        catch (Exception ex)
        {
            return StatusCode(500, $"Internal server error: {ex.Message}");
        }
    }
}