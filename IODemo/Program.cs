using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IODemo
{
    class Program
    {
        static void Main(string[] args)
        {
            //1
            /* // File file = new File();
            FileInfo fileInfo = new FileInfo("data.txt");
            // fileInfo.Create();
            String dataString = "Lorem ipsum dolor";
            FileStream fileStream = fileInfo.OpenWrite();
            StreamWriter streamWriter = new StreamWriter(fileStream);
            streamWriter.Write(dataString);
            streamWriter.Write("!!!");
            streamWriter.Flush();
            streamWriter.Close();
            Console.ReadKey(); */

            //2
            /* FileInfo fileInfo = new FileInfo("data.txt");
            String dataString = "Lorem ipsum dolor";
            FileStream fileStream = fileInfo.OpenWrite();
            StreamWriter streamWriter = null;
            try
            {
                streamWriter = new StreamWriter(fileStream);
                streamWriter.Write(dataString);
                streamWriter.Write("!!!");
                streamWriter.Flush();
            }
            catch (Exception)
            {}
            finally {
                if (streamWriter != null)
                {
                    streamWriter.Close();
                }
            } */

            //3
            /* FileInfo fileInfo = new FileInfo("data.txt");
            String dataString = "Lorem ipsum dolor";
            FileStream fileStream = fileInfo.OpenWrite();
            StreamWriter streamWriter = null;
            using (streamWriter = new StreamWriter(fileStream))
            {
                streamWriter.Write(dataString);
                streamWriter.Write("!!!");
                streamWriter.Flush();
            }
            Console.ReadKey(); */

            //4
            FileInfo fileInfo = new FileInfo("data.txt");
            String dataString = "Lorem ipsum dolor";
            using (StreamWriter streamWriter = fileInfo.AppendText())
            {
                streamWriter.Write(dataString);
                streamWriter.Write("!!!");
                streamWriter.Flush();
            }

            using (StreamReader streamReader = new StreamReader(fileInfo.FullName))
            {
                Console.WriteLine(streamReader.ReadToEnd());
            }

            Console.ReadKey();
        }
    }
}
