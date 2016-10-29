using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;

namespace EncryptionProject
{
    class CryptoRSA : Crypto
    {
        private int currentKeySize;
        private byte[] currentModulus;
        private byte[] currentPubExponent;
        private byte[] currentPrivExponent;
        RSACryptoServiceProvider RSA;
        private byte[] currentDP;
        private byte[] currentDQ;
        private byte[] currentInverseQ;
        private byte[] currentP;
        private byte[] currentQ;


        private RSAParameters currentRSAKeyInfo;

        public CryptoRSA()
        {
            RSA = new RSACryptoServiceProvider();
        }

        #region ENCRYPTION AND DECRYPTION
        public override byte[] Encrypt(byte[] inputData)
        {
            int maxLength = (int)Math.Floor(currentKeySize / 8.0) - 11;
            if (inputData.Length > maxLength)
            {
                throw new Exception(RSA_DATA_LEN_ERROR + " (" + maxLength + " bajtova)!\n" +
                    "Koristite dulji ključ.");
            }
            try
            {
                currentRSAKeyInfo = new RSAParameters();
                currentRSAKeyInfo.Modulus = currentModulus;
                currentRSAKeyInfo.Exponent = currentPubExponent;
                RSA.KeySize = currentKeySize;
                RSA.ImportParameters(currentRSAKeyInfo);
                return RSA.Encrypt(inputData, false);
            }
            catch (Exception)
            {
                throw new Exception(RSA_KEY_FORMAT_ERROR);
            }
        }

