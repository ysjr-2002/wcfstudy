﻿//------------------------------------------------------------------------------
// <auto-generated>
//     此代码由工具生成。
//     运行时版本:4.0.30319.42000
//
//     对此文件的更改可能会导致不正确的行为，并且如果
//     重新生成代码，这些更改将会丢失。
// </auto-generated>
//------------------------------------------------------------------------------

namespace ConsoleNettcpTest.ServiceReference1 {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="UserInfo", Namespace="http://schemas.datacontract.org/2004/07/Model")]
    [System.SerializableAttribute()]
    public partial class UserInfo : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int AgeField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string NameField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int Age {
            get {
                return this.AgeField;
            }
            set {
                if ((this.AgeField.Equals(value) != true)) {
                    this.AgeField = value;
                    this.RaisePropertyChanged("Age");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Name {
            get {
                return this.NameField;
            }
            set {
                if ((object.ReferenceEquals(this.NameField, value) != true)) {
                    this.NameField = value;
                    this.RaisePropertyChanged("Name");
                }
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceReference1.ICase")]
    public interface ICase {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICase/AddCase", ReplyAction="http://tempuri.org/ICase/AddCaseResponse")]
        void AddCase();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICase/GetBuffer", ReplyAction="http://tempuri.org/ICase/GetBufferResponse")]
        System.Collections.ObjectModel.ObservableCollection<int> GetBuffer();
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface ICaseChannel : ConsoleNettcpTest.ServiceReference1.ICase, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class CaseClient : System.ServiceModel.ClientBase<ConsoleNettcpTest.ServiceReference1.ICase>, ConsoleNettcpTest.ServiceReference1.ICase {
        
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
        
        public System.Collections.ObjectModel.ObservableCollection<int> GetBuffer() {
            return base.Channel.GetBuffer();
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceReference1.IUser")]
    public interface IUser {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IUser/GetUsers", ReplyAction="http://tempuri.org/IUser/GetUsersResponse")]
        System.Collections.ObjectModel.ObservableCollection<ConsoleNettcpTest.ServiceReference1.UserInfo> GetUsers();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IUser/Add", ReplyAction="http://tempuri.org/IUser/AddResponse")]
        void Add(ConsoleNettcpTest.ServiceReference1.UserInfo user);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IUserChannel : ConsoleNettcpTest.ServiceReference1.IUser, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class UserClient : System.ServiceModel.ClientBase<ConsoleNettcpTest.ServiceReference1.IUser>, ConsoleNettcpTest.ServiceReference1.IUser {
        
        public UserClient() {
        }
        
        public UserClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public UserClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public UserClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public UserClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public System.Collections.ObjectModel.ObservableCollection<ConsoleNettcpTest.ServiceReference1.UserInfo> GetUsers() {
            return base.Channel.GetUsers();
        }
        
        public void Add(ConsoleNettcpTest.ServiceReference1.UserInfo user) {
            base.Channel.Add(user);
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceReference1.ICamera")]
    public interface ICamera {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICamera/AddCamera", ReplyAction="http://tempuri.org/ICamera/AddCameraResponse")]
        void AddCamera();
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface ICameraChannel : ConsoleNettcpTest.ServiceReference1.ICamera, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class CameraClient : System.ServiceModel.ClientBase<ConsoleNettcpTest.ServiceReference1.ICamera>, ConsoleNettcpTest.ServiceReference1.ICamera {
        
        public CameraClient() {
        }
        
        public CameraClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public CameraClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public CameraClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public CameraClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public void AddCamera() {
            base.Channel.AddCamera();
        }
    }
}
