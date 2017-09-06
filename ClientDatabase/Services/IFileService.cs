using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClientDatabase.Models;
using Newtonsoft.Json.Linq;

namespace ClientDatabase.Services
{
    internal interface IFileService
    {
        void WriteToFile(string objectForWrite);
        string ReadFormFile();
    }
}
