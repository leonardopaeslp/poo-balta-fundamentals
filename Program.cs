using ConsoleApp1.ContentContext;
using ConsoleApp1.SubscriptionContext;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var article = new List<Articles>();
            var newArticle = new Articles("Orientacao POO", "orientacao_poo");
            article.Add(newArticle);

            var courseOne = new Course("Fundamentos POO", "fundamentos-POO");
            var courseTwo = new Course("Fundamentos C#", "fundamentos-C#");
            var courseThree = new Course("Fundamentos ASP.NET", "fundamentos-ASP.NET");

            var newsCourses = new List<Course>();
            newsCourses.Add(courseOne);
            newsCourses.Add(courseTwo);
            newsCourses.Add(courseThree);


            var newCareer = new Career("Back-End", "carreira-back-end");
            var careerItemOne = new CareerItem(1, "Conceitos básicos POO", "Conceitos básicos", null);
            var careerItemTwo = new CareerItem(2, "Conceitos básicos C#", "Conceitos básicos", courseTwo);
            var careerItemThree = new CareerItem(3, "Conceitos básicos .NET", "Conceitos básicos", courseThree);

            newCareer.Items.Add(careerItemOne);
            newCareer.Items.Add(careerItemTwo);
            newCareer.Items.Add(careerItemThree);

            var careers = new List<Career>();
            
            careers.Add(newCareer);

            foreach (var career in careers)
            {
                Console.WriteLine(career.Title);
                foreach (var itemCareer in career.Items)
                {
                    Console.WriteLine(itemCareer.Course?.Title);
                    foreach (var noti in itemCareer.Notifications)
                    {
                        Console.WriteLine($"{noti.Property} - {noti.Message}");
                    }
                }
            }

            var payPalSubs = new PayPalSubscription();
            var student = new Student();
            student.CreatSub(payPalSubs);
        }
    }
}