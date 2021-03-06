﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Assignment2_Section2Client.WeatherServiceClient {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="WeatherServiceClient.IWeatherService")]
    public interface IWeatherService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IWeatherService/CelciusToFarenheit", ReplyAction="http://tempuri.org/IWeatherService/CelciusToFarenheitResponse")]
        double CelciusToFarenheit(double value);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IWeatherService/CelciusToFarenheit", ReplyAction="http://tempuri.org/IWeatherService/CelciusToFarenheitResponse")]
        System.Threading.Tasks.Task<double> CelciusToFarenheitAsync(double value);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IWeatherService/FarenheitToCelcius", ReplyAction="http://tempuri.org/IWeatherService/FarenheitToCelciusResponse")]
        double FarenheitToCelcius(double value);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IWeatherService/FarenheitToCelcius", ReplyAction="http://tempuri.org/IWeatherService/FarenheitToCelciusResponse")]
        System.Threading.Tasks.Task<double> FarenheitToCelciusAsync(double value);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IWeatherServiceChannel : Assignment2_Section2Client.WeatherServiceClient.IWeatherService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class WeatherServiceClient : System.ServiceModel.ClientBase<Assignment2_Section2Client.WeatherServiceClient.IWeatherService>, Assignment2_Section2Client.WeatherServiceClient.IWeatherService {
        
        public WeatherServiceClient() {
        }
        
        public WeatherServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public WeatherServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public WeatherServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public WeatherServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public double CelciusToFarenheit(double value) {
            return base.Channel.CelciusToFarenheit(value);
        }
        
        public System.Threading.Tasks.Task<double> CelciusToFarenheitAsync(double value) {
            return base.Channel.CelciusToFarenheitAsync(value);
        }
        
        public double FarenheitToCelcius(double value) {
            return base.Channel.FarenheitToCelcius(value);
        }
        
        public System.Threading.Tasks.Task<double> FarenheitToCelciusAsync(double value) {
            return base.Channel.FarenheitToCelciusAsync(value);
        }
    }
}
