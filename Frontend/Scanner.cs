using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Frontend
{
    public static class Scanner
    {
        static string[] SourceText { get; set; }
        public static string[] FileRead(string path)
        {
            try
            {
                SourceText = File.ReadAllLines(path);
                return SourceText;
            }
            catch (Exception)
            {

                throw;
            }
        }
        public static int FileLineNumber()
        {
            return SourceText.Length;
        }

        public static string[] ReadLine(int LineNumber)
        {
            return SourceText[LineNumber].Split(" ");
        }
    }
}
