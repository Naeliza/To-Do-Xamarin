using System;
using System.IO;
using toDo.Services;
using Xamarin.Forms;
using toDo.Droid;

[assembly: Dependency(typeof(FileHelper))]
namespace toDo.Droid
{
    public class FileHelper : IFileHelper
    {
        public string GetLocalFilePath(string filename)
        {
            string path = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            return Path.Combine(path, filename);
        }
    }
}
