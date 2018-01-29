using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessObjects
{
    public class Criminal
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public int Sex { get; set; }
        public decimal Weight { get; set; }
        public decimal Height { get; set; }
        public string Nationality { get; set; }
    }
}
