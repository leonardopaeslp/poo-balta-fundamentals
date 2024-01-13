using ConsoleApp1.NotificationContext;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.ContentContext
{
    public class Articles : Content
    {
         public Articles(string title, string url) : base(title, url)
        {

        }
    }
}
