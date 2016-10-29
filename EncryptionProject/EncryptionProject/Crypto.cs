using System;
using System.Collections.ObjectModel;
using System.Text;

namespace EncryptionProject
{
    public abstract class Crypto
    {
        #region ERRORS AND MESSAGES

        public static string AES_KEY_FORMAT_ERROR = "Format simetričnog ključa nije ispravan!\n" +
                    "Provjerite sljedeća pravila:\n\n" +
                    "Duljina ključa mora biti jednaka napisanoj.\n" +
                    "Duljina inicijalizacijskog vektora mora biti jednaka 128 bita.\n" +
                    "Ključ, njegova duljina i IV moraju biti prikazani u heksadekadskom prikazu.";
        public static string RSA_KEY_FORMAT_ERROR = "Format ključa nije ispravan!\n" +
                    "Provjerite sljedeća pravila:\n\n" +
                    "Duljina ključa mora biti jednaka napisanoj.\n" +
                    "Ključ odnosno njegovi parametri i njegova duljina moraju "+
                    "biti prikazani u heksadekadskom prikazu.";
        public static string WRONG_KEY_ERROR = "Ključ ne odgovara kriptiranoj datoteci!";
        public static string RSA_DATA_LEN_ERROR = "Duljina poruke koja se želi kriptirati je veća od "+
                    "maksimalne dopuštene dužine za trenutno korišteni ključ";
        #endregion

        #region HELPER METHODS
        public string IntToHexString(int n)
        {
            string converted = n.ToString("X");
            return converted.Length % 2 == 0 ? converted : "0" + converted;
        }

        public string ByteArrayToHexString(byte[] byteArray)
        {
            StringBuilder result = new StringBuilder();
            foreach (byte b in byteArray)
            {
                result.Append(b.ToString("x2"));
            }
            return result.ToString();
        }

        public byte[] HexStringToByteArray(String hex)
        {
            int length = hex.Length;
            byte[] bytes = new byte[length / 2];
            for (int i = 0; i < length; i += 2)
            {
                bytes[i / 2] = Convert.ToByte(hex.Substring(i, 2), 16);
            }
            return bytes;
        }

        public UInt32[] ByteArrayToUInt32Array(byte[] byteArray)
        {
            UInt32[] result = new UInt32[16];
            for (uint i = 0, j = 0; i < result.Length; i++, j += 4)
            {
                result[i] = ((UInt32) byteArray[j + 0] << 24) 
                          | ((UInt32) byteArray[j + 1] << 16) 
                          | ((UInt32) byteArray[j + 2] << 8) 
                          | ((UInt32) byteArray[j + 3]);
            }
            return result;
        }

        public ReadOnlyCollection<byte> UInt32ArraytoByteArray(ReadOnlyCollection<UInt32> uintArray)
        {
            byte[] dest = new byte[uintArray.Count * 4];
            int pos = 0;

            for (int i = 0; i < uintArray.Count; ++i)
            {
                dest[pos++] = (byte) (uintArray[i] >> 24);
                dest[pos++] = (byte) (uintArray[i] >> 16);
                dest[pos++] = (byte) (uintArray[i] >> 8);
                dest[pos++] = (byte) (uintArray[i]);
            }

            return Array.AsReadOnly(dest);
        }
        #endregion

        #region ABSTRACT METHODS
        public abstract byte[] Encrypt(byte[] inputData);

        public abstract byte[] Decrypt(byte[] inputData);
        #endregion
    }
}
