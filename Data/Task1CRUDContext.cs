using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Task1CRUD.Model;

namespace Task1CRUD.Data
{
    public class Task1CRUDContext : DbContext
    {
        public Task1CRUDContext (DbContextOptions<Task1CRUDContext> options)
            : base(options)
        {
        }

        public DbSet<Task1CRUD.Model.Student> Student { get; set; }

        public DbSet<Task1CRUD.Model.Category> Category { get; set; }
    }
}
