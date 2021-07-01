using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Serviceone.Models
{
    public class Paitent
    {
        public int PaitentId { get; set; }
        public string PaitentName { get; set; }
        public string Disease { get; set; }
    }

    public class PaitentDb : List<Paitent>
    {
        public PaitentDb()
        {
            Add(new Paitent() { PaitentId = 1, PaitentName = "Sushant", Disease = "pneumonia" });
            Add(new Paitent() { PaitentId = 2, PaitentName = "Popatlal", Disease = "Fever" });
        }
    }
}
