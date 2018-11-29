using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace Crypto_Service
{
    [ServiceContract]
    public interface ICryptoService
    {
        [OperationContract]
        bool SetKey(byte[] input, Algorithm algorithm);

        [OperationContract]
        byte[] GenerateRandomKey(Algorithm algorithm);

        [OperationContract]
        bool SetIV(byte[] input);

        [OperationContract]
        byte[] GenerateRandomIV();

        [OperationContract]
        bool SetAlgorithmProperties(IDictionary<string, byte[]> specArguments, Algorithm algorithm);

        [OperationContract]
        byte[] Crypt(byte[] input, Algorithm algorithm);

        [OperationContract]
        byte[] Decrypt(byte[] output, Algorithm algorithm);
    }

    // Use a data contract as illustrated in the sample below to add composite types to service operations.
    // You can add XSD files into the project. After building the project, you can directly use the data types defined there, with the namespace "Crypto_Service.ContractType".
    //[DataContract]
    //public class CompositeType
    //{
    //    bool boolValue = true;
    //    string stringValue = "Hello ";

    //    [DataMember]
    //    public bool BoolValue
    //    {
    //        get { return boolValue; }
    //        set { boolValue = value; }
    //    }

    //    [DataMember]
    //    public string StringValue
    //    {
    //        get { return stringValue; }
    //        set { stringValue = value; }
    //    }
    //}
}
