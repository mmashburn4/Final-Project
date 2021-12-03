using System;
using System.Collections.Generic;

namespace Final_Project.Models{
    public class Artist{
        public int ArtistID {get; set;}
        public string Name {get; set;}
        public string Genre {get; set;}
        public int Age {get; set;}
        public int RecordLabelID {get; set;}
        public RecordLabel RecordLabel {get; set;}
    }
}