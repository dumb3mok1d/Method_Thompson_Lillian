using System;

namespace Method_Thompson_Lillian
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a whole number!");
            int x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please enter a another whole number!");
            int y = Convert.ToInt32(Console.ReadLine());
            
            Console.WriteLine(Multiply(x,y));

            Console.WriteLine("What is your name?");
            string name = Console.ReadLine();

            WelcomeUser(name);

            Goodbye();
        }

        static int Multiply(int num1, int num2)
        {
            return num1 * num2; 
        }

         static void WelcomeUser(string username)
        {
            Console.WriteLine($"Hello, {username}! it is nice to meet you!");
        }

        static void Goodbye()
        {
            Console.WriteLine("Have a friendly day :)");
        }




       
    }   
       
}
