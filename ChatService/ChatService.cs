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
            return "You said" + value;
        }
    }
}
