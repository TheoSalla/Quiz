namespace QuizApp
{
    public static class TestingApp
    {
        public static void Hello(this WebApplication app)
        {
            Console.WriteLine("Hello from extension method");
        }

    }
}