using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Frontend
{
    public static class Syntax
    {
        public static bool Analysis(List<string> words)
        {
            Console.WriteLine(" \nSyntax Satır dizilimi:");
            foreach (var item in words)
            {
                Console.WriteLine(item);
            }
            return true;
        }
    }
}
