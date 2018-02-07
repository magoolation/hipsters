using AngleSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hipsters.Batch
{
    class Program
    {
        static async Task Main(string[] args)
        {
            var config = Configuration.Default.WithDefaultLoader();
            var document = await BrowsingContext.New(config).OpenAsync(@"http://www.hipsters.tech");
            foreach(var element in document.QuerySelectorAll("h1"))
            {
                Console.WriteLine(element.˜˜˜˜˜TextContent);
            }

            Console.WriteLine("Done");
            Console.ReadLine();
        }
    }
}
