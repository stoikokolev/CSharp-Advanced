using System.IO.Compression;

namespace ZipAndExtract
{
    class StartUp
    {
        static void Main()
        {
            const string sourcePath = @"../../../copyMeFolder/";
            const string zippedFilePath = @"../../../zippedFileFolder/myZip.zip";
            const string destinationPath = @"../../../extractedFileFolder/";

            ZipFile.CreateFromDirectory(sourcePath,zippedFilePath);

            ZipFile.ExtractToDirectory(zippedFilePath,destinationPath,true);
        }
    }
}
