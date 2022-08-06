using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using RestClientLib;

namespace QuizApp.Data
{
    public class Token
    {
        public string token { get; set; }

        public string GetToken()
        {
            var token = SessionToken.GenerateSessionToken();
            System.Console.WriteLine(token);
            this.token = token;
            return this.token;
        }
        public Token()
        {
            var token = SessionToken.GenerateSessionToken();
            System.Console.WriteLine("Generating token :" + token);
           this.token = token;
        }

    }
}