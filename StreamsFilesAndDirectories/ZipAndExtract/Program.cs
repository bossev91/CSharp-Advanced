using System;
using System.IO.Compression;

namespace ZipAndExtract
{
    class Program
    {
        static void Main(string[] args)
        {
            ZipFile.CreateFromDirectory(@"D:\ZipFileDemo", @"D:\ZipFileEx\MyZipFile.zip"); 
            ZipFile.ExtractToDirectory(@"D:\ZipFileEx\MyZipFile.zip", @"D:\ZipFileEx\"); 
            
        }
    }
}