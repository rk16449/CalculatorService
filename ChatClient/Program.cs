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


            Console.WriteLine("Enter your name: ");
            string name = Console.ReadLine();
            var returnedMsg = proxy.GetName(name);


            Console.WriteLine(returnedMsg);
            Console.ReadKey();
        }
    }
}
