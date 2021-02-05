using FirebirdSql.Data.FirebirdClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proba06
{
    
    
    class Class1
    {
        static private FbConnection fbConnection = null;
        static private FbConnectionStringBuilder fb;

        public static void InitDBConnection(string sServer, string sCharset, string sUserLogin, string sPassword, string sDB)
        {
            try
            {

                fb = new FbConnectionStringBuilder();

                // devel2.frunze.local:sampd_cexs
                fb.ConnectionString = sServer + ":" + sDB;
                fb.Charset = sCharset;
                fb.UserID = sUserLogin;
                fb.Password = sPassword;

                var fbconn = new FbConnection(fb.ToString());

                Type typ = fbconn.GetType();


                Console.WriteLine(typ.ToString());


            }
            catch (Exception ex)
            {
                Type tOfEx = ex.GetType();
                Console.WriteLine("Error Type is {0}", tOfEx);
                Console.WriteLine("============================");
                Console.WriteLine("Error message is {0}", ex.Message);
            }
        }




        static public FbConnection FirebirdConnection
        {
            get
            {
                return fbConnection;
            }
        }
    }
}
