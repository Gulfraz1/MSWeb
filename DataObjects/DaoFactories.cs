using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataObjects
{
    // Factory of factories. This class is a factory class that creates
    // data-base specific factories which in turn create data acces objects.
    // ** GoF Design Patterns: Factory.
    public class DaoFactories
    {
        public static IDaoFactory GetFactory()
        {
            return new Linq2sql.DaoFactory();
        }
    }
}
