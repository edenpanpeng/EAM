using System;

namespace ExecuteAroundMethodPattern
{
    class Program
    {
        static void Main()
        {
            FirstWay();
            SecondWay();
            Console.WriteLine("===THANKS===May 24,2018");
        }

        static void FirstWay()
        {
            var ls = new LearnService(new DataSourceFactory());
            ls.StartLearning();
            var author = ls.InterviewAuthor();
            Console.WriteLine("Author Name:{0} City:{1}", author.Name, author.City);
        }
        static void SecondWay()
        {
            Resource.Do(x =>
            {
                x.StepOne();
                x.StepTwo();
            });
        }
    }
}
