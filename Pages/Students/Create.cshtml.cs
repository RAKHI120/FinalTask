using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Task1CRUD.Data;
using Task1CRUD.Model;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using System.IO;

namespace Task1CRUD.Pages.Students
{
    public class CreateModel : PageModel
    {
        private readonly Task1CRUD.Data.Task1CRUDContext _context;

        public CreateModel(Task1CRUD.Data.Task1CRUDContext context)
        {
            _context = context;
        }
        

      

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public Student Student { get; set; }

        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Student.Add(Student);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }

        //[Obsolete]
        //private IHostingEnvironment ihostingEnvironment;

        //public string FileName { get; set; }

        //[Obsolete]
        //public CreateModel(IHostingEnvironment ihostingEnvironment)
        //{
        //    this.ihostingEnvironment = ihostingEnvironment;
        //}

         //[Obsolete]
        //public void OnPost(IFormFile photo)
        //{
        //    var path = Path.Combine(ihostingEnvironment.WebRootPath, "images", photo.FileName);
        //    var stream = new FileStream(path, FileMode.Create);
        //    photo.CopyToAsync(stream);
        //    FileName = photo.FileName;
        //}
    }
}
