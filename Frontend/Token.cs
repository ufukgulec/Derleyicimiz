using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Frontend
{
    public class Token
    {
        protected string text;
        protected object value;
        protected Source source;
        protected int lineNum;

        private readonly string[] tokens = { "asd", "asd", "asd" };
        public Token(Source source)
        {

            this.source = source;
            lineNum = source.getLineNum();

            extract();
        }
        protected void extract()
        {

        }

    }
}
