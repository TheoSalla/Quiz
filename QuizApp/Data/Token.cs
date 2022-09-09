namespace QuizApp.Data
{
    public class Token
    {
        private string sessionToken;

        public string SessionToken { get => sessionToken; set => sessionToken = value; }

        public Token()
        {
            var token = RestClientLib.SessionToken.GenerateSessionToken();
            Console.WriteLine("Generating token :" + token);
            this.SessionToken = token;
        }

    }
}