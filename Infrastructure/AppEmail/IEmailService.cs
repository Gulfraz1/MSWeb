using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.AppEmail
{
   public interface IEmailService
    {
        void  Send(string to, List<string> attachments);
    }
}
