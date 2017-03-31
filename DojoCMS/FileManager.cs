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
        public static void MakePageFile(string UserName, string PageName, string HTMLString)
        {
            MakeUserDirectory(String.Format(Directory.GetCurrentDirectory() +  "/{0}", UserName));
            string PathString = String.Format(Directory.GetCurrentDirectory() +  "/{0}.csthml",PageName);

            System.IO.File.WriteAllText(PathString, HTMLString);
            File.SetAttributes(PathString, FileAttributes.Normal);
        }
    }
}