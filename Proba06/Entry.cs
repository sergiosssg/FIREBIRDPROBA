using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proba06
{
    class Entry
    {
        public static void Main(string[] sArgs )
        {
            string sGreeting = "Hello from proba";

            Console.WriteLine("{0}", sGreeting);

            // (string sServer, string sCharset, string sUserLogin, string sPassword, string sDB)
            Class1.InitDBConnection("devel2.frunze.local:sampd_cexs", "WIN1251", "STAVITSKIY_S", "q1w2e3", "sampd_cexs");

        }
    }
}
