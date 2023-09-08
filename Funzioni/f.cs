using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace Funzioni
{
    public class f
    {
        /*
        public static string ToString()
        {
            string sep = ";";
            return ().PadRight(100) + "##";

        }
        */

        public static void AggiuntaRecords(string line, string file, byte[] br, int RecordLength)
        {
            FileStream stream = new FileStream(file, FileMode.Open, FileAccess.ReadWrite);
            BinaryReader sr = new BinaryReader(stream);
            stream.Seek(0, SeekOrigin.Begin);
            line = Encoding.ASCII.GetString(br, 0, br.Length);
            br = Encoding.ASCII.GetBytes((line+"miovalore;cancellazione logica").PadRight(RecordLength-4) + "##");
            sr.BaseStream.Write(br, 0, br.Length);
            stream.Close();
        }
    }
}
