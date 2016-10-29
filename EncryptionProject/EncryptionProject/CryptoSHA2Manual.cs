using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;

namespace EncryptionProject
{
    class CryptoSHA2Manual : Crypto
    {
        private int currentHashSize;
        private string currentDataString;

        #region CONSTANTS
        private UInt32[] H;

        private UInt32[] K = new UInt32[]
        {
            0x428a2f98, 0x71374491, 0xb5c0fbcf, 0xe9b5dba5,
            0x3956c25b, 0x59f111f1, 0x923f82a4, 0xab1c5ed5,
            0xd807aa98, 0x12835b01, 0x243185be, 0x550c7dc3,
            0x72be5d74, 0x80deb1fe, 0x9bdc06a7, 0xc19bf174,
            0xe49b69c1, 0xefbe4786, 0x0fc19dc6, 0x240ca1cc,
            0x2de92c6f, 0x4a7484aa, 0x5cb0a9dc, 0x76f988da,
            0x983e5152, 0xa831c66d, 0xb00327c8, 0xbf597fc7,
            0xc6e00bf3, 0xd5a79147, 0x06ca6351, 0x14292967,
            0x27b70a85, 0x2e1b2138, 0x4d2c6dfc, 0x53380d13,
            0x650a7354, 0x766a0abb, 0x81c2c92e, 0x92722c85,
            0xa2bfe8a1, 0xa81a664b, 0xc24b8b70, 0xc76c51a3,
            0xd192e819, 0xd6990624, 0xf40e3585, 0x106aa070,
            0x19a4c116, 0x1e376c08, 0x2748774c, 0x34b0bcb5,
            0x391c0cb3, 0x4ed8aa4a, 0x5b9cca4f, 0x682e6ff3,
            0x748f82ee, 0x78a5636f, 0x84c87814, 0x8cc70208,
            0x90befffa, 0xa4506ceb, 0xbef9a3f7, 0xc67178f2
        };

        private void InitializeH()
        {
            H = new UInt32[]
            {
                0x6a09e667,
                0xbb67ae85,
                0x3c6ef372,
                0xa54ff53a,
                0x510e527f,
                0x9b05688c,
                0x1f83d9ab,
                0x5be0cd19
            };
        }

        private int N = 64;
        #endregion

        public CryptoSHA2Manual()
        {
            currentHashSize = 256;
            InitializeH();
        }

        #region SHA2 ALGORITHM SPECIFIC METHODS
        private UInt32 RotR(UInt32 A, int n)
        {
            return (A >> n) | (A << (32 - n));
        }

        private UInt32 ShR(UInt32 A, int n)
        {
            return A >> n;
        }

        private UInt32 Ch(UInt32 X, UInt32 Y, UInt32 Z)
        {
            UInt32 xinv = ~X;
            return (X & Y) ^ (xinv & Z);
        }

        private UInt32 Maj(UInt32 X, UInt32 Y, UInt32 Z)
        {
            return (X & Y) ^ (X & Z) ^ (Y & Z);
        }

        private UInt32 Sum0(UInt32 X)
        {
            return RotR(X, 2) ^ RotR(X, 13) ^ RotR(X, 22);
        }

        private UInt32 Sum1(UInt32 X)
        {
            return RotR(X, 6) ^ RotR(X, 11) ^ RotR(X, 25);
        }

        private UInt32 Sigma0(UInt32 X)
        {
            return RotR(X, 7) ^ RotR(X, 18) ^ ShR(X, 3);
        }

        private UInt32 Sigma1(UInt32 X)
        {
            return RotR(X, 17) ^ RotR(X, 19) ^ ShR(X, 10);
        }

        private UInt32[] ConstructW(UInt32[] M)
        {
            UInt32[] W = new UInt32[64];
            for (int i = 0; i < 64; ++i)
            {
                if (i < 16) W[i] = M[i];
                else
                {
                    W[i] = Sigma1(W[i - 2]) + W[i - 7]
                         + Sigma0(W[i - 15]) + W[i - 16];
                }

            }
            return W;
        }
        #endregion

        #region COMPUTE HASH
        private void ComputeHash(UInt32[] M)
        {
            UInt32[] W = ConstructW(M);
            UInt32 a, b, c, d, e, f, g, h, T1, T2;
            a = H[0]; b = H[1]; c = H[2]; d = H[3];
            e = H[4]; f = H[5]; g = H[6]; h = H[7];
            for (int t = 0; t < N; t++)
            {
                T1 = h + Sum1(e) + Ch(e, f, g) + K[t] + W[t];
                T2 = Sum0(a) + Maj(a, b, c);
                h = g; g = f; f = e; e = d + T1;
                d = c; c = b; b = a; a = T1 + T2;
            }
            H[0] = a + H[0]; H[1] = b + H[1]; H[2] = c + H[2];
            H[3] = d + H[3]; H[4] = e + H[4]; H[5] = f + H[5];
            H[6] = g + H[6]; H[7] = h + H[7];
        }
        #endregion

        #region ENCRYPT
        public override byte[] Encrypt(byte[] inputData)
        {
            int inputDataLength = inputData.Length;
            UInt64 length = (UInt64)(inputDataLength * 8);

            for (int subInd = 0; subInd < inputDataLength; subInd += 64)
            {
                byte[] data = new byte[64];
                int remainingLength = inputDataLength - subInd;
                if (remainingLength < 64)
                {
                    Array.Copy(inputData, subInd, data, 0, remainingLength);
                    data[remainingLength] = 0x80;
                    if (remainingLength > 56)
                    {
                        ComputeHash(ByteArrayToUInt32Array(data));
                        data = new byte[64];
                    }

                    for (int i = data.Length - 1; i >= data.Length - 8; i--)
                    {
                        data[i] = (byte)length;
                        length >>= 8;
                    }
                }
                else
                {
                    Array.Copy(inputData, subInd, data, 0, 64);
                }
                ComputeHash(ByteArrayToUInt32Array(data));
            }
            if (inputDataLength % 64 == 0)
            {
                byte[] data = new byte[64];
                data[0] = 0x80;
                
                for (int i = data.Length - 1; i >= data.Length - 8; i--)
                {
                    data[i] = (byte)length;
                    length >>= 8;
                }
                ComputeHash(ByteArrayToUInt32Array(data));
            }


            return UInt32ArraytoByteArray(Array.AsReadOnly(H)).ToArray<byte>();
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
                InitializeH();
                Dictionary<string, string> fileInfoDict = new Dictionary<string, string>();
                fileInfoDict["Description"] = "Digest";
                fileInfoDict["File name"] = inFilePath.Split('\\').Last();
                fileInfoDict["Method"] = "SHA-2 Manual";
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
