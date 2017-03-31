using System;
using System.IO;

namespace DojoCMS 
{
    public class FileManager
    {

        public static void MakeUserDirectory(string UserName)
        {
            string PathString = Directory.GetCurrentDirectory();
            PathString = Path.Combine(PathString, UserName);
            System.IO.Directory.CreateDirectory(PathString);
            
        }

        public static void MakeUserViewsDirectory(string UserName, string PageName)
        {
            string PathString = Directory.GetCurrentDirectory();
            PathString = Path.Combine(PathString, UserName, PageName);
            System.IO.Directory.CreateDirectory(PathString);
        }
        public static void MakePageFile(String UserName, String PageName, String HTMLString)
        {
        
            String PathString = String.Format("{0}/{1}.cshml",Directory.GetCurrentDirectory(),PageName);
            Console.WriteLine(PathString);
            Console.WriteLine(PageName);
            Console.ReadLine();

            System.IO.File.WriteAllText(PathString, HTMLString);
            File.SetAttributes(PathString, FileAttributes.Normal);
        }
    }
}