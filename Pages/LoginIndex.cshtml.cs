using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Task1CRUD.Pages
{
    public class LoginIndexModel : PageModel
    {
        [BindProperty]
        public string Username { get; set; }
        [BindProperty]
        public string Password { get; set; }
        public string msg;
        public void OnGet()
        {
        }

        public IActionResult OnGetLogout()
        {
            HttpContext.Session.Remove("username");
            return Page();
        }

        public IActionResult OnPost()
        {
            if (Username.Equals("Mohan") && Password.Equals("abc")|| Username.Equals("Geeta") && Password.Equals("abc@123")) 
            {
                HttpContext.Session.SetString("username", Username);
                return RedirectToPage("Students/Index");
            }
            else {
                msg = "Invalid";
                return Page();

            }
        }
    }
}
