using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieReviewProgram.Model
{
    class LogWriter
    {
        public static void PrintLog(string contents)
        {
            DirectoryInfo di = new DirectoryInfo("ProgramHistory");
            if (!di.Exists)
            {
                di.Create();
            }

            using (StreamWriter writer = new StreamWriter("ProgramHistory" + "\\" + DateTime.Now.ToString("yyyy-MM-dd") + ".txt", true))
            {
                writer.WriteLine($"[{DateTime.Now.ToString("yyyy-MM-dd hh:mm:ss.fff")}]" + contents);
            }
        }
    }
}
