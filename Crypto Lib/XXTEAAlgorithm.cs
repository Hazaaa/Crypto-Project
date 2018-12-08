using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Crypto_Lib
{
    public class XXTEAAlgorithm : ICrypto
    {
        #region Attributes

        private const UInt32 delta = 0x9E3779B9;

        private byte[] key;

        #endregion

        #region Interface functions

        public byte[] Crypt(byte[] input)
        {

            UInt32[] v = ToUInt32Array(input, true);
            UInt32[] k = ToUInt32Array(FixKey(key), false);

            Int32 n = v.Length - 1;
            if (n < 1)
            {
                return ToByteArray(v, false);
            }
            UInt32 z = v[n], y, sum = 0, e;
            Int32 p, q = 6 + 52 / (n + 1);

            unchecked
            {
                while (0 < q--)
                {
                    sum += delta;
                    e = sum >> 2 & 3;
                    for (p = 0; p < n; p++)
                    {
                        y = v[p + 1];
                        z = v[p] += MX(sum, y, z, p, e, k);
                    }
                    y = v[0];
                    z = v[n] += MX(sum, y, z, p, e, k);
                }
            }
            
            return ToByteArray(v, false);
        }

        public byte[] Decrypt(byte[] output)
        {

            UInt32[] v = ToUInt32Array(output, false);
            UInt32[] k = ToUInt32Array(FixKey(key), false);

            Int32 n = v.Length - 1;
            if (n < 1)
            {
                return ToByteArray(v, true);
            }
            UInt32 z, y = v[0], sum, e;
            Int32 p, q = 6 + 52 / (n + 1);
            unchecked
            {
                sum = (UInt32)(q * delta);
                while (sum != 0)
                {
                    e = sum >> 2 & 3;
                    for (p = n; p > 0; p--)
                    {
                        z = v[p - 1];
                        y = v[p] -= MX(sum, y, z, p, e, k);
                    }
                    z = v[n];
                    y = v[0] -= MX(sum, y, z, p, e, k);
                    sum -= delta;
                }
            }
            return ToByteArray(v, false);
        }

        public byte[] GenerateRandomKey()
        {
            Random rnd = new Random();
            var bulder = new StringBuilder();
            while(bulder.Length < 16)
            {
                bulder.Append(rnd.Next(10).ToString());
            }

            return Encoding.UTF8.GetBytes(bulder.ToString());
        }

        public bool SetKey(byte[] input)
        {
            if (input.Length < 16)
                return false;

            this.key = input;
            return true;
        }

        #endregion

        #region Helper Functions

        private static UInt32 MX(UInt32 sum, UInt32 y, UInt32 z, Int32 p, UInt32 e, UInt32[] k)
        {
            return (z >> 5 ^ y << 2) + (y >> 3 ^ z << 4) ^ (sum ^ y) + (k[p & 3 ^ e] ^ z);
        }

        //Convert byte array data to UInt32 array
        private static UInt32[] ToUInt32Array(Byte[] data, Boolean includeLength)
        {
            Int32 length = data.Length;
            Int32 n = (((length & 3) == 0) ? (length >> 2) : ((length >> 2) + 1));
            UInt32[] result;
            if (includeLength)
            {
                result = new UInt32[n + 1];
                result[n] = (UInt32)length;
            }
            else
            {
                result = new UInt32[n];
            }
            for (Int32 i = 0; i < length; i++)
            {
                result[i >> 2] |= (UInt32)data[i] << ((i & 3) << 3);
            }
            return result;
        }

        //Convert UInt32 array data to byte array
        private static Byte[] ToByteArray(UInt32[] data, Boolean includeLength)
        {
            Int32 n = data.Length << 2;
            if (includeLength)
            {
                Int32 m = (Int32)data[data.Length - 1];
                n -= 4;
                if ((m < n - 3) || (m > n))
                {
                    return null;
                }
                n = m;
            }
            Byte[] result = new Byte[n];
            for (Int32 i = 0; i < n; i++)
            {
                result[i] = (Byte)(data[i >> 2] >> ((i & 3) << 3));
            }
            return result;
        }

        //Key has to be 16 bytes so if it's less add to 16 bytes
        private static Byte[] FixKey(Byte[] key)
        {
            if (key.Length == 16) return key;
            Byte[] fixedkey = new Byte[16];
            if (key.Length < 16)
            {
                key.CopyTo(fixedkey, 0);
            }
            else
            {
                Array.Copy(key, 0, fixedkey, 0, 16);
            }
            return fixedkey;
        }

        #endregion

        #region Not Implemented Interface functions

        public bool SetIV(byte[] input)
        {
            throw new NotImplementedException();
        }

        public byte[] GenerateRandomIV()
        {
            throw new NotImplementedException();
        }

        public bool SetAlgorithmProperties(IDictionary<string, byte[]> specArguments)
        {
            throw new NotImplementedException();
        }

        #endregion
    }
}
