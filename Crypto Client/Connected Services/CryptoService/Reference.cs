﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Crypto_Client.CryptoService {
    using System.Runtime.Serialization;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Algorithm", Namespace="http://schemas.datacontract.org/2004/07/Crypto_Service")]
    public enum Algorithm : int {
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        SimpleSubstitution = 0,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        XXTEA = 1,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        Knapsack = 2,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        SHA2 = 3,
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="CryptoService.ICryptoService")]
    public interface ICryptoService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICryptoService/SetKey", ReplyAction="http://tempuri.org/ICryptoService/SetKeyResponse")]
        bool SetKey(byte[] input, Crypto_Client.CryptoService.Algorithm algorithm);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICryptoService/SetKey", ReplyAction="http://tempuri.org/ICryptoService/SetKeyResponse")]
        System.Threading.Tasks.Task<bool> SetKeyAsync(byte[] input, Crypto_Client.CryptoService.Algorithm algorithm);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICryptoService/GenerateRandomKey", ReplyAction="http://tempuri.org/ICryptoService/GenerateRandomKeyResponse")]
        byte[] GenerateRandomKey(Crypto_Client.CryptoService.Algorithm algorithm);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICryptoService/GenerateRandomKey", ReplyAction="http://tempuri.org/ICryptoService/GenerateRandomKeyResponse")]
        System.Threading.Tasks.Task<byte[]> GenerateRandomKeyAsync(Crypto_Client.CryptoService.Algorithm algorithm);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICryptoService/SetIV", ReplyAction="http://tempuri.org/ICryptoService/SetIVResponse")]
        bool SetIV(byte[] input);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICryptoService/SetIV", ReplyAction="http://tempuri.org/ICryptoService/SetIVResponse")]
        System.Threading.Tasks.Task<bool> SetIVAsync(byte[] input);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICryptoService/GenerateRandomIV", ReplyAction="http://tempuri.org/ICryptoService/GenerateRandomIVResponse")]
        byte[] GenerateRandomIV();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICryptoService/GenerateRandomIV", ReplyAction="http://tempuri.org/ICryptoService/GenerateRandomIVResponse")]
        System.Threading.Tasks.Task<byte[]> GenerateRandomIVAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICryptoService/SetAlgorithmProperties", ReplyAction="http://tempuri.org/ICryptoService/SetAlgorithmPropertiesResponse")]
        bool SetAlgorithmProperties(System.Collections.Generic.Dictionary<string, byte[]> specArguments);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICryptoService/SetAlgorithmProperties", ReplyAction="http://tempuri.org/ICryptoService/SetAlgorithmPropertiesResponse")]
        System.Threading.Tasks.Task<bool> SetAlgorithmPropertiesAsync(System.Collections.Generic.Dictionary<string, byte[]> specArguments);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICryptoService/Crypt", ReplyAction="http://tempuri.org/ICryptoService/CryptResponse")]
        byte[] Crypt(byte[] input, Crypto_Client.CryptoService.Algorithm algorithm);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICryptoService/Crypt", ReplyAction="http://tempuri.org/ICryptoService/CryptResponse")]
        System.Threading.Tasks.Task<byte[]> CryptAsync(byte[] input, Crypto_Client.CryptoService.Algorithm algorithm);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICryptoService/Decrypt", ReplyAction="http://tempuri.org/ICryptoService/DecryptResponse")]
        byte[] Decrypt(byte[] output, Crypto_Client.CryptoService.Algorithm algorithm);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICryptoService/Decrypt", ReplyAction="http://tempuri.org/ICryptoService/DecryptResponse")]
        System.Threading.Tasks.Task<byte[]> DecryptAsync(byte[] output, Crypto_Client.CryptoService.Algorithm algorithm);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface ICryptoServiceChannel : Crypto_Client.CryptoService.ICryptoService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class CryptoServiceClient : System.ServiceModel.ClientBase<Crypto_Client.CryptoService.ICryptoService>, Crypto_Client.CryptoService.ICryptoService {
        
        public CryptoServiceClient() {
        }
        
        public CryptoServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public CryptoServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public CryptoServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public CryptoServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public bool SetKey(byte[] input, Crypto_Client.CryptoService.Algorithm algorithm) {
            return base.Channel.SetKey(input, algorithm);
        }
        
        public System.Threading.Tasks.Task<bool> SetKeyAsync(byte[] input, Crypto_Client.CryptoService.Algorithm algorithm) {
            return base.Channel.SetKeyAsync(input, algorithm);
        }
        
        public byte[] GenerateRandomKey(Crypto_Client.CryptoService.Algorithm algorithm) {
            return base.Channel.GenerateRandomKey(algorithm);
        }
        
        public System.Threading.Tasks.Task<byte[]> GenerateRandomKeyAsync(Crypto_Client.CryptoService.Algorithm algorithm) {
            return base.Channel.GenerateRandomKeyAsync(algorithm);
        }
        
        public bool SetIV(byte[] input) {
            return base.Channel.SetIV(input);
        }
        
        public System.Threading.Tasks.Task<bool> SetIVAsync(byte[] input) {
            return base.Channel.SetIVAsync(input);
        }
        
        public byte[] GenerateRandomIV() {
            return base.Channel.GenerateRandomIV();
        }
        
        public System.Threading.Tasks.Task<byte[]> GenerateRandomIVAsync() {
            return base.Channel.GenerateRandomIVAsync();
        }
        
        public bool SetAlgorithmProperties(System.Collections.Generic.Dictionary<string, byte[]> specArguments) {
            return base.Channel.SetAlgorithmProperties(specArguments);
        }
        
        public System.Threading.Tasks.Task<bool> SetAlgorithmPropertiesAsync(System.Collections.Generic.Dictionary<string, byte[]> specArguments) {
            return base.Channel.SetAlgorithmPropertiesAsync(specArguments);
        }
        
        public byte[] Crypt(byte[] input, Crypto_Client.CryptoService.Algorithm algorithm) {
            return base.Channel.Crypt(input, algorithm);
        }
        
        public System.Threading.Tasks.Task<byte[]> CryptAsync(byte[] input, Crypto_Client.CryptoService.Algorithm algorithm) {
            return base.Channel.CryptAsync(input, algorithm);
        }
        
        public byte[] Decrypt(byte[] output, Crypto_Client.CryptoService.Algorithm algorithm) {
            return base.Channel.Decrypt(output, algorithm);
        }
        
        public System.Threading.Tasks.Task<byte[]> DecryptAsync(byte[] output, Crypto_Client.CryptoService.Algorithm algorithm) {
            return base.Channel.DecryptAsync(output, algorithm);
        }
    }
}