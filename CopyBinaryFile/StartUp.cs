using System.IO;

namespace CopyBinaryFile
{
    class StartUp
    {
        static void Main()
        {
            using var reader = new FileStream("../../../copyMe.png", FileMode.Open);
            using var writer = new FileStream("../../../pastedFile.png", FileMode.Create);

            var buffer = new byte[4096];

            while (reader.CanRead)
            {
                var bytesRead = reader.Read(buffer, 0, buffer.Length);
                if (bytesRead != 0)
                    writer.Write(buffer, 0, buffer.Length);
                else
                    break;
            }


        }
    }
}
