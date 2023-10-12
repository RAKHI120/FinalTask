using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Task1CRUD.Data;
using Task1CRUD.Model;

namespace Task1CRUD.Pages.Students
{
    public class IndexModel : PageModel
    {

        public string FileName { get; set; }
        private readonly Task1CRUD.Data.Task1CRUDContext _context;
        public string Username { get; set; }
        public IndexModel(Task1CRUD.Data.Task1CRUDContext context)
        {
            _context = context;
        }

        public IList<Student> Student { get;set; }

        public async Task OnGetAsync()
        {
           // Username = HttpContext.Session.GetString("username");
            Student = await _context.Student.ToListAsync();
        }

        //public IActionResult OnPostLogout()
        //{
        //    // Perform logout actions, such as clearing the session
        //    HttpContext.Session.Clear();

        //    // Redirect to a page after logout
        //    return RedirectToPage("/LoginIndex");
        //}
        //public async Task<IActionResult> Logout()
        //{
        //    await HttpContext.SignOutAsync(CookieAuthenticationDefaults.AuthenticationScheme);
        //    return RedirectToPage("LoginIndex");
        
        //}
       
    }
}
