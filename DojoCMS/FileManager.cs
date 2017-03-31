using System;
using System.IO;

namespace DojoCMS 
{
    public class FileManager
    {

        
        public static void MakeUserDirectory(string UserName)
        {
            string PathString = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.FullName;
            Path.Combine(PathString, UserName);
            System.IO.Directory.CreateDirectory(PathString);
        }
        public static void MakeUserViewsDirectory(string UserName, string PageName)
        {
            string PathString = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.FullName;
            Path.Combine(PathString, UserName, PageName);
            System.IO.Directory.CreateDirectory(PathString);
        }
        public static void MakePageFile(string UserName, string PageName, string HTMLString)
        {
            string PathString = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.FullName;
            Path.Combine(PathString, UserName, PageName, ".cshtml");
            
            System.IO.File.WriteAllText(PathString, HTMLString);
            File.SetAttributes(PathString, FileAttributes.Normal);
        }
        static void WriteToFile(string PageText)
        {

        }
    }
}