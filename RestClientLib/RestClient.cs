using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RestClientLib
{
    internal class RestClient
    {
        HttpClient client = new();

        internal Stream GetData(Category category = 0, Difficulty difficulty = 0, int amount = 10, string sessionToken = "")
        {
            System.Console.WriteLine("Category from lib: "  + category);
            var route = $"?amount={amount}&category={(int)category}&difficulty={difficulty}&token={sessionToken}";
            client.BaseAddress = new Uri($"https://opentdb.com/api.php{route}");
            var response = client.GetStreamAsync(client.BaseAddress).Result;
            return response;
        }

    }
}