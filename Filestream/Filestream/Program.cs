using System;
using System.IO;
using System.Text;

namespace Filestream
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = "D:/Natalia/Project1/C-Sharp/Filestream/Filestream/images.jpg";
            byte[] bytes;
            int len = 0;

            using (FileStream fs = new FileStream(name, FileMode.OpenOrCreate, FileAccess.ReadWrite))
            {
                using (BinaryReader br = new BinaryReader(fs, Encoding.Default))
                {
                    len = (int)fs.Length;
                    bytes = new byte[fs.Length];
                    br.Read(bytes, 0, bytes.Length);
                }
            }

            int num = 0;           
            Console.WriteLine("Enter num of copy");
            num = int.Parse(Console.ReadLine());

            for (int i = 0; i < num; i++)
            {
                using (FileStream fs = new FileStream("D://file" + i + ".jpg", FileMode.OpenOrCreate, FileAccess.ReadWrite))
                {
                    using (BinaryWriter br = new BinaryWriter(fs, Encoding.Default))
                    {
                        br.Write(bytes, 0, bytes.Length);                      
                        br.Write(bytes);

                    }
                }
            }

        }
    }
}
