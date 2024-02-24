using Microsoft.AspNetCore.Mvc;
using WebBooks.Models;
using WebBooks.Services;

namespace WebBooks.Controllers;

[ApiController]
[Route("api/orders")]
public class OrderController(IOrderService service): ControllerBase
{
    private readonly IOrderService _service = service;
    [HttpGet]
    public async Task<IActionResult> GetProducts()
    {
        var orders = await _service.GetOrders();
        return Ok(orders);
    }
    [HttpGet("{id:length(24)}")]
    public async Task<IActionResult> GetProduct(string id)
    {
        var order = await _service.GetOrderById(id);
        if (order== null)
        {
            return NotFound();
        }
        return Ok(order);
    }
    [HttpPost]
    public async Task<IActionResult> CreateProduct([FromBody] Order product)
    {
        if (!ModelState.IsValid)
        {
            return BadRequest(ModelState);
        }

        await _service.CreateOrder(product);
        return CreatedAtAction(nameof(GetProduct), new { id = product.Id }, product);
    }
    [HttpPut("{id:length(24)}")]
    public async Task<IActionResult> UpdateProduct(string id, [FromBody] Order product)
    {
        if (!ModelState.IsValid)
        {
            return BadRequest(ModelState);
        }

        if (id != product.Id)
        {
            return BadRequest();
        }

        await _service.UpdateOrder(id,product);
        return NoContent();
    }
    [HttpDelete("{id:length(24)}")]
    public async Task<IActionResult> DeleteProduct(string id)
    {
        await _service.DeleteOrder(id);
        return NoContent();
    }
}