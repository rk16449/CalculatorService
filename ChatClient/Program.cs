using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChatClient
{
    class Program
    {
        static ServiceReference2.ChatServiceClient proxy;
        static string name;

        static void Main(string[] args)
        {
            // Create the new proxy
            proxy = new ServiceReference2.ChatServiceClient();

            // Store persons name
            name = AskServiceName();
            
            // Continuously ask for what service to do
            while (true)
            {
                // Ask what the user wants to do
                AskUserText();
                var input = Console.ReadLine();

                // Exit loop
                if (input.Equals("0")) break;

                // Else check values
                switch (input) {
                    case "1":
                        AdditionService();
                        break;
                    case "2":
                        SubtractService();
                        break;
                }
            }
                
        }

        static string AskServiceName()
        {
            // Ask for name
            Console.WriteLine("Enter your name: ");
            string name = Console.ReadLine();
            var returnedMsg = proxy.GetName(name);
            Console.WriteLine(returnedMsg);
            return name;
        }

        static void AskUserText()
        {
            Console.WriteLine("-------------------------------------------------------");
            Console.WriteLine("This service can do many things, select a number to try");
            Console.WriteLine("0. To Exit ");
            Console.WriteLine("1. Add two numbers together");
            Console.WriteLine("2. Subtract two numbers");
            Console.WriteLine("3. Divide two numbers");
        }

        static void SubtractService()
        {

        }

        static void AdditionService()
        {
            Console.WriteLine("You selected to add 2 numbers");

            try
            {
                Console.WriteLine("Number 1: ");
                int num1 = int.Parse(Console.ReadLine());
                Console.WriteLine("Number 2: ");
                int num2 = int.Parse(Console.ReadLine());
                Console.WriteLine("The numbers you are sending to the service is: " + num1 + " and " + num2);
                var returnedValue = proxy.AddIntegerNumbers(num1, num2);
                Console.WriteLine("The service replies with: " + returnedValue);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Invalid integer values");
            }
        }
    }
}
