using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;

namespace EncryptionProject
{
    class CryptoSignature : Crypto
    {
        CryptoSHA2 cryptoSHA2;
        CryptoRSA cryptoRSA;

        public int currentDigestSize { get; private set; }
        public int currentSignatureCryptKeySize { get; private set; }

        public CryptoSignature(CryptoSHA2 cryptoSHA2, CryptoRSA cryptoRSA)
        {
            this.cryptoSHA2 = cryptoSHA2;
            this.cryptoRSA = cryptoRSA;
        }

        #region ENCRYPT
        public override byte[] Encrypt(byte[] inputData)
        {
            currentDigestSize = cryptoSHA2.GetHashSize();
            currentSignatureCryptKeySize = cryptoRSA.CurrentKeySize;
            return cryptoRSA.SignData(inputData);
        }

        public override byte[] Decrypt(byte[] inputData)
        {
            return null;
        }
        #endregion

        #region GENERATE SIGNATURE FILE
        public void GenerateOutFile(bool encryption, string inFilePath, string outFilePath)
        {
            Dictionary<string, string> fileInfoDict;
            if (encryption)
            {
                fileInfoDict = new Dictionary<string, string>();
                fileInfoDict["Description"] = "Signature";
                fileInfoDict["File name"] = inFilePath.Split('\\').Last();
                fileInfoDict["Method"] = "SHA-2;RSA";
                fileInfoDict["Signature"] = ByteArrayToHexString(
                                Encrypt(File.ReadAllBytes(inFilePath))); 
                fileInfoDict["Key length"] = IntToHexString(currentDigestSize) + ";"
                    + IntToHexString(currentSignatureCryptKeySize);

                FileModel.GenerateFile(outFilePath, fileInfoDict);
            }
            else
            {
                fileInfoDict = FileModel.ParseFile(inFilePath);
                
                byte[] bytes = Decrypt(Convert.FromBase64String(fileInfoDict["Envelope data"]));
                File.WriteAllBytes(outFilePath, bytes);
            }
        }
        #endregion

        #region SIGNATURE FILE VALIDATION
        internal bool CheckSignature(string inFilePath, string signatureFilePath, Crypto cryptoDigest)
        {
            Dictionary<string, string> fileInfoDict = FileModel.ParseFile(signatureFilePath);
            return cryptoRSA.VerifyData(File.ReadAllBytes(inFilePath), 
                                        HexStringToByteArray(fileInfoDict["Signature"]),
                                        cryptoDigest);
        }
        #endregion

    }
}
