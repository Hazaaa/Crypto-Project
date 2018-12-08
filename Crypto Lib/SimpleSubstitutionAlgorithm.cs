using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Crypto_Lib
{
    public class SimpleSubstitutionAlgorithm : ICrypto
    {
        #region Attributes

        private string key;
        private const string alphabet = "abcdefghijklmnopqrstuvwxyz";
        private string alphabet256 = "";

        #endregion

        #region Implemented Interface Functions

        public byte[] Crypt(byte[] input)
        {
            string originalContent;
            string cryptedText = "";
            string codeAlphabet = key;
            string useAlphabet;

            if (alphabet256.Equals(""))
            {
                originalContent = Encoding.ASCII.GetString(input);
                useAlphabet = alphabet;
                if (useAlphabet.Length != codeAlphabet.Length)
                    return null;
            }
            else
            {
                originalContent = Encoding.UTF8.GetString(input);
                useAlphabet = alphabet256;
                if (useAlphabet.Length != alphabet256.Length)
                    return null;
            }

            for (int i = 0; i < originalContent.Length; ++i)
            {
                int oldCharIndex = useAlphabet.IndexOf(char.ToLower(originalContent[i]));

                if (oldCharIndex >= 0)
                    cryptedText += char.IsUpper(originalContent[i]) ? char.ToUpper(codeAlphabet[oldCharIndex]) : codeAlphabet[oldCharIndex];
                else
                    cryptedText += " ";
            }

            if (alphabet256.Equals(""))
            {
                return Encoding.ASCII.GetBytes(cryptedText);
            }
            else
            {
                return Encoding.UTF8.GetBytes(cryptedText);
            }
        }

        public byte[] Decrypt(byte[] output)
        {
            string originalContent;
            string decryptedText = "";
            string codeAlphabet;
            string useAlphabet;

            if (alphabet256.Equals(""))
            {
                originalContent = Encoding.ASCII.GetString(output);
                useAlphabet = key;
                codeAlphabet = alphabet;
                if (useAlphabet.Length != codeAlphabet.Length)
                    return null;
            }
            else
            {
                originalContent = Encoding.UTF8.GetString(output);
                useAlphabet = key;
                codeAlphabet = alphabet256;
                if (useAlphabet.Length != alphabet256.Length)
                    return null;
            }

            for (int i = 0; i < originalContent.Length; ++i)
            {
                int oldCharIndex = useAlphabet.IndexOf(char.ToLower(originalContent[i]));

                if (oldCharIndex >= 0)
                    decryptedText += char.IsUpper(originalContent[i]) ? char.ToUpper(codeAlphabet[oldCharIndex]) : codeAlphabet[oldCharIndex];
                else
                    decryptedText += " ";
            }

            if (alphabet256.Equals(""))
            {
                return Encoding.ASCII.GetBytes(decryptedText);
            }
            else
            {
                return Encoding.UTF8.GetBytes(decryptedText);
            }
        }

        public byte[] GenerateRandomKey()
        {
            Random random = new Random();
            string randomAlphabet = new string(alphabet.ToCharArray().OrderBy(x => random.Next()).ToArray());
            return Encoding.ASCII.GetBytes(randomAlphabet);
        }

        public bool SetAlgorithmProperties(IDictionary<string, byte[]> specArguments)
        {
            byte[] alphabetBytes;
            specArguments.TryGetValue("alphabet256", out alphabetBytes);

            byte[] key;
            specArguments.TryGetValue("alphabet256Key", out key);

            this.key = Encoding.UTF8.GetString(key);
            this.alphabet256 = Encoding.UTF8.GetString(alphabetBytes);
            return true;
        }

        public bool SetKey(byte[] input)
        {
            if (input.Length > 26)
                return false;

            this.key = Encoding.ASCII.GetString(input);
            return true;
        }

        #endregion

        #region Not Implemented Intarface Functions

        public bool SetIV(byte[] input)
        {
            throw new NotImplementedException();
        }

        public byte[] GenerateRandomIV()
        {
            throw new NotImplementedException();
        }

        #endregion

    }
}
