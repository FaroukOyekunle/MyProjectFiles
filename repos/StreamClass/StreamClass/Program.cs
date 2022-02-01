using System;
using System.IO;
using System.Text;

namespace StreamClass
{
    class Program
    {
        static void Main(string[] args)
        {
            // Console.WriteLine("Hello World!");
            //WRITING TO A MEMORY STREAM  WITH A STREAM READER.
            string word = "the guy is so handsome";
            Byte[] byt = System.Text.Encoding.UTF8.GetBytes(word);
            MemoryStream stream = new MemoryStream(byt);
            StreamReader streamReader = new StreamReader(stream);
            Console.WriteLine(streamReader.ReadToEnd());

            //WRITING TO A STREAM WRITER WITH A STREAMWRITER AND FLUSH
            var word2 = Console.ReadLine();
            var byt2 = Encoding.UTF8.GetBytes(word2);
            MemoryStream stream2 = new MemoryStream(byt2);
          //  StreamWriter streamWriter = new StreamWriter(stream2);
            streamReader streamReader1 = new streamReader(stream2);

        }
    }
}
