using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace WebApplication1.Pages
{
    public class LoginModel : PageModel
    {
        public string Username { get; set; }
        public string Password { get; set; }
        public void OnGet()
        {
        }
        public IActionResult OnPost(string username, string password)
        {
            string user = username;
            string pass = password;
            if(user == "mai" && pass =="123456") {
                return new RedirectToPageResult("Welcome");
            }
            return RedirectToPage("Login");
        }
    }
}
