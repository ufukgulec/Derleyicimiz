using System;
using Frontend;

namespace Derleyicimiz
{
    internal class Program
    {

        static void Main(string[] args)
        {
            Source source = new Source("../../../../Kod.txt");

            source.CodeView();

            source.ReadLine();

        }
    }
}
