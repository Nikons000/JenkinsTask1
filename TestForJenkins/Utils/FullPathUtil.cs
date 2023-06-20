using System;
using System.IO;

namespace Task1
{
    class FullPathUtil
    {
        public static string GetFullPath(string path)
        {
            var currentDirectory = AppDomain.CurrentDomain.BaseDirectory;
            var relativePath = path;
            var fullPath = Path.Combine(currentDirectory, relativePath);
            return fullPath;
        }
    }
}
