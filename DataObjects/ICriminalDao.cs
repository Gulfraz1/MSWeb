using BusinessObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataObjects
{
    // defines methods to access Members.
    // this is a database-independent interface. Implementations are database specific
    // ** DAO Pattern
    public interface ICriminalDao
    {
        List<Criminal> SearchCriminals(SearchFilter searchFilter);
    }
}
