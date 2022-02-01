using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace StudentApplicationWithStreamWriter
{
    class FileManagerPortal
    {
        string FilePath { get; set; }

        public FileManagerPortal(string filePath)
        {
            FilePath = filePath;
        }

        public void Write(string content, bool append = true)
        {
            StreamWriter streamWriter = new StreamWriter(FilePath, append);
            using (streamWriter)
            {
                streamWriter.WriteLine(content);
                streamWriter.Flush();
            }
        }
        public IEnumerable<string> Read()
        {
            StreamReader streamReader = new StreamReader(FilePath);
            using (streamReader)
            {
                while (!streamReader.EndOfStream)
                {
                    yield return streamReader.ReadLine();
                }
            }
        }

    }
}
