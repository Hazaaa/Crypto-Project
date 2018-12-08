using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Crypto_Lib
{
    public interface ICrypto
    {
        bool SetKey(byte[] input);
        byte[] GenerateRandomKey();
        bool SetIV(byte[] input);
        byte[] GenerateRandomIV();
        bool SetAlgorithmProperties(IDictionary<string, byte[]> specArguments);
        byte[] Crypt(byte[] input);
        byte[] Decrypt(byte[] output);
    }
}
