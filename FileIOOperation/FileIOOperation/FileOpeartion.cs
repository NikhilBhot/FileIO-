using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
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
            }
            else
            {
                Console.WriteLine("File Not Fount");
            }
            Console.ReadLine();


        }
    }
}
