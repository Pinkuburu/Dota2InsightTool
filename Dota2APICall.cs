using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;

namespace Dota2InsightTool
{
    class Dota2APICall
    {
        public static string APIResults;

        public static async void GetData()
        {

            //We will make a GET request to a really cool website...

            string baseUrl = "https://api.opendota.com/api/matches/5644760337";
            //The 'using' will help to prevent memory leaks.
            //Create a new instance of HttpClient
            using (HttpClient client = new HttpClient())

            //Setting up the response...         

            using (HttpResponseMessage res = await client.GetAsync(baseUrl))
            using (HttpContent content = res.Content)
            {
                string data = await content.ReadAsStringAsync();
                if (data != null)
                {
                    Console.WriteLine(data);
                    APIResults = data;
                }
            }
        }

        
    }
}
