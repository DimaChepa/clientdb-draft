using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace ClientDatabase.Services
{
    internal class FileService : IFileService
    {
        public string ReadFormFile()
        {
            string fileName = string.Empty;
            if (IsJsonFileExist(out fileName))
            {
                System.IO.File.Move(fileName, $"{DateTime.Now.Day}.{DateTime.Now.Month}.{DateTime.Now.Year}.json");
                using (StreamReader stream = new StreamReader($"{DateTime.Now.Day}.{DateTime.Now.Month}.{DateTime.Now.Year}.json"))
                {
                    return stream.ReadToEnd();
                }
            }
            else
            {
                return null;
            }
        }

        public void WriteToFile(string objectForWrite)
        {
            using (StreamWriter stream = new StreamWriter($"{DateTime.Now.Day}.{DateTime.Now.Month}.{DateTime.Now.Year}.json"))
            {
                    stream.Write(objectForWrite);
            }
        }

        private bool IsJsonFileExist(out string currentFile)
        {
            bool isJsonFileExist = true;
            string[] jsonFiles = Directory.GetFiles(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), "*.json");
            if (jsonFiles.Length != 0)
            {
                currentFile = jsonFiles[0];
                isJsonFileExist = true;
            }
            else
            {
                currentFile = string.Empty;
                isJsonFileExist = false;
            }
            return isJsonFileExist;
        }
    }
}
