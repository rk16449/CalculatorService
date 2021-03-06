﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace CalculatorService
{

    [ServiceContract]
    public interface ICalculatorService
    {
        [OperationContract]
        string GetText(string value);
        [OperationContract]
        string GetName(string name);
        [OperationContract]
        int AddIntegerNumbers(int num1, int num2);
        [OperationContract]
        int SubtractIntegerNumbers(int num1, int num2);
        [OperationContract]
        int DivideIntegerNumbers(int num1, int num2);
        [OperationContract]
        int GetRequests();
    }
}
