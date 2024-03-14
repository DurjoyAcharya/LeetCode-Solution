using System.ComponentModel.DataAnnotations;

namespace CRUDAppUsingASPCoreWebAPI.Models;

public class Books
{
    
    public string Id { get; set; }
    [Required]
    public string BookName { get; set; } = null!;
    [Required]
    public decimal Price { get; set; }
    [Required]
    public string Category { get; set; }= null!;
    [Required]
    public string Author { get; set; }= null!;
}