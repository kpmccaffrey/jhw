using System;

namespace JenkinsHelloWorld
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(CreateMessage()  );
        }

        public static string CreateMessage() {
            return "Hello World!";
        }
    }
}
