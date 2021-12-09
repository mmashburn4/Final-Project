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
    public class WarnerModel : PageModel
    {
        private readonly Context _context;
        private readonly ILogger<PrivacyModel> _logger;
        public List<Artist> Artists {get; set;}
        public List<RecordLabel> RecordLabels {get; set;}

        public WarnerModel(Context context, ILogger<PrivacyModel> logger)
        {
            _context = context;
            _logger = logger;
        }

        public void OnGet()
        {
            RecordLabels = _context.RecordLabels.ToList();
            Artists = _context.Artists.ToList();
        }
    }
}