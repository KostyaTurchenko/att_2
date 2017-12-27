using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL
{
    public class SymbolCode
    {
        private string str = null;
        public string Str
        {
            set
            {
                str = value;
            }
            get
            {
                return str;
            }
        }


        public string GetSymbol1()
        {
            int s = (int)str[0];
            string out1 = s.ToString();
            return out1;
        }
        public string GetSymbol2()
        {
            int f = (int)str[str.Length - 1];
            string out2 = f.ToString();
            return out2;
        }

        public SymbolCode(string input)
        {
            Str = input;
        }
    }
}
