using System;
using System.IO;
using System.Text;

namespace Filestream
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = "D:/Natalia/Project1/C-Sharp/Filestream/Filestream/111.jpg";
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

            Console.WriteLine("++++");



            //for (int i = 0; i < 2; i++)
            //{
            //    bytes[i] = 1;
            //}
            using (FileStream fs = new FileStream("D:/Natalia/Project1/C-Sharp/Filestream/Filestream/22.jpg", FileMode.OpenOrCreate, FileAccess.ReadWrite))
            {
                using (BinaryWriter br = new BinaryWriter(fs, Encoding.Default))
                {
                    
                        br.Write(bytes);
                    

                    
                    
                }
            }

        }
    }
}
