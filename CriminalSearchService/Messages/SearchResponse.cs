using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace CriminalSearchService.Messages
{
    [DataContract]
    public class SearchResponse
    {
        [DataMember]
        public bool Success { get; set; }
        [DataMember]
        public List<string> Errors { get; set; } 
    }
}
