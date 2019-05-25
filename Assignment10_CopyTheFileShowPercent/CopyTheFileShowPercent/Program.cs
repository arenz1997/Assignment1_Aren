using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace CopyTheFileShowPercent
{
    class Program
    {
        static bool done = false;
        static string fileName = "SourceTextFile.txt";
        static string sourcePath = @"C:\Users\arenz\source\repos\CopyTheFileShowPercent\CopyTheFileShowPercent\Resources\";
        static string targetPath = @"C:\Users\arenz\source\repos\CopyTheFileShowPercent\CopyTheFileShowPercent\Resources\CopiedFiles\";
        static string sourceFile = Path.Combine(sourcePath, fileName);
        static string destFile = Path.Combine(targetPath, fileName);
        static int percent = 0;

        static void CopyTheFile()
        {
            int bufferSize = 1024 * 512;
            using (FileStream inStream = new FileStream(sourceFile, FileMode.Open, FileAccess.Read, FileShare.ReadWrite))
            using (FileStream fileStream = new FileStream(destFile, FileMode.OpenOrCreate, FileAccess.Write))
            {

                int bytesRead = -1;
                double totalReads = 0;
                double totalBytes = inStream.Length;
                byte[] bytes = new byte[bufferSize];

                while ((bytesRead = inStream.Read(bytes, 0, bufferSize)) > 0)
                {
                    fileStream.Write(bytes, 0, bytesRead);
                    totalReads += bytesRead;

                    if (percent != Convert.ToInt32((totalReads / totalBytes) * 100))
                    {
                        Console.Clear();
                        Console.WriteLine(percent + "%\t" + (int)totalReads/1048576 + "/" + (int)totalBytes/ 1048576 + " MegaBytes has copied");
                    }
                    Thread.Sleep(1);
                    percent = Convert.ToInt32((totalReads / totalBytes) * 100);
                }
                Console.Clear();
                Console.WriteLine("100%\nThe file is copied!!!");
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Press 'PauseBreak' for pause the copying process\n\nPress any key to start copying");
            Console.ReadKey();
            CopyTheFile();
            
        }
    }
}