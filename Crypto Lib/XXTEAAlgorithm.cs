using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Crypto_Lib
{
    public class XXTEAAlgorithm : ICrypto
    {
        public byte[] Crypt(byte[] input)
        {
            throw new NotImplementedException();
        }

        public byte[] Decrypt(byte[] output)
        {
            throw new NotImplementedException();
        }

        public byte[] GenerateRandomIV()
        {
            throw new NotImplementedException();
        }

        public byte[] GenerateRandomKey()
        {
            throw new NotImplementedException();
        }

        public bool SetAlgorithmProperties(IDictionary<string, byte[]> specArguments)
        {
            throw new NotImplementedException();
        }

        public bool SetIV(byte[] input)
        {
            throw new NotImplementedException();
        }

        public bool SetKey(byte[] input)
        {
            throw new NotImplementedException();
        }
    }
}
