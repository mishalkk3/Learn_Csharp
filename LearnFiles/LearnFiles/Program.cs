using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace LearnFiles
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            var srcpath = @"D:\shahil.pdf";
            var destpath = @"D:\test1\shahil1.pdf";

            Console.WriteLine(File.Exists(srcpath));
            File.Copy(srcpath, destpath,true); //true override if file exist
            var content = File.ReadAllText(destpath);
            Console.WriteLine(content);
            File.Delete(srcpath);
            */

            /*
            var newdirpath = @"D:\New folder (2)\folder1";
            Directory.CreateDirectory(newdirpath);
            var files = Directory.GetFiles(@"D:\movie\english","*.mkv",SearchOption.TopDirectoryOnly);
            foreach (var file in files)
            {
                Console.WriteLine(file);
            }

            Console.WriteLine("--------------------------------------------------");

            var folders = Directory.GetDirectories(@"D:\movie\english", "*.*",SearchOption.AllDirectories);
            foreach (var folder in folders)
            {
                Console.WriteLine(folder);
            }
            */

            var destpath = @"D:\test1\shahil1.pdf";
            var extension = Path.GetExtension(destpath);
            Console.WriteLine("extension: "+extension);
            Console.WriteLine("File Name: "+Path.GetFileName(destpath));
            Console.WriteLine("DIR NAme: "+Path.GetDirectoryName(destpath));
        }
    }
}
