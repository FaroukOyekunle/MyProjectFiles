using System;
using System.IO;
using System.Text;
using System.Collections.Generic;
using System.Linq;
namespace StreamClassApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            bool flag = true;
            do
            {
                Console.WriteLine("what do you want to keep in the file ?");
                string content = Console.ReadLine();
                WriteToFile(".\\file.txt", content);
                flag = CheckIfEnd();
            }
            while (flag);
            Console.WriteLine("here are the content of your file.");
            foreach (string content in ReadFromFile(".\\file.txt")) 
            {
                Console.WriteLine(content);
            }
            Console.WriteLine("Thank you for using our application.");
            
        }
        static void WriteToFile(string path, string content)
        {
            try
            {
                StreamWriter streamWriter = new StreamWriter(path, true);
                streamWriter.WriteLine(content);
                streamWriter.Flush();
                streamWriter.Close();
            }
            catch(FileNotFoundException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch(FieldAccessException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch(IOException ex)
            {
                Console.WriteLine(ex.Message);
            }
            
        }


       /* static List<string> ReadFromFile(string path)
        {
            List<string> contents = new List<string>();
            StreamReader streamReader = new StreamReader(path);
            while (!streamReader.EndOfStream)
            {
                 contents.Add(streamReader.ReadLine());
            }
            streamReader.Close();
        }  */

        static IEnumerable<string> ReadFromFile(string path)
        {
            StreamReader streamReader = new StreamReader(path);
            while(!streamReader.EndOfStream)
            {
                yield return streamReader.ReadLine();
            }
            streamReader.Close();
        }

        static bool CheckIfEnd()
        {
            Console.WriteLine("Do you want to end the application ? (YES(Y)/ NO(N))");
            string choice = Console.ReadLine();
            if(choice.ToLower() == "n")
            {
                return false;
            }
            else if(choice.ToLower() == ("y"))
            {
                return true;
            }
            else
            {
                Console.WriteLine("Thanks you for usin our application. ");
                return false;
            }
        }
    }
}
