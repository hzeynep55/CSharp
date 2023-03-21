using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BogusFakeData.Entities
{
    public class About
    {
        public Guid Id{ get; set; }
        public string? Name { get; set; }
        public string? Company { get; set; }
        public string? Mail { get; set; }
    }
}