        public override byte[] Decrypt(byte[] inputData)
        {
            try
            {
                currentRSAKeyInfo = new RSAParameters();
                currentRSAKeyInfo.Modulus = currentModulus;
                currentRSAKeyInfo.Exponent = currentPubExponent;

                currentRSAKeyInfo.D = currentPrivExponent;
                currentRSAKeyInfo.DP = currentDP;
                currentRSAKeyInfo.DQ = currentDQ;
                currentRSAKeyInfo.InverseQ = currentInverseQ;
                currentRSAKeyInfo.P = currentP;
                currentRSAKeyInfo.Q = currentQ;

                RSA.KeySize = currentKeySize;
                RSA.ImportParameters(currentRSAKeyInfo);
                return RSA.Decrypt(inputData, false);
            }
            catch (Exception)
            {
                throw new Exception(WRONG_KEY_ERROR);
            }
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
                fileInfoDict["Method"] = "RSA";
                fileInfoDict["Data"] = Convert.ToBase64String(
                    Encrypt(File.ReadAllBytes(inFilePath)));
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
        public int CurrentKeySize
        {
            get { return currentKeySize; }
        }
        #endregion

        #region SIGNING
        public byte[] SignData(byte[] inputData)
        {
            currentRSAKeyInfo = new RSAParameters();
            currentRSAKeyInfo.Modulus = currentModulus;
            currentRSAKeyInfo.Exponent = currentPubExponent;

            currentRSAKeyInfo.D = currentPrivExponent;

            currentRSAKeyInfo.DP = currentDP;
            currentRSAKeyInfo.DQ = currentDQ;
            currentRSAKeyInfo.InverseQ = currentInverseQ;
            currentRSAKeyInfo.P = currentP;
            currentRSAKeyInfo.Q = currentQ;

            RSA.KeySize = currentKeySize;
            try
            {
                RSA.ImportParameters(currentRSAKeyInfo);
                return RSA.SignData(inputData, CryptoConfig.MapNameToOID("SHA256"));
            }
            catch (Exception)
            {
                throw new Exception(RSA_KEY_FORMAT_ERROR);
            }
        }

        public bool VerifyData(byte[] bytesToVerify, byte[] signedBytes, Crypto cryptoDigest)
        {
            currentRSAKeyInfo = new RSAParameters();

            currentRSAKeyInfo.Modulus = currentModulus;
            currentRSAKeyInfo.Exponent = currentPubExponent;
            RSA.KeySize = currentKeySize;
            try
            {
                RSA.ImportParameters(currentRSAKeyInfo);

                byte[] hashedData = cryptoDigest.Encrypt(bytesToVerify);

                bool success = RSA.VerifyData(bytesToVerify, CryptoConfig.MapNameToOID("SHA256"), signedBytes);

                return success;
            }
            catch (Exception)
            {
                throw new Exception(WRONG_KEY_ERROR);
            }
        }
        #endregion

        #region GENERATE KEY FILES
        private void GeneratePubKeyFile(string filePath)
        {
            Dictionary<string, string> fileInfoDict = new Dictionary<string, string>();

            fileInfoDict["Description"] = "Public key";
            fileInfoDict["Method"] = "RSA";
            fileInfoDict["Key length"] = IntToHexString(currentKeySize);
            fileInfoDict["Modulus"] = ByteArrayToHexString(currentModulus);
            fileInfoDict["Public exponent"] = ByteArrayToHexString(currentPubExponent);

            FileModel.GenerateFile(filePath, fileInfoDict);
        }

        private void GeneratePrivKeyFile(string filePath)
        {
            Dictionary<string, string> fileInfoDict = new Dictionary<string, string>();

            fileInfoDict["Description"] = "Private key";
            fileInfoDict["Method"] = "RSA";
            fileInfoDict["Key length"] = IntToHexString(currentKeySize);
            fileInfoDict["Modulus"] = ByteArrayToHexString(currentModulus);
            fileInfoDict["Private exponent"] = ByteArrayToHexString(currentPrivExponent);
            fileInfoDict["DP"] = ByteArrayToHexString(currentDP);
            fileInfoDict["DQ"] = ByteArrayToHexString(currentDQ);
            fileInfoDict["InverseQ"] = ByteArrayToHexString(currentInverseQ);
            fileInfoDict["P"] = ByteArrayToHexString(currentP);
            fileInfoDict["Q"] = ByteArrayToHexString(currentQ);

            FileModel.GenerateFile(filePath, fileInfoDict);
        }

        private void GenerateNewKeys(int keySize)
        {
            currentKeySize = keySize;
            RSA = new RSACryptoServiceProvider(keySize);
            RSAParameters RSAKeyInfo = RSA.ExportParameters(false);
            currentRSAKeyInfo = RSAKeyInfo;

            currentModulus = RSAKeyInfo.Modulus;
            currentPubExponent = RSAKeyInfo.Exponent;

            RSAKeyInfo = RSA.ExportParameters(true);
            currentPrivExponent = RSAKeyInfo.D;
            currentDP = RSAKeyInfo.DP;
            currentDQ = RSAKeyInfo.DQ;
            currentInverseQ = RSAKeyInfo.InverseQ;
            currentP = RSAKeyInfo.P;
            currentQ = RSAKeyInfo.Q;
        }


        public void GenerateKeyFiles(int keySize, string pubKeyFilePath, string privKeyFilePath)
        {
            GenerateNewKeys(keySize);
            GeneratePubKeyFile(pubKeyFilePath);
            GeneratePrivKeyFile(privKeyFilePath);
        }
        #endregion

        #region PARSE KEY FILES
        public void ParsePubKeyFile(string filePath)
        {
            Dictionary<string, string> fileInfoDict = FileModel.ParseFile(filePath);
            currentKeySize = Convert.ToInt32(fileInfoDict["Key length"], 16);
            currentModulus = HexStringToByteArray(fileInfoDict["Modulus"]);
            currentPubExponent = HexStringToByteArray(fileInfoDict["Public exponent"]);

            currentRSAKeyInfo = new RSAParameters();
            currentRSAKeyInfo.Modulus = currentModulus;
            currentRSAKeyInfo.Exponent = currentPubExponent;

            currentPrivExponent = null;
            currentDP = null;
            currentDQ = null;
            currentInverseQ = null;
            currentP = null;
            currentQ = null;
        }

        public void ParsePrivKeyFile(string filePath)
        {
            Dictionary<string, string> fileInfoDict = FileModel.ParseFile(filePath);

            currentKeySize = Convert.ToInt32(fileInfoDict["Key length"], 16);
            currentModulus = HexStringToByteArray(fileInfoDict["Modulus"]);
            currentPrivExponent = HexStringToByteArray(fileInfoDict["Private exponent"]);
            currentDP = HexStringToByteArray(fileInfoDict["DP"]);
            currentDQ = HexStringToByteArray(fileInfoDict["DQ"]);
            currentInverseQ = HexStringToByteArray(fileInfoDict["InverseQ"]);
            currentP = HexStringToByteArray(fileInfoDict["P"]);
            currentQ = HexStringToByteArray(fileInfoDict["Q"]);
        }
        #endregion
    }
}
