using System.IO;

namespace DirectoryTraversal
{
    class MyFile
    {
        public string Name { get; private set; }

        public double Length { get; private set; }

        public MyFile(FileInfo file)
        {
            this.Name = file.Name;
            this.Length = file.Length / 1000.00;

        }
    }
}
