using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.AppException
{
    public class Log : ILog
    {
        public void Error(Exception exception)
        {
            //TODO: Log Exception;
        }
    }
}
