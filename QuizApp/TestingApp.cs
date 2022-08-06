using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

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