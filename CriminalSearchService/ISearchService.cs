using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;
using CriminalSearchService.Messages;


namespace CriminalSearchService
{
    [ServiceContract]
    public interface ISearchService
    {
        [OperationContract]  
        SearchResponse Search(SearchRequest request);
    }
}
