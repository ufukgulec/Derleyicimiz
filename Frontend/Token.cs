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
        private static readonly string[] variables = { "int", "string", "double" };
        private static readonly string[] operators = { "+", "-", "/", "*", "=", "(", ")", ";" };
        /// <summary>
        /// Gelen satırda değişken kontrolü yapar.
        /// </summary>
        /// <param name="line">Kod satırı</param>
        /// <returns></returns>
        public static string Controls(string[] line)
        {
            var b = FirstLetter(line);
            var a = VariableControl(line);
            string info = String.Empty;

            return info;
        }

        /// <summary>
        /// Sadece ilk karakteri kontrol eder. Eğer rakamsal veri değilse ve rakam ile başladıysa false döner. 
        /// (int1 gibi ifade true döner bu metotta sadece ilk karakter kontrolü yapıldı.)
        /// </summary>
        /// <param name="list">Kodun diziye çevrilmiş hali</param>
        /// <returns>Token rakamsal veri değilse ilk karakteri rakam ise False döndürür.</returns>
        private static bool FirstLetter(string[] list)
        {
            Regex regex = new Regex("^\\d*$"); //Sadece Rakam
            bool control = true;

            foreach (var item in list)
            {
                if (regex.IsMatch(item))
                {
                    //Console.WriteLine(item + "-> rakamsal veri");
                    control = true;
                }
                else
                {
                    if (regex.IsMatch(item[0].ToString()))
                    {
                        //Console.WriteLine(item + "-> düzenli ifade rakamsal veri ile başlayamaz");
                        control = false;
                    }
                    else
                    {
                        //Console.WriteLine(item + "-> düzenli ifade");
                        control = true;
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
        private static bool VariableControl(string[] list)
        {
            foreach (var item in list)
            {
                foreach (var var in variables)
                {
                    if (item.Contains(var))
                    {
                        if (item == var)
                        {
                            Console.WriteLine("Değişken bulundu -> " + item);
                            break;
                        }
                        else
                        {
                            Console.WriteLine("Hatalı Değişken bulundu -> " + item);
                            break;
                        }

                    }
                }
            }
            return false;
        }
    }
}
