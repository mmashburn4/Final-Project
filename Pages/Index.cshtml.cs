using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using Microsoft.EntityFrameworkCore;
using Final_Project.Models;

namespace Final_Project.Pages
{
    public class IndexModel : PageModel
    {
        private readonly Context _context;
        private readonly ILogger<IndexModel> _logger;
        public List<RecordLabel> RecordLabels {get; set;}
        public List<Artist> Artists {get; set;}
        [BindProperty(SupportsGet = true)]
        public string CurrentSort {get; set;}

        public IndexModel(Context context, ILogger<IndexModel> logger)
        {
            _context = context;
            _logger = logger;
        }

        public void OnGet()
        {
            RecordLabels = _context.RecordLabels.ToList();
            var query = _context.Artists.Select(a => a);
            switch(CurrentSort)
            {
                case "name_asc":
                    query = query.OrderBy(a => a.Name);
                    break;
                case "name_desc":
                    query = query.OrderByDescending(a => a.Name);
                    break;
                case "genre":
                    query = query.OrderBy(a => a.Genre);
                    break;
                case "age":
                    query = query.OrderBy(a => a.Age);
                    break;
                case "recordLabel":
                    query = query.OrderBy(a => a.RecordLabel);
                    break;
            }
            Artists = _context.Artists.ToList();
        }
    }
}
