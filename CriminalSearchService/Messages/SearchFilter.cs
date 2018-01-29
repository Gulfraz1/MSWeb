using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace CriminalSearchService.Messages
{
    [DataContract]
    public class SearchFilter
    {
        [DataMember]
        public string FirstName { get; set; }
        [DataMember]
        public string LastName { get; set; }
        [DataMember]
        public int AgeMin { get; set; }
        [DataMember]
        public int AgeMax { get; set; }
        [DataMember]
        public int Sex { get; set; }
        [DataMember]
        public decimal HeightMin { get; set; }
        [DataMember]
        public decimal HeightMax { get; set; }
        [DataMember]
        public decimal WeightMin { get; set; }
        [DataMember]
        public decimal WeightMax { get; set; }
        [DataMember]
        public string Nationality { get; set; }
        [DataMember]
        public string Email { get; set; }
        [DataMember]
        public int NoOfResults { get; set; }
    }
}
