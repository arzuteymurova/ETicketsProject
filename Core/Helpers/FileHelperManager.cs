using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Helpers
{
    public static class FileHelperManager
    {
        public static string Add(IFormFile file, string path)
        {
            var sourcepath = Path.GetTempFileName();

            if (file.Length > 0)
                using (var stream = new FileStream(sourcepath, FileMode.Create))
                {
                    file.CopyTo(stream);
                }

            File.Move(sourcepath, path);
            return path;
        }

        public static string Update(string pathToUpdate, IFormFile file, string path)
        {
            if (path.Length > 0)
                using (var stream = new FileStream(path, FileMode.Create))
                {
                    file.CopyTo(stream);
                }

            File.Delete(pathToUpdate);
            return path;
        }

        public static void Delete(string path)
        {
            if (File.Exists(path))
                File.Delete(path);
        }

        public static string CreateNewPath(IFormFile file)
        {
            var fileInfo = new FileInfo(file.FileName);
            var newPath =
                $@"{Environment.CurrentDirectory}\wwwroot\Uploads\Images\MovieImages\{Guid.NewGuid()}_{DateTime.Now.Month}_{DateTime.Now.Day}_{DateTime.Now.Year}{fileInfo.Extension}";

            return newPath;
        }

    }
}
