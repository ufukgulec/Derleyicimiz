using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Utilities;

namespace Frontend
{
    public class Source
    {
        private string[] SourceText { get; set; }
        private string[] Line { get; set; }
        private int LineNumber { get; set; }
        /// <summary>
        /// Verilen dizinle kodu işleme alır.
        /// </summary>
        /// <param name="path">Kod dizinini veriniz.</param>
        public Source(string path)
        {
            this.LineNumber = 0;
            this.SourceText = Scanner.FileRead(path);
        }
        /// <summary>
        /// Text dosyasındaki kodu yazar.
        /// </summary>
        public void CodeView()
        {
            var t = new TablePrinter("", "Text Dosyasındaki kodunuz");
            for (int i = 0; i < SourceText.Length; i++)
            {
                t.AddRow(i + 1, SourceText[i]);
            }
            t.AddRow("---", "--------------");
            t.AddRow("->", String.Format("Kodunuz {0} satır", Scanner.FileLineNumber()));
            t.Print();

        }
        public int getLineNum()
        {
            return this.LineNumber;
        }
        /// <summary>
        /// Satır okuma işlemi
        /// </summary>
        public void ReadLine()
        {
            if (LineNumber < Scanner.FileLineNumber())
            {
                Line = Scanner.ReadLine(this.LineNumber);
                ControlLine(Line);//Satırda değişken kontrolü 
            }
            else
            {
                Console.WriteLine("------kod buraya kadar----");
            }
        }

        private void ControlLine(string[] line)
        {
            //Console.WriteLine(String.Format("{0}. satırda {1} değişken tipi bulundu.", LineNumber + 1, Token.Controls(line)));
            Token.Controls(line);
            Nextline();
        }

        public void Nextline()
        {
            LineNumber++;
            ReadLine();
        }

    }
}
