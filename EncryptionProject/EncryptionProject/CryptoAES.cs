using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;

namespace EncryptionProject
{
    class CryptoAES : Crypto
    {
        private byte[] currentKey;
        private byte[] currentIV;
        private int currentKeySize;
        Aes AES;

        public CryptoAES()
        {
            AES = new AesManaged();
        }

        #region ENCRYPTION AND DECRYPTION
        public override byte[] Encrypt(byte[] inputData)
        {
            AES.KeySize = currentKeySize;
            AES.Key = currentKey;
            AES.IV = currentIV;
            MemoryStream MS = new MemoryStream();
            try
            {
                CryptoStream cs = new CryptoStream(MS,
                  AES.CreateEncryptor(), CryptoStreamMode.Write);
                cs.Write(inputData, 0, inputData.Length);
                cs.Close();
            }
            catch (Exception)
            { 
                throw new Exception(AES_KEY_FORMAT_ERROR);
            }
            return MS.ToArray();
        }

        public override byte[] Decrypt(byte[] inputData)
        {
            AES.KeySize = currentKeySize;
            AES.Key = currentKey;
            AES.IV = currentIV;
            MemoryStream MS = new MemoryStream();
            try
            {
                CryptoStream cs = new CryptoStream(MS,
                  AES.CreateDecryptor(), CryptoStreamMode.Write);
                cs.Write(inputData, 0, inputData.Length);
                cs.Close();
            }
            catch (Exception)
            {
                throw new Exception(WRONG_KEY_ERROR);
            }
            return MS.ToArray();
        }
        #endregion

        #region GENERATE ENCRYPTED OR DECRYPTED FILE
        public void GenerateOutFile(bool encryption, string inFilePath, string outFilePath)
        {
            Dictionary<string, string> fileInfoDict;
            if (encryption)
            {
                fileInfoDict = new Dictionary<string, string>();
                fileInfoDict["Description"] = "Crypted file";
                fileInfoDict["File name"] = inFilePath.Split('\\').Last();
                fileInfoDict["Method"] = "AES";
                fileInfoDict["Data"] = Convert.ToBase64String(
                    Encrypt(File.ReadAllBytes(inFilePath))
                );
                FileModel.GenerateFile(outFilePath, fileInfoDict);
            }
            else
            {
                fileInfoDict = FileModel.ParseFile(inFilePath);
                byte[] bytes = Decrypt(Convert.FromBase64String(fileInfoDict["Data"]));
                File.WriteAllBytes(outFilePath, bytes);
            }
        }
        #endregion

        #region GET AND SET
        public byte[] CurrentKey
        {
            get { return currentKey; }
            set { currentKey = value; }
        }

        public byte[] CurrentIV
        {
            get { return currentIV; }
            set { currentIV = value; }

        }

        public int CurrentKeySize
        {
            get { return currentKeySize; }
            set { currentKeySize = value; }
        }
        #endregion

        #region GENERATE NEW KEY FILE
        public void GenerateNewKey()
        {
            AES.KeySize = currentKeySize;
            AES.GenerateKey();
            AES.GenerateIV();
            currentKey = AES.Key;
            currentIV = AES.IV;
        }

        public void GenerateKeyFile(string filePath)
        {
            GenerateNewKey();
            Dictionary<string, string> fileInfoDict = new Dictionary<string, string>();
            fileInfoDict["Description"] = "Secret key";
            fileInfoDict["Method"] = "AES";
            fileInfoDict["Key length"] = IntToHexString(currentKeySize);
            fileInfoDict["Secret key"] = ByteArrayToHexString(AES.Key);
            fileInfoDict["Initialization vector"] = ByteArrayToHexString(AES.IV);
            FileModel.GenerateFile(filePath, fileInfoDict);
        }
        #endregion

        #region PARSE KEY FILE
        public void ParseKeyFile(string filePath)
        {
            try
            {
                Dictionary<string, string> fileInfoDict = FileModel.ParseFile(filePath);
                currentKeySize = Convert.ToInt32(fileInfoDict["Key length"], 16);
                currentKey = HexStringToByteArray(fileInfoDict["Secret key"]);
                currentIV = HexStringToByteArray(fileInfoDict["Initialization vector"]);
            }
            catch (Exception)
            {
                throw new Exception(AES_KEY_FORMAT_ERROR);
            }
        }
        #endregion
    }
}
