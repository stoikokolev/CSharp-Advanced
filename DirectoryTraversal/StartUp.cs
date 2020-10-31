using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace DirectoryTraversal
{
    class StartUp
    {
        static void Main()
        {
            var files = CollectFilesFromPath("../../../");

            WriteOnFile(files);
        }

        private static void WriteOnFile(Dictionary<string, List<MyFile>> fileInfo)
        {
            using var writer = new StreamWriter(@$"{Environment.GetFolderPath(Environment.SpecialFolder.Desktop)}\report.txt");

            foreach (var (extension, list) in fileInfo
                .OrderByDescending(x => x.Value.Count)
                .ThenBy(x => x.Key))
            {
                writer.WriteLine(extension);

                foreach (var file in list
                    .OrderByDescending(x => x.Length))
                {
                    writer.WriteLine($"--{file.Name} - {file.Length}kb");
                }

            }
        }

        private static Dictionary<string, List<MyFile>> CollectFilesFromPath(string path)
        {
            var directoryInfo = new DirectoryInfo(path);
            var files = directoryInfo.GetFiles();
            var fileInfo = new Dictionary<string, List<MyFile>>();
            foreach (var file in files)
            {
                if (!fileInfo.ContainsKey(file.Extension))
                {
                    fileInfo.Add(file.Extension, new List<MyFile>());
                }

                fileInfo[file.Extension].Add(new MyFile(file));
            }

            return fileInfo;
        }

    }
}

