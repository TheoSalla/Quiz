using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;
using System.Threading.Tasks;

namespace RestClientLib
{
    public class JsonToModel : IJsonToModel
    {
        public Questions GetQuestions(Category category = 0, Difficulty difficulty = 0, int amount = 10, string sessionToken = "")
        {
            RestClient client = new();
            var data = client.GetData(category, difficulty, amount, sessionToken);

            JsonSerializerOptions serializerOptions = new()
            {
                PropertyNamingPolicy = new NamingPolicy()
            };
            Questions? questions = new();
            try
            {
                questions = JsonSerializer.DeserializeAsync<Questions>(data, serializerOptions).Result;
            }
            catch (Exception ex)
            {

                Console.WriteLine("Error message: " + ex.Message);
            }

            //Decode.DecodeJson(q1);
            questions.DecodeText();

            return questions;

        }
    }
}