using Microsoft.AspNetCore.Mvc;
using WebBooks.Models;
using WebBooks.Services;

namespace WebBooks.Controllers;

[ApiController]
[Route("api/users")]
public class UserController(IUserService service) : ControllerBase
{
    private readonly IUserService _service = service;
    
    [HttpGet]
    public async Task<IActionResult> GetUsers()
    {
        var users = await _service.GetUsers();
        return Ok(users);
    }
    [HttpGet("{id:length(24)}")]
    public async Task<IActionResult> GetUser(string id)
    {
        var user = await _service.GetUserById(id);
        if (user== null)
        {
            return NotFound();
        }
        return Ok(user);
    }
    [HttpPost]
    public async Task<IActionResult> CreateUser([FromBody] User user)
    {
        if (!ModelState.IsValid)
        {
            return BadRequest(ModelState);
        }

        await _service.CreateUser(user);
        return CreatedAtAction(nameof(GetUser), new { id = user.Id }, user);
    }
    [HttpPut("{id:length(24)}")]
    public async Task<IActionResult> UpdateUser(string id, [FromBody] User user)
    {
        if (!ModelState.IsValid)
        {
            return BadRequest(ModelState);
        }

        if (id != user.Id)
        {
            return BadRequest();
        }

        await _service.UpdateUser(id,user);
        return NoContent();
    }
    [HttpDelete("{id:length(24)}")]
    public async Task<IActionResult> DeleteUser(string id)
    {
        await _service.DeleteUser(id);
        return NoContent();
    }
}