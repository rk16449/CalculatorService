using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChatClient
{
    class Program
    {
        static CalculatorService.CalculatorServiceClient proxy;
        static string name;

        static void Main(string[] args)
        {
            // Create the new proxy
            proxy = new CalculatorService.CalculatorServiceClient();

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
                switch (input)
                {
                    case "1":
                        AdditionService();
                        break;
                    case "2":
                        SubtractService();
                        break;
                    case "3":
                        DivideService();
                        break;
                    case "4":
                        GetRequestService();
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
            Console.WriteLine("4. Return requests amount");
        }


        static int ConvertToInt(string val)
        {
            try
            {
                int.Parse(val);
            }
            catch (Exception)
            {
                Console.WriteLine("Could not parse integer!");
            }

            return int.Parse(val);
        }

        static int AskNum(string text)
        {
            Console.WriteLine(text);
            int num1 = ConvertToInt(Console.ReadLine());
            return num1;
        }

        static void GetRequestService()
        {
            Console.WriteLine("Service has had " + proxy.GetRequests() + " requests so far");
        }

        static void ColouredText(string val, ConsoleColor col)
        {
            Console.ForegroundColor = col;
            Console.WriteLine(val);
            Console.ResetColor();
        }

        static void AdditionService()
        {
            ColouredText("You selected Add Service", ConsoleColor.DarkBlue);

            int num1 = AskNum("Number 1:");
            int num2 = AskNum("Number 2:");

            ColouredText("The numbers you are sending to the service is: " + num1 + " and " + num2, ConsoleColor.DarkMagenta);

            var returnedValue = proxy.AddIntegerNumbers(num1, num2);
            ColouredText("The service replies with: " + returnedValue, ConsoleColor.DarkGreen);
        }

        static void SubtractService()
        {
            ColouredText("You selected Subtract Service", ConsoleColor.DarkBlue);

            int num1 = AskNum("Number 1: ");
            int num2 = AskNum("Number 2: ");

            ColouredText("The numbers you are sending to the service is: " + num1 + " and " + num2, ConsoleColor.DarkMagenta);

            var returnedValue = proxy.SubtractIntegerNumbers(num1, num2);
            ColouredText("The service replies with: " + returnedValue, ConsoleColor.DarkGreen);
        }

        static void DivideService()
        {
            ColouredText("You selected Divide Service", ConsoleColor.DarkBlue);

            int num1 = AskNum("Number 1: ");
            int num2 = AskNum("Number 2: ");

            ColouredText("The numbers you are sending to the service is: " + num1 + " and " + num2, ConsoleColor.DarkMagenta);

            try
            {
                var returnedValue = proxy.DivideIntegerNumbers(num1, num2);
                ColouredText("The service replies with: " + returnedValue, ConsoleColor.DarkGreen);
            }
            catch(Exception e)
            {
                ColouredText(e.Message, ConsoleColor.Red);
            } 
        }
    }
}
