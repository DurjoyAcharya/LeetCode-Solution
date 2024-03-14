using CRUDMongo.models;
using CRUDMongo.Services;
using Microsoft.AspNetCore.Mvc;

namespace CRUDMongo.Controllers;

public class MoviesController(MoviesService moviesService) : ControllerBase
{
    
    [HttpGet]
    public async Task<List<Movies>> GetAll() =>
        await moviesService.GetAsync();
    
    [HttpGet("{id:length(24)}")]
    public async Task<ActionResult<Movies>> Get(string id)
    {
        var movies = await moviesService.GetAsync(id);

        if (movies is null)
        {
            return NotFound();
        }
        return movies;
    }
    [HttpPost]
    public async Task<IActionResult> Post(Movies newMovies)
    {
        await moviesService.CreateAsync(newMovies);

        return CreatedAtAction(nameof(Get), new { id = newMovies.Id }, newMovies);
    }
    [HttpPut("{id:length(24)}")]
    public async Task<IActionResult> Update(string id, Movies updatedMovies)
    {
        var movies = await moviesService.GetAsync(id);

        if (movies is null)
        {
            return NotFound();
        }
        updatedMovies.Id = movies.Id;
        await moviesService.UpdateAsync(id, updatedMovies);
        return NoContent();
    }
    [HttpDelete("{id:length(24)}")]
    public async Task<IActionResult> Delete(string id)
    {
        var book = await moviesService.GetAsync(id);

        if (book is null)
        {
            return NotFound();
        }
        await moviesService.RemoveAsync(id);
        return NoContent();
    }
}