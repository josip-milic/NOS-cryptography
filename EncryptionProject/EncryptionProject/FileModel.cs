using System;
using System.Collections.Generic;
using System.Linq;

namespace EncryptionProject
{
    public static class FileModel
    {
        #region CONSTANTS
        private static string HEADER = "---BEGIN OS2 CRYPTO DATA---";
        private static List<string> INFO = new List<string>() {
                "Description", "File name", "Method", "Key length",
                "Secret key", "Initialization vector", "Modulus",
                "Public exponent", "Private exponent", "Signature",
                "Data", "Envelope data", "Envelope crypt key", "Envelope crypt initialization vector", "DP", "DQ", "InverseQ", "P", "Q"};
        private static string INDENT = "    ";
        private static string FOOTER = "---END OS2 CRYPTO DATA---";
        #endregion

        #region GENERATE OUT FILE
        public static void GenerateFile(string filePath, Dictionary<string, string> fileInfoDict)
        {
            List<string> fileLines = new List<string>();
            fileLines.Add(HEADER);
            foreach (string fileInfo in INFO)
            {
                if (!fileInfoDict.ContainsKey(fileInfo)) continue;

                fileLines.Add(fileInfo + ":");
                string[] rows = fileInfoDict[fileInfo].Split(';');
                foreach (string row in rows)
                {
                    for (int i = 0; i < row.Length; i += 60)
                    {
                        fileLines.Add(INDENT + row.Substring(i, Math.Min(60, row.Length - i)));
                    }
                }
                fileLines.Add("\n");
            }
            fileLines.Add(FOOTER);

            System.IO.File.WriteAllLines(filePath, fileLines.ToArray<string>());
        }
        #endregion

        #region PARSE FILE
        public static Dictionary<string, string> ParseFile(string filePath)
        {
            Dictionary<string, string> fileInfoDict = new Dictionary<string, string>();

            System.IO.StreamReader file = new System.IO.StreamReader(filePath);
            bool ignore = true;
            bool newLine = false;
            string line;
            string key = "";
            string value = "";

            while ((line = file.ReadLine()) != null)
            {
                if (line.Equals(HEADER))
                {
                    ignore = false;
                    continue;
                }
                if (ignore) continue;
                if (line.Length != 0 && !line.Contains(INDENT))
                {
                    key = line.Substring(0, line.Length - 1);
                    value = "";
                }
                else if (line.Contains(INDENT))
                {
                    value += line.Substring(INDENT.Length) + ";";
                }
                else
                {
                    if (newLine)
                    {
                        newLine = false;
                        continue;
                    }
                    else newLine = true;
                    if (!"Method-Key length".Contains(key))
                    {
                        value = String.Join("", value.Split(';'));
                    }
                    else
                    {
                        value = value.Substring(0, value.Length - 1);
                    }
                    fileInfoDict[key] = value;
                }

                if (line.Equals(FOOTER)) break;
            }
            file.Close();
            return fileInfoDict;
        }
        #endregion
    }
}
