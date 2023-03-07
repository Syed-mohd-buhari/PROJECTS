using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace FileReader_From_Folder
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Getting Path 
            string Path = "C:\\Users\\syedmoha\\PROJECT_VIO\\XmlFiles";

            //Calling Method & Pass the Path
            ListFilesInDirectory(Path);
        }
        
        public static void ListFilesInDirectory(string get)
        {
            try
            {
                //Getting all Files From Directory and Store in FilePath
                string[] FilePath = Directory.GetFiles(get);
                foreach(var Files in FilePath)
                {
                    Console.WriteLine(Files);
                }
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
            Console.ReadKey();
        }
    
    }
}
