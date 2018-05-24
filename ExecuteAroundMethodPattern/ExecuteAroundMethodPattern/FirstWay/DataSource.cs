using System;

namespace ExecuteAroundMethodPattern
{
    public sealed class DataSource : IDisposable
    {
        public void Get()
        {
            Console.WriteLine("Please feel free enjoy Execute Around Method pattern.");
            Console.WriteLine("It's incredibly useful and simple.");
        }

        public Author Post() => Author.Instance();

        public void Dispose()
        {
            Console.WriteLine("Clean up the source as quickly as possible. This is EAM pattern.");
        }
    }

    public sealed class Author
    {
        public string Name { get; set; } = "Eden";
        public string City { get; set; } = "Shanghai";

        private Author(){ }

        private static Author _author;
        public static Author Instance()
        {
            if (null == _author)
            {
                return _author = new Author();
            }

            return _author;
        }
    }
}
