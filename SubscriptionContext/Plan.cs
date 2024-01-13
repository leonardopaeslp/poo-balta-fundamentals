using ConsoleApp1.SharedContext;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.SubscriptionContext
{
    public class Plan: Base
    {
        public string Title { get; set; }
        public string Price { get; set; }
    }
}
