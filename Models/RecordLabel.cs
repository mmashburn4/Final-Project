using System;
using System.Collections.Generic;

namespace Final_Project.Models{
    public class RecordLabel{
        public int RecordLabelID {get; set;}
        public string Name {get; set;}
        public string Description {get; set;}
        public List<Artist> Artists {get; set;}
    }
}