using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.AppException
{
   public interface ILog
   {
       void Error(Exception exception);
   }
}
