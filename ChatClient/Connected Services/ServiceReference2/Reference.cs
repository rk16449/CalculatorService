﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ChatClient.ServiceReference2 {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceReference2.IChatService")]
    public interface IChatService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IChatService/GetText", ReplyAction="http://tempuri.org/IChatService/GetTextResponse")]
        string GetText(string value);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IChatService/GetText", ReplyAction="http://tempuri.org/IChatService/GetTextResponse")]
        System.Threading.Tasks.Task<string> GetTextAsync(string value);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IChatService/GetName", ReplyAction="http://tempuri.org/IChatService/GetNameResponse")]
        string GetName(string name);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IChatService/GetName", ReplyAction="http://tempuri.org/IChatService/GetNameResponse")]
        System.Threading.Tasks.Task<string> GetNameAsync(string name);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IChatService/AddIntegerNumbers", ReplyAction="http://tempuri.org/IChatService/AddIntegerNumbersResponse")]
        int AddIntegerNumbers(int num1, int num2);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IChatService/AddIntegerNumbers", ReplyAction="http://tempuri.org/IChatService/AddIntegerNumbersResponse")]
        System.Threading.Tasks.Task<int> AddIntegerNumbersAsync(int num1, int num2);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IChatService/SubtractIntegerNumbers", ReplyAction="http://tempuri.org/IChatService/SubtractIntegerNumbersResponse")]
        int SubtractIntegerNumbers(int num1, int num2);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IChatService/SubtractIntegerNumbers", ReplyAction="http://tempuri.org/IChatService/SubtractIntegerNumbersResponse")]
        System.Threading.Tasks.Task<int> SubtractIntegerNumbersAsync(int num1, int num2);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IChatService/DivideIntegerNumbers", ReplyAction="http://tempuri.org/IChatService/DivideIntegerNumbersResponse")]
        int DivideIntegerNumbers(int num1, int num2);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IChatService/DivideIntegerNumbers", ReplyAction="http://tempuri.org/IChatService/DivideIntegerNumbersResponse")]
        System.Threading.Tasks.Task<int> DivideIntegerNumbersAsync(int num1, int num2);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IChatServiceChannel : ChatClient.ServiceReference2.IChatService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class ChatServiceClient : System.ServiceModel.ClientBase<ChatClient.ServiceReference2.IChatService>, ChatClient.ServiceReference2.IChatService {
        
        public ChatServiceClient() {
        }
        
        public ChatServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public ChatServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ChatServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ChatServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public string GetText(string value) {
            return base.Channel.GetText(value);
        }
        
        public System.Threading.Tasks.Task<string> GetTextAsync(string value) {
            return base.Channel.GetTextAsync(value);
        }
        
        public string GetName(string name) {
            return base.Channel.GetName(name);
        }
        
        public System.Threading.Tasks.Task<string> GetNameAsync(string name) {
            return base.Channel.GetNameAsync(name);
        }
        
        public int AddIntegerNumbers(int num1, int num2) {
            return base.Channel.AddIntegerNumbers(num1, num2);
        }
        
        public System.Threading.Tasks.Task<int> AddIntegerNumbersAsync(int num1, int num2) {
            return base.Channel.AddIntegerNumbersAsync(num1, num2);
        }
        
        public int SubtractIntegerNumbers(int num1, int num2) {
            return base.Channel.SubtractIntegerNumbers(num1, num2);
        }
        
        public System.Threading.Tasks.Task<int> SubtractIntegerNumbersAsync(int num1, int num2) {
            return base.Channel.SubtractIntegerNumbersAsync(num1, num2);
        }
        
        public int DivideIntegerNumbers(int num1, int num2) {
            return base.Channel.DivideIntegerNumbers(num1, num2);
        }
        
        public System.Threading.Tasks.Task<int> DivideIntegerNumbersAsync(int num1, int num2) {
            return base.Channel.DivideIntegerNumbersAsync(num1, num2);
        }
    }
}
