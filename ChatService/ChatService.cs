using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace ChatService
{
    public class ChatService : IChatService
    {
        public string GetText(string value)
        {
            return "Service reads: " + value;
        }

        public string GetName(string name)
        {
            return "Hello " + name + " welcome to the chat service";
        }

        public int AddIntegerNumbers(int num1, int num2)
        {
            return num1 + num2;
        }
    }
}
