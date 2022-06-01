using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Frontend
{
    public static class Token
    {
        private static string[] line;
        private static readonly string[] variables = { "int", "string", "double" };

        /// <summary>
        /// Gelen satırda değişken kontrolü yapar.
        /// </summary>
        /// <param name="line">Kod satırı</param>
        /// <returns></returns>
        public static bool Controls(string[] line)
        {
            Token.line = line;

            if (FirstLetter() && VariableControl() && LexicalControl())
            {
                //return "ilk karakter hatası var...";
                return true;
            }
            else
            {
                return false;
            }

        }

        /// <summary>
        /// Sadece ilk karakteri kontrol eder. Eğer rakamsal veri değilse ve rakam ile başladıysa false döner. 
        /// (int1 gibi ifade true döner bu metotta sadece ilk karakter kontrolü yapıldı.)
        /// </summary>
        /// <param name="list">Kodun diziye çevrilmiş hali</param>
        /// <returns>Token rakamsal veri değilse ilk karakteri rakam ise False döndürür.</returns>
        private static bool FirstLetter()
        {
            Regex regex = new Regex("^\\d*$"); //Sadece Rakam
            bool control = true;

            foreach (var item in Token.line)
            {
                if (regex.IsMatch(item))
                {
                    Console.WriteLine(item + " -> rakamsal veri");
                    //control = true;
                }
                else
                {
                    if (regex.IsMatch(item[0].ToString()))
                    {
                        Console.WriteLine(item + " -> düzenli ifade rakamsal veri ile başlayamaz.");
                        control = false;
                    }
                    else
                    {
                        Console.WriteLine(item + " -> düzenli ifade");
                        //control = true;
                    }
                }
            }
            return control;
        }

        /// <summary>
        /// Düzenli ifadeleri tanımlanmış değişken tipleriyle kıyaslar uygunsa true döner.
        /// </summary>
        /// <param name="list">Kodun diziye çevrilmiş hali</param>
        /// <returns>Token rakamsal veri değilse ilk karakteri rakam ise False döndürür.</returns>
        private static bool VariableControl()
        {
            bool control = true;
            foreach (var item in Token.line)
            {
                foreach (var var in variables)
                {
                    if (item.Contains(var))
                    {
                        if (item == var)
                        {
                            //Console.WriteLine("{0} -> değişken tipi bulundu.", item);
                            break;
                        }
                        else
                        {
                            //Console.WriteLine("{0} -> Hatalı değişken bulundu -> ", item);
                            control = false;
                            break;
                        }

                    }
                }
            }
            return control;
        }

        private static bool LexicalControl()
        {
            return Lexical.Analysis(Token.line);
        }

        private static bool SyntaxControl()
        {
            return Syntax.Analysis(Token.line);
        }
    }
}
