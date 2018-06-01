using System;
using System.Net;

namespace SimpleWebScraper
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            var client = new WebClient();
            var text = client.DownloadString("http://provcomlib.org");
            Console.WriteLine(text);
        }
    }
}