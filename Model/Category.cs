using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
/*using System.Drawing;
using System.Drawing.Imaging;*/

namespace Task1CRUD.Model
{
    public class Category
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }

        public byte[] Image  { get; set; }
    }
}
