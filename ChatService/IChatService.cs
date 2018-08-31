using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace ChatService
{

    [ServiceContract]
    public interface IChatService
    {
        [OperationContract]
        string GetText(string value);
        [OperationContract]
        string GetName(string name);
        [OperationContract]
        int AddIntegerNumbers(int num1, int num2);
    }
}
