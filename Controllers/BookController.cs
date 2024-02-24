using Microsoft.AspNetCore.Mvc;
using WebBooks.Models;
using WebBooks.Services;

namespace WebBooks.Controllers;

[ApiController]
[Route("api/[controller]")]
public class BookController(WebBookService bookService) : ControllerBase
{
    private readonly WebBookService _bookService = bookService;
    

    [HttpGet]
    public async Task<List<Book>> Get() =>
        await _bookService.GetAsync();

  //  public async Task<string> Get() => await new Task<string>(() => "Hello World");
}