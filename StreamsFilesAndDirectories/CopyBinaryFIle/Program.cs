using System;
using System.IO;

namespace CopyBinaryFIle
{
    class Program
    {
        static void Main(string[] args)
        {
            using (FileStream reader = new FileStream("../../../copyMe.png", FileMode.Open))
            {
                using (FileStream writer = new FileStream("../../../newPic.png", FileMode.Create))
                {
                    byte[] buffer = new byte[4096];

                    while(reader.CanRead)
                    {
                        int bytesRead = reader.Read(buffer, 0, buffer.Length);

                        if(bytesRead == 0)
                        {
                            break;
                        }

                        writer.Write(buffer, 0, buffer.Length);

                       
                    }

                }
            }
            
        }
    }
}
