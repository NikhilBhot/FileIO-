using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Security.AccessControl;

namespace FileIOOperation
{
    public class FileOpeartion
    {
        //Check The File Is Available Or Not
        public static void FileExistOrNot()
        {
            string path = @"D:\\BridgeLabz-RFP260\\Learning\\FileIO-\\FileIOOperation\\FileIOOperation\\Data.text";
            //@ verbitim literal

            if (File.Exists(path))
            {
                Console.WriteLine("Yes...! there is File");
                ReadDataFromFile(path);
                CopyTextFile(path);
            }
            else
            {
                Console.WriteLine("File Not Fount");
            }
            Console.ReadLine();
        }

        //Read The Data From Text File
        public static void ReadDataFromFile(string path)
        {
            string data=File.ReadAllText(path);
            Console.WriteLine(data);
        }

        //Copy Text File
        public static void CopyTextFile(string path)
        {
            string path1= @"D:\\BridgeLabz-RFP260\\Learning\\FileIO-\\FileIOOperation\\FileIOOperation\\Data1.text";
            File.Copy(path, path1);
        }
    }
}
