using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace Day.Helpers
{
    public class FileManager
    {

        public static string Save(string root, string folder, IFormFile file)
        {
            var newFileName= Guid.NewGuid().ToString()+(file.FileName.Length>64?file.FileName.Substring(file.FileName.Length - 64, 64): file.FileName);
            string path = Path.Combine(root, folder, newFileName);
            return (path);

        }

        //public static bool Delete(string root, string folder, string fileName)
        //{
        //    string path = Path.Combine(root, folder, fileName);
        //    if ()
        //    {

        //    }
        //}
    }
}
