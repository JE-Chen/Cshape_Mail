using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cshap_email
{
    class Program
    {
        static void Main(string[] args)
        {
            Mail mail = new Mail();
            mail.SendMessage("******", "******", "******", "******", "******", "******");
        }
    }
}
