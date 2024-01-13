﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.NotificationContext
{
    public abstract class Notifiable
    {
        public List<Notification> Notifications { get; set; }

        public Notifiable()
        {
            Notifications = new List<Notification>();
        }

        public void AddNotification(Notification notification)
        {
            Notifications.Add(notification);
        }

        public void AddRangeNotification(IEnumerable<Notification> notifications)
        {
            Notifications.AddRange(notifications);

        }

        public bool isInvalid => Notifications.Any();
    }
}
