using ConsoleApp1.SharedContext;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleApp1.NotificationContext;


namespace ConsoleApp1.SubscriptionContext
{
    public class Student: Base
    {
        public Student()
        {
            Subcriptions = new List<Subcription>();
        }
        public User User { get; set; } 
        public string Name { get; set; }
        public string Email { get; set; }

        public IList<Subcription> Subcriptions { get; set; }

        //Método
        public void CreatSub(Subcription subcription)
        {
            if (IsPremium)
            {
                AddNotification(new Notification("Premium", "O aluno já tem assinatura ativa!"));
            }

            Subcriptions.Add(subcription);
        }

        public bool IsPremium => Subcriptions.Any(x => !x.IsInactive);

        //public bool IsPremium
        //{
        //    get
        //    {
        //        foreach (var subscription in Subcriptions)
        //        {
        //            if (!subscription.IsInactive)
        //            {
        //                return true;
        //            }
        //        }

        //        return false;
        //    }
        //}

    }
}
