﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Crypto_Lib
{
    public class KnapsackAlgorithm : ICrypto
    {
        #region Attributes

        // Length of data being crypted in bits
        private const byte DataLength = 8;

        // Keys
        private uint[] privateKey;
        private uint[] publicKey;

        // Knapsack variables
        private uint n;
        private uint m;
        private uint mInverse;

        public KnapsackAlgorithm()
        {
            // Default values
            n = 491;
            m = 41;
            mInverse = 12;

            privateKey = new uint[] { 2, 3, 7, 14, 30, 57, 120, 251 };
            publicKey = new uint[] { 82, 123, 287, 83, 248, 373, 10, 471 };

        }

        #endregion

        #region Implemented Interface Functions

        public bool SetKey(byte[] input)
        {
            // Convert input into uint array
            uint[] temp = new uint[DataLength];
            Buffer.BlockCopy(input, 0, temp, 0, input.Length);

            // Check if the array is superrising
            float sum = 0;
            for (int i = 0; i < DataLength; i++)
            {
                if (temp[i] <= sum)
                    return false;
                sum += temp[i];
            }

            // Set private key
            privateKey = temp;

            // Set public key
            CalculatePublicKey();

            return true;
        }

        public byte[] GenerateRandomKey()
        {
            uint[] temp = new uint[DataLength];
            var sum = n;
            for (int i = DataLength - 1; i >= 0; i--)
            {
                sum -= 1;
                sum /= 2;
                temp[i] = sum;
            }

            return temp.SelectMany(BitConverter.GetBytes).ToArray();
        }

        public bool SetAlgorithmProperties(IDictionary<string, byte[]> specArguments)
        {
            if (specArguments.ContainsKey("m"))
                m = BitConverter.ToUInt32(specArguments["m"], 0);

            if (specArguments.ContainsKey("n"))
                n = BitConverter.ToUInt32(specArguments["n"], 0);

            if (specArguments.ContainsKey("invm"))
                mInverse = BitConverter.ToUInt32(specArguments["invm"], 0);

            return true;
        }

        public byte[] Crypt(byte[] input)
        {

            var length = input.Length;


            var result = new uint[length];


            for (var i = 0; i < length; i++)
            {

                var inputByte = new[] { input[i] };


                var bits = new BitArray(inputByte);


                for (var j = 0; j < DataLength; j++)
                    if (bits[DataLength - 1 - j])
                        result[i] += publicKey[j];
            }

            var sb = new StringBuilder();
            for (var i = 0; i < result.Length; i++)
            {
                sb.Append(result[i].ToString());
                if (i != result.Length - 1)
                    sb.Append(" ");
            }

            var byteResult = Encoding.ASCII.GetBytes(sb.ToString());

            return byteResult;
        }

        public byte[] Decrypt(byte[] output)
        {
            var stringOutput = Encoding.ASCII.GetString(output).Split(' ');

            var array = Array.ConvertAll(stringOutput, uint.Parse);

            var length = array.Length;

            var result = new byte[length];

            for (var i = 0; i < length; i++)
            {
                var TC = (array[i] * mInverse) % n;

                var bits = new BitArray(DataLength);

                var current = TC;

                for (var j = DataLength - 1; j >= 0; j--)
                {

                    if (current - privateKey[j] >= current) continue;
                    bits[DataLength - 1 - j] = true;
                    current -= privateKey[j];
                }

                bits.CopyTo(result, i);
            }

            return result;
        }

        #endregion

        #region Not Implemented Interface Functions

        public byte[] GenerateRandomIV()
        {
            throw new NotImplementedException();
        }

        public bool SetIV(byte[] input)
        {
            throw new NotImplementedException();
        }

        #endregion

        #region Help Functions

        private void CalculatePublicKey()
        {
            for (int i = 0; i < DataLength; i++)
                publicKey[i] = (privateKey[i] * m) % n;
        }

        #endregion
    }
}
