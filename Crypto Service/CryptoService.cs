using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using Crypto_Lib;

namespace Crypto_Service
{
    public enum Algorithm
    {
        SimpleSubstitution,
        XXTEA,
        Knapsack,
        SHA2
    }

    public class CryptoService : ICryptoService
    {
        static private SimpleSubstitutionAlgorithm simpleSubstitution = new SimpleSubstitutionAlgorithm();

        public byte[] Crypt(byte[] input, Algorithm algorithm)
        {
            byte[] crypted = null;

            switch (algorithm)
            {
                case Algorithm.SimpleSubstitution:
                    {
                        crypted = CryptoService.simpleSubstitution.Crypt(input);
                    }
                    break;
                case Algorithm.XXTEA:
                    break;
                case Algorithm.Knapsack:
                    break;
                case Algorithm.SHA2:
                    break;
                default:
                    break;
            }

            return crypted;
        }

        public byte[] Decrypt(byte[] output, Algorithm algorithm)
        {
            byte[] decrypted = null;

            switch (algorithm)
            {
                case Algorithm.SimpleSubstitution:
                    {
                        decrypted = CryptoService.simpleSubstitution.Decrypt(output);
                    }
                    break;
                case Algorithm.XXTEA:
                    break;
                case Algorithm.Knapsack:
                    break;
                case Algorithm.SHA2:
                    break;
                default:
                    break;
            }

            return decrypted;
        }

        public byte[] GenerateRandomIV()
        {
            throw new NotImplementedException();
        }

        public byte[] GenerateRandomKey(Algorithm algorithm)
        {
            byte[] randomKey = null;

            switch (algorithm)
            {
                case Algorithm.SimpleSubstitution:
                    {
                        randomKey = simpleSubstitution.GenerateRandomKey();
                    }
                    break;
                case Algorithm.XXTEA:
                    break;
                case Algorithm.Knapsack:
                    break;
                case Algorithm.SHA2:
                    break;
                default:
                    break;
            }

            return randomKey;
        }

        public bool SetAlgorithmProperties(IDictionary<string, byte[]> specArguments, Algorithm algorithm)
        {
            switch (algorithm)
            {
                case Algorithm.SimpleSubstitution:
                    CryptoService.simpleSubstitution.SetAlgorithmProperties(specArguments);
                    break;
                case Algorithm.XXTEA:
                    break;
                case Algorithm.Knapsack:
                    break;
                case Algorithm.SHA2:
                    break;
                default:
                    break;
            }
            return true;
        }

        public bool SetIV(byte[] input)
        {
            throw new NotImplementedException();
        }

        public bool SetKey(byte[] input, Algorithm algorithm)
        {
            switch (algorithm)
            {
                case Algorithm.SimpleSubstitution:
                    CryptoService.simpleSubstitution.SetKey(input);
                    break;
                case Algorithm.XXTEA:
                    break;
                case Algorithm.Knapsack:
                    break;
                case Algorithm.SHA2:
                    break;
                default:
                    break;
            }
            return true;
        }
    }
}
