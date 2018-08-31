using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChatClient
{
    class Program
    {
        static void Main(string[] args)
        {
            ServiceReference2.ChatServiceClient proxy = new ServiceReference2.ChatServiceClient();

            // Ask for name
            Console.WriteLine("Enter your name: ");
            string name = Console.ReadLine();
            var returnedMsg = proxy.GetName(name);
            Console.WriteLine(returnedMsg);

            // Continuously ask for what service to do
            while (true)
            {
                Console.WriteLine("-------------------------------------------------------");
                Console.WriteLine("This service can do many things, select a number to try");
                Console.WriteLine("0. To Exit ");
                Console.WriteLine("1. Add two numbers together");
                Console.WriteLine("2. Subtract two numbers");
                Console.WriteLine("3. Divide two numbers");
                var input = Console.ReadLine();
                if (input.Equals("0"))
                {
                    break;
                }


                switch (input) {
                    case "1":
                        Console.WriteLine("You selected to add 2 numbers");
                        Console.WriteLine("Number 1: ");
                        int num1 = int.Parse(Console.ReadLine());
                        Console.WriteLine("Number 2: ");
                        int num2 = int.Parse(Console.ReadLine());
                        Console.WriteLine("The numbers you are sending to the service is: " + num1 + " and " + num2);
                        var returnedValue = proxy.AddIntegerNumbers(num1, num2);
                        Console.WriteLine("The service replies with: " + returnedValue);
                        break;
                }


                Console.ReadKey();
            }
                
        }
    }
}
