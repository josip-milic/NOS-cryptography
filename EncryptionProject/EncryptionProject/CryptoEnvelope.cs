using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;

namespace EncryptionProject
{
    class CryptoEnvelope : Crypto
    {
        CryptoAES cryptoAES;
        CryptoRSA cryptoRSA;

        int currentSymKeySize;
        byte[] currentSymKey;
        byte[] currentSymIV;

        byte[] currentEnvelopeData;
        int currentEnvelopeCryptKeySize;
        byte[] currentEnvelopeCryptKey;
        byte[] currentEnvelopeCryptIV;

        public CryptoEnvelope(CryptoAES cryptoAES, CryptoRSA cryptoRSA)
        {
            this.cryptoAES = cryptoAES;
            this.cryptoRSA = cryptoRSA;
            currentSymKeySize = cryptoAES.CurrentKeySize = 128;
        }

        #region ENCRYPT AND DECRYPT
        public override byte[] Encrypt(byte[] inputData)
        {
            cryptoAES.GenerateNewKey();
            currentSymKey = cryptoAES.CurrentKey;
            currentSymIV = cryptoAES.CurrentIV;

            currentEnvelopeData = cryptoAES.Encrypt(inputData);

            currentEnvelopeCryptKeySize = cryptoRSA.CurrentKeySize;
            currentEnvelopeCryptKey = cryptoRSA.Encrypt(currentSymKey);
            currentEnvelopeCryptIV = cryptoRSA.Encrypt(currentSymIV);

            return currentEnvelopeData;
        }

        public override byte[] Decrypt(byte[] inputData)
        {
            cryptoAES.CurrentKeySize = currentSymKeySize;
            cryptoAES.CurrentKey = currentSymKey;
            cryptoAES.CurrentIV = currentSymIV;
            return cryptoAES.Decrypt(inputData);
        }
        #endregion

        #region GENERATE ENCRYPTED OR DECRYPTED FILE
        public void GenerateOutFile(bool encryption, string inFilePath, string outFilePath)
        {
            Dictionary<string, string> fileInfoDict;
            if (encryption)
            {
                fileInfoDict = new Dictionary<string, string>();
                fileInfoDict["Description"] = "Envelope";
                fileInfoDict["File name"] = inFilePath.Split('\\').Last();
                fileInfoDict["Method"] = "AES;RSA";
                fileInfoDict["Envelope data"] = Convert.ToBase64String(
                                Encrypt(File.ReadAllBytes(inFilePath)));
                fileInfoDict["Key length"] = IntToHexString(currentSymKeySize) + ";"
                    + IntToHexString(currentEnvelopeCryptKeySize);
                fileInfoDict["Envelope crypt key"] = ByteArrayToHexString(currentEnvelopeCryptKey);
                fileInfoDict["Envelope crypt initialization vector"] = ByteArrayToHexString(currentEnvelopeCryptIV);

                FileModel.GenerateFile(outFilePath, fileInfoDict);
            }
            else
            {
                fileInfoDict = FileModel.ParseFile(inFilePath);
                currentSymKey = cryptoRSA.Decrypt(HexStringToByteArray(fileInfoDict["Envelope crypt key"]));
                currentSymIV = cryptoRSA.Decrypt(HexStringToByteArray(fileInfoDict["Envelope crypt initialization vector"]));

                byte[] bytes = Decrypt(Convert.FromBase64String(fileInfoDict["Envelope data"]));
                File.WriteAllBytes(outFilePath, bytes);
            }
        }
        #endregion
    }
}
