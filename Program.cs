using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace FolderFileListCheck
{
    class Program
    {
        static void Main(string[] args)
        {
            FoldersInDirectory(@"D:\");
            Console.WriteLine("Press Enter to Continue");
            Console.Read();

            FilesInDirectory(@"D:\");
            Console.WriteLine("Press Enter to Continue");
            Console.Read();

        }

        static void FoldersInDirectory(string workingDirectory)
        {
            string[] folderPaths = Directory.GetDirectories(workingDirectory);
         

            foreach (string folderPath in folderPaths)
            {
                Console.WriteLine(folderPath);
            }
        }

        static void FilesInDirectory(string workingFiles)
        {
            string[] filePaths = Directory.GetFiles(workingFiles);


            foreach (string filePath in filePaths)
            {
                Console.WriteLine(filePath);
            }
        }

    }
}
