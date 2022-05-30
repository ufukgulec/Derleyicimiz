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
        private static readonly string[] tokens = { "int", "string", "double" };
        private static readonly string[] operators = { "+", "-", "/", "*", "=", "(", ")", ";" };
        /// <summary>
        /// Gelen satırda değişken kontrolü yapar.
        /// </summary>
        /// <param name="line">Kod satırı</param>
        /// <returns></returns>
        public static string Controls(string[] line)
        {
            FirstLetter(line);

            string info = String.Empty;
            foreach (var item in line)
            {
                foreach (var token in tokens)
                {
                    if (item.Contains(token))
                    {
                        if (item == token)
                        {
                            info = token;
                        }
                        else
                        {
                            info = "hatalı";
                        }

                    }
                    else
                    {
                        info = "tanımlanmamış";
                    }
                }
            }
            return info;
        }

        private static void FirstLetter(string[] tokens)
        {
            bool status = true;
            foreach (var item in tokens)
            {
                Regex regex = new Regex("[0-9]"   );
            }
        }
    }
}
