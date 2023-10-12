using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Task1CRUD.Model;
using Task1CRUD.Model.DB;

namespace Task1CRUD.Pages.CategoryManagement
{
    public class IndexModel : PageModel
    {
        private readonly Task1CRUD.Model.DB.CategoryDBContext _context;

        public IndexModel(Task1CRUD.Model.DB.CategoryDBContext context)
        {
            _context = context;
        }

        public IList<Category> Category { get;set; }

        public async Task OnGetAsync()
        {
            Category = await _context.Category.ToListAsync();
        }
    }
}
