using Microsoft.AspNetCore.Mvc;
using WebBooks.Models;
using WebBooks.Services;

namespace WebBooks.Controllers;

[ApiController]
[Route("api/books")]
public class BookController(WebBookService bookService) : ControllerBase
{
    private readonly WebBookService _bookService = bookService;
    

    [HttpGet]
    public async Task<List<Book>> Get() =>
        await _bookService.GetAsync();

    [HttpGet("{id:length(24)}")]
    public async Task<ActionResult<Book>> Get(string id)
    {
        var book = await _bookService.GetSpecificAsync(id);
        if (book==null)
        {
            return NotFound();
        }
        return book;
    }
    [HttpPost]
    public async Task<IActionResult> Post(Book newBooks)
    {
        await _bookService.CreateAsync(newBooks);
        return CreatedAtAction(nameof(Get), new { id = newBooks.Id },newBooks);
    }

    [HttpPut("{id:length(24)}")]
    public async Task<IActionResult> Update(string id, Book newBooks)
    {
        var book = await _bookService.GetSpecificAsync(id);
        if (book == null) return NotFound();
        newBooks.Id = book.Id;
        await _bookService.UpdateAsync(id, newBooks);
        return NoContent();
    }

    [HttpDelete("{id:length(24)}")]
    public async Task<IActionResult> Delete(string id)
    {
        var book=await _bookService.GetSpecificAsync(id);
        if (book == null) return NotFound();
        await _bookService.RemoveOneAsync(id);
        return NoContent();
    }


}