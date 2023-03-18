using System.Net;

namespace Ex.Decorator.App
{
    class Program
    {
        static void Main(string[] args)
        {
            var clientDecorator = new WebClientDecorator(new WebClient());
            
            var source = clientDecorator.DownloadString("https://www.google.com");

        }

    }
}