using System.ComponentModel.DataAnnotations;
using System.Diagnostics;
using System.Net;
using System.Security.Claims;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.VisualBasic;

namespace Security.Pages.Account;

public class LoginPage : PageModel
{
    [BindProperty]
    public Credential Credential { get; set; } = null!;

    public void OnGet()
    {

    }
    public async Task<IActionResult> OnPostAsync()
    {
        if (!ModelState.IsValid) return Page();
        if (Credential.UserName!.Equals("admin")&& Credential.Password!.Equals("12345"))
        {

            var claims = new List<Claim>
            {
                new Claim(ClaimTypes.Name, "admin"), 
                new Claim(ClaimTypes.Email, "da-durjoy@outlook.com")
            };
            var identify = new ClaimsIdentity(claims,"MyCookie");
            var claimsPrincipal = new ClaimsPrincipal(identify);
            await HttpContext.SignInAsync("MyCookieAuth", claimsPrincipal);
            return RedirectToPage("/Index");
        }
        return Page();
    }
}

public class Credential
{
    [Required]
    public string? UserName { get; set; }
    [Required]
    [DataType(DataType.Password)]
    public string? Password { get; init; }
    public DateTime Now { get; set; } = DateTime.Now;
}