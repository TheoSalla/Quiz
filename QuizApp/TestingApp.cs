namespace QuizApp
{
    public static class TestingApp
    {
        public static void Hello(this WebApplication app)
        {
            System.Console.WriteLine("Hello from extension method");
        }

    }
}