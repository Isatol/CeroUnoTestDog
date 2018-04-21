using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using TestMysql2.Data.Context;
using TestMysql2.Data.Models;

namespace TestMysql2.Pages
{
    public class IndexModel : PageModel
    {

        private PetsContext _context { get; set; }

        public List<Dog> Dogs { get; set; }

        [BindProperty]
        public Dog Dog { get; set; }

    public IndexModel(PetsContext context) {
      _context = context;
    }
        public void OnGet()
        {
          Dogs = _context.Dogs.ToList();      
        }
    }
}
