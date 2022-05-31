using System;
using Frontend;
using Utilities;

namespace Derleyicimiz
{
    internal class Program
    {

        static void Main(string[] args)
        {
            Source source = new Source("../../../../Kod.txt");

            int o = 1;
            while (o > 0)
            {
                var t = new TablePrinter("", "Derleyicimiz");

                t.AddRow("1", " Yazılan kodu incele");
                t.AddRow("2", " Yazılan kodu derle ve incele");
                t.AddRow("0", " Derleyici çıkış");
                t.AddRow("->", " Seçim yapınız");
                t.Print();
                o = Convert.ToInt32(Console.ReadLine());
                switch (o)
                {
                    case 1:
                        Console.WriteLine("Kodu inceleme seçeneğini seçtiniz...");
                        source.CodeView();
                        Console.WriteLine("\n");
                        break;
                    case 2:
                        Console.WriteLine("Kodu derleme seçeneğini seçtiniz...");
                        source.CodeView();
                        source.Compile();
                        Console.WriteLine("\n");
                        break;
                }
            }
        }
    }
}
