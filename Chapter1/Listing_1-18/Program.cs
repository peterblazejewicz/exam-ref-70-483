using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace Chapter1.Listing_1_18
{
    class Program
    {
        public static async Task Main(string[] args)
        {
            string results = await DownloadContent();
            Console.WriteLine($"Results: {results}");
        }

        private static async Task<string> DownloadContent()
        {
            using (HttpClient client = new HttpClient())
            {
                string results = await client.GetStringAsync("https://www.microsoft.com");
                return results;
            }
        }
    }
}
