using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Bogus.DataSets.Name;

namespace BogusFakeData.Entities
{
    public class Users
    {
        public Guid Id { get; set; }
        public string? Firstname { get; set; }
        public string? Lastname { get; set; }
        public int Age { get; set; }
        public string? Nickname { get; set; }
        public string? Mail { get; set; }
        public Gender Gender { get; set; }
        public Addres? Address { get; set; }

    }
}
