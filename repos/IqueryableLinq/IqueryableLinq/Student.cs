using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IqueryableLinq
{
    class Student
    {
      public  int ID { get; set; }
     public   string Name { get; set; }
     public   string Gender { get; set; }
        public List<string> subjects { get; set; }

        public static List<Student> GetStudents()
        {
            List<Student> students = new List<Student>()
            {
                 new Student() {ID = 1, Name = "morayo", Gender = "male", subjects = {"c#", "java", "python" } },
                new Student(){ID = 2, Name = "lolade", Gender = "female", subjects = { "f#", "go lang", "c++"} },
                new Student(){ID = 3, Name = "funmi", Gender = "female", subjects = { "html", "javascript", "C"} },
                new Student(){ID = 4, Name = "dayo", Gender = "male", subjects = { "angular", "boostrap", "Node"} },
                new Student(){ID = 5, Name = "opeyemi", Gender = "female", subjects ={ "JS", "CSS", "AJAX"} }
            };

            return students;
        }
     

      public static List<Student> students = new List<Student>()
        {
          new Student() {ID = 1, Name = "morayo", Gender = "male"},
          new Student(){ID = 2, Name = "lolade", Gender = "female"},
          new Student(){ID = 3, Name = "funmi", Gender = "female"},
          new Student(){ID = 4, Name = "dayo", Gender = "male"},
          new Student(){ID = 5, Name = "opeyemi", Gender = "female"}
        };

       
    }
    
}
