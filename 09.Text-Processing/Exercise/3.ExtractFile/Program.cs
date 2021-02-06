using System;

namespace _3.ExtractFile
{
    class Program
    {
        static void Main(string[] args)
        {
           var filePath = Console.ReadLine().Split("\\");//we cant use split with \ so we escape it with \\
            //C:\Internal\training-internal\Template.pptx


            var lastFile = filePath[filePath.Length - 1];//last files Template.pptx
            var splitingFiles = lastFile.Split(".");//Template.pptx split
            var name = splitingFiles[0];//Template
            var extension = splitingFiles[1];//pptx

            Console.WriteLine($"File name: {name}");
            Console.WriteLine($"File extension: {extension}");
        }
    }
}
