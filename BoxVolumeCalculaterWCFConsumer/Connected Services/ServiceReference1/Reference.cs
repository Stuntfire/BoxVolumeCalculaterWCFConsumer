﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace BoxVolumeCalculaterWCFConsumer.ServiceReference1 {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceReference1.IService1")]
    public interface IService1 {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetVolume", ReplyAction="http://tempuri.org/IService1/GetVolumeResponse")]
        double GetVolume(double length, double width, double height);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetVolume", ReplyAction="http://tempuri.org/IService1/GetVolumeResponse")]
        System.Threading.Tasks.Task<double> GetVolumeAsync(double length, double width, double height);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetSide", ReplyAction="http://tempuri.org/IService1/GetSideResponse")]
        double GetSide(double volume, double side1, double side2);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetSide", ReplyAction="http://tempuri.org/IService1/GetSideResponse")]
        System.Threading.Tasks.Task<double> GetSideAsync(double volume, double side1, double side2);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IService1Channel : BoxVolumeCalculaterWCFConsumer.ServiceReference1.IService1, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class Service1Client : System.ServiceModel.ClientBase<BoxVolumeCalculaterWCFConsumer.ServiceReference1.IService1>, BoxVolumeCalculaterWCFConsumer.ServiceReference1.IService1 {
        
        public Service1Client() {
        }
        
        public Service1Client(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public Service1Client(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public Service1Client(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public Service1Client(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public double GetVolume(double length, double width, double height) {
            return base.Channel.GetVolume(length, width, height);
        }
        
        public System.Threading.Tasks.Task<double> GetVolumeAsync(double length, double width, double height) {
            return base.Channel.GetVolumeAsync(length, width, height);
        }
        
        public double GetSide(double volume, double side1, double side2) {
            return base.Channel.GetSide(volume, side1, side2);
        }
        
        public System.Threading.Tasks.Task<double> GetSideAsync(double volume, double side1, double side2) {
            return base.Channel.GetSideAsync(volume, side1, side2);
        }
    }
}
