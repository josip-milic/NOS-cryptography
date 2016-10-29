using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;

namespace EncryptionProject
{
    class CryptoSHA2 : Crypto
    {
        private int currentHashSize;
        private string currentDataString;

        public CryptoSHA2()
        {
            currentHashSize = 256;
        }

        #region ENCRYPTION
        public override byte[] Encrypt(byte[] inputData)
        {
            byte[] hash = null;
            switch (currentHashSize)
            {
                case 256:
                    hash = new SHA256Managed().ComputeHash(inputData);
                    break;
                case 384:
                    hash = new SHA384Managed().ComputeHash(inputData);
                    break;
                case 512:
                    hash = new SHA512Managed().ComputeHash(inputData);
                    break;
                default:
                    throw new Exception("Unsupported size");
            }

            return hash;
        }

        public override byte[] Decrypt(byte[] inputData)
        {
            return null;
        }
        #endregion

        #region GENERATE DIGEST FILE
        public void GenerateOutFile(bool encryption, string inFilePath, string outFilePath)
        {
            if (encryption)
            {
                Dictionary<string, string>  fileInfoDict = new Dictionary<string, string>();
                fileInfoDict["Description"] = "Digest";
                fileInfoDict["File name"] = inFilePath.Split('\\').Last();
                fileInfoDict["Method"] = "SHA-2";
                byte[] bytes = Encrypt(File.ReadAllBytes(inFilePath));
                currentDataString = fileInfoDict["Data"] = ByteArrayToHexString(bytes);

                FileModel.GenerateFile(outFilePath, fileInfoDict);
            }
        }
        #endregion

        #region GET AND SET
        internal int GetHashSize()
        {
            return currentHashSize;
        }

        internal void SetHashSize(int hashSize)
        {
            this.currentHashSize = hashSize;
        }

        internal string GetDataString()
        {
            string temp = currentDataString;
            currentDataString = "";
            return temp;
        }
        #endregion
    }
}
