using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace Frontend
{
    public class Source
    {
        private string[] SourceText { get; set; }
        private string Line { get; set; }
        private int LineNum { get; set; }
        public Source()
        {
            this.LineNum = 0;
        }

        public void FileRead(string path)
        {
            try
            {
                this.SourceText = File.ReadAllLines(path);
            }
            catch (Exception)
            {

                throw;
            }

        }
        public int getLineNum()
        {
            return this.LineNum;
        }
        public void readline()
        {
            Line = SourceText[LineNum];
        }
        public void nextline()
        {
            LineNum++;
            readline();
        }
    }
}
