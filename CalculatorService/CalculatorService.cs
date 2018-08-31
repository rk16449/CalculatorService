using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace CalculatorService
{
    public class CalculatorService : ICalculatorService
    {
        static int requests = 0;

        public string GetText(string value)
        {
            requests++;
            return "Service reads: " + value;
        }

        public string GetName(string name)
        {
            requests++;
            return "Hello " + name + " welcome to the service";
        }

        public int GetRequests()
        {
            return requests;
        }

        public int AddIntegerNumbers(int num1, int num2)
        {
            requests++;
            return num1 + num2;
        }

        public int SubtractIntegerNumbers(int num1, int num2)
        {
            requests++;
            return num1 - num2;
        }

        public int DivideIntegerNumbers(int num1, int num2)
        {
            requests++;
            try
            {
                return (num1 / num2);
            }catch(Exception)
            {
                throw new FaultException("From Service: Error while dividing number");
            }
        }
    }
}
