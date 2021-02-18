using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileQuest
{
    class Program
    {
        static void List1(string miesto, string najdito)
        {
            try
            {
                IEnumerable<string> fileNames = Directory.GetFiles(miesto, najdito);
                IEnumerable<FileInfo> fileInfos = fileNames.Select(f => new FileInfo(f));
                foreach (FileInfo fileInfo in fileInfos)
                {
                    Console.WriteLine($@"{fileInfo.Name}({fileInfo.LastWriteTime})");
                }
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        public static IEnumerable<string> GetFiles(string path, string srcPatters)
        {
            var files = Directory.EnumerateFiles(path, srcPatters);
            return files;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("zadajte adresu cieloveho suboru");
            var path = Path.Combine(Console.ReadLine());
            List1(path, "*");
            Console.ReadLine();
        }
    }
}
