using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace STMS.STMSApp
{
    class LogHelper
    {
        private static string path = "./Logs";
        public static void Write(string msg)
        {
            if(!Directory.Exists(path))
            {
                Directory.CreateDirectory(path);
            }
            File.AppendAllText(path + "./Log.txt", $"{DateTime.Now}:{msg}\r\n");
        }
    }
}
