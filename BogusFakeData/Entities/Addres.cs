using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BogusFakeData.Entities
{
    public class Addres
    {
        public string? City { get; set;}
        public string? PostCode { get; set; }
        public string? Neighbourhood { get; set; }
        public string? Country { get; set; } = "Türkiye";
        public string? StreetName { get; set; }
    }
}
