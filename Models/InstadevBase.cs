using System.IO;

namespace Instadev_06.Models
{
    public class InstadevBase
    {
        public void CreateFolderAndFile(string path)
        {
            string folder = path.Split("/")[0];

            //Verfica se existe o diretório do path
            if(!Directory.Exists(folder))
            {
                Directory.CreateDirectory(folder);
            }

            //Verfica se existe o arquivo do path
            if(!File.Exists(path))
            {
                File.Create(path);
            }
        }
    }
}