﻿//------------------------------------------------------------------------------
// <auto-generated>
//     此代码由工具生成。
//     运行时版本:4.0.30319.42000
//
//     对此文件的更改可能会导致不正确的行为，并且如果
//     重新生成代码，这些更改将会丢失。
// </auto-generated>
//------------------------------------------------------------------------------

namespace ConsoleWsHttpTest.ServiceReference1 {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceReference1.ICase")]
    public interface ICase {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICase/AddCase", ReplyAction="http://tempuri.org/ICase/AddCaseResponse")]
        void AddCase();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICase/GetBuffer", ReplyAction="http://tempuri.org/ICase/GetBufferResponse")]
        int[] GetBuffer();
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface ICaseChannel : ConsoleWsHttpTest.ServiceReference1.ICase, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class CaseClient : System.ServiceModel.ClientBase<ConsoleWsHttpTest.ServiceReference1.ICase>, ConsoleWsHttpTest.ServiceReference1.ICase {
        
        public CaseClient() {
        }
        
        public CaseClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public CaseClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public CaseClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public CaseClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public void AddCase() {
            base.Channel.AddCase();
        }
        
        public int[] GetBuffer() {
            return base.Channel.GetBuffer();
        }
    }
}
