using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataObjects.Linq2sql
{
    public class DaoFactory : IDaoFactory
    {
        public ICriminalDao CriminalDao
        {
            get { return new CriminalDao(); }
        }
    }
}
