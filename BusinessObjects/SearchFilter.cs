using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessObjects
{
    public class SearchFilter
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
       
        public int AgeMin { get; set; }
        public int AgeMax { get; set; }
        public int Sex { get; set; }
        public decimal HeightMin { get; set; }
        public decimal HeightMax { get; set; }
        public decimal WeightMin { get; set; }
        public decimal WeightMax { get; set; }
        public string Nationality { get; set; }
        public string Email { get; set; }
        public int NoOfResults { get; set; }
    }
}
