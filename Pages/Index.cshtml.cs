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

        public IndexModel(Context context, ILogger<IndexModel> logger)
        {
            _context = context;
            _logger = logger;
        }

        public void OnGet()
        {
            RecordLabels = _context.RecordLabels.ToList();
        }
    }
}
