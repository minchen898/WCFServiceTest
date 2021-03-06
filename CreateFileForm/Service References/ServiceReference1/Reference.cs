﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.18052
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CreateFileForm.ServiceReference1 {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceReference1.IRemoteCreate")]
    public interface IRemoteCreate {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IRemoteCreate/DoWork", ReplyAction="http://tempuri.org/IRemoteCreate/DoWorkResponse")]
        void DoWork();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IRemoteCreate/ChangeFileName", ReplyAction="http://tempuri.org/IRemoteCreate/ChangeFileNameResponse")]
        void ChangeFileName(string fileName);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IRemoteCreate/GetFileName", ReplyAction="http://tempuri.org/IRemoteCreate/GetFileNameResponse")]
        string GetFileName();
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IRemoteCreateChannel : CreateFileForm.ServiceReference1.IRemoteCreate, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class RemoteCreateClient : System.ServiceModel.ClientBase<CreateFileForm.ServiceReference1.IRemoteCreate>, CreateFileForm.ServiceReference1.IRemoteCreate {
        
        public RemoteCreateClient() {
        }
        
        public RemoteCreateClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public RemoteCreateClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public RemoteCreateClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public RemoteCreateClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public void DoWork() {
            base.Channel.DoWork();
        }
        
        public void ChangeFileName(string fileName) {
            base.Channel.ChangeFileName(fileName);
        }
        
        public string GetFileName() {
            return base.Channel.GetFileName();
        }
    }
}
