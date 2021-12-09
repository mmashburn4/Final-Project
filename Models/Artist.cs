using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Final_Project.Models;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace Final_Project.Models{
    public class Artist{
        public int ArtistID {get; set;}
        [BindProperty(SupportsGet = true)]
        public string Name {get; set;}
        [BindProperty(SupportsGet = true)]
        public string Genre {get; set;}
        [BindProperty(SupportsGet = true)]
        public int Age {get; set;}
        public int RecordLabelID {get; set;}
        public RecordLabel RecordLabel {get; set;}
    }
}