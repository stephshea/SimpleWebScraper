using System;
using System.Net;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;

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
