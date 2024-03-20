using System.ComponentModel.DataAnnotations;
using System.Net;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Security.Pages.Account;

public class LoginPage : PageModel
{
    [BindProperty]
    public Credential Credential { get; set; }
    public void OnGet()
    {

    }
    public void OnPost()
    {
        Console.WriteLine(this.Credential.UserName);
        Console.WriteLine(this.Credential.Password);
    }
   

    
}


public class Credential
{
    [Required]
    public string? UserName { get; set; }
    [Required]
    [DataType(DataType.Password)]
    public string? Password { get; set; }
    public DateTime Now { get; set; } = DateTime.Now;
}