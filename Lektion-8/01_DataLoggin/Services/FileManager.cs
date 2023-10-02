using _01_DataLoggin.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_DataLoggin.Services
{
    public class FileManager : IFileManager
    {
        public string ReadFromFile(string filePath)
        {
            try
            {
                if (File.Exists(filePath))
                    return File.ReadAllText(filePath);
            }
            catch { }

            return null!;
        }

        public bool SaveToFile(string filePath, string content)
        {
            try
            {
                using StreamWriter writer = new StreamWriter(filePath);
                writer.WriteLine(content);
                return true;
            }
            catch { }

            return false;
        }
    }
}
