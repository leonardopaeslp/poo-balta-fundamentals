using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using ConsoleApp1.NotificationContext;
using ConsoleApp1.SharedContext;

namespace ConsoleApp1.ContentContext
{
    public class Career : Content
    {
        public Career(string title, string url) : base(title, url)
        {
            Items = new List<CareerItem>();

        }
        public IList<CareerItem> Items { get; set; }
        public int TotalCourses { 
            get {
                return Items.Count;
            }
        }
    }

    public class CareerItem: Base
    {
        public CareerItem(int order, string title, string description, Course course)
        {
            Order = order;
            Title = title;
            Description = description;
            if(course == null)
            {
                AddNotification(new Notification("Course", "Curso Inválido"));
            } else
            {
            Course = course;
            }
        }

        public int Order { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public Course Course { get; set; }
    }
}
