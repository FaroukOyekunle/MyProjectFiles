using System;

namespace oopassessmentClass
{
    class Program
    {
        static void Main(string[] args)
        {
            /* var teacher = new Teacher();
              teacher.SetName("ajayi");
              teacher.Setsubject("literature");
              teacher.SetClass("jss one");
              teacher.IsActive();


              var teacher1 = new Teacher();
              teacher.SetName("adefemi");
              teacher.Setsubject("government");
              teacher.SetClass("jss two");
              teacher.IsActive();

              var teacher2 = new Teacher();
              teacher.SetName("adebayo");
              teacher.Setsubject("yoruba");
              teacher.SetClass("jss three");
              teacher.IsActive();


              var teacher3 = new Teacher();
              teacher.SetName("adam");
              teacher.Setsubject("maths");
              teacher.SetClass("ss three");
              teacher.IsActive();

              var teacher4 = new Teacher();
              teacher.SetName("ajao");
              teacher.Setsubject("english");
              teacher.SetClass("ss two");
              teacher.IsActive();


              teacher.PrintTeacherStatus();  */


            Teacher teacher = new Teacher("ajayi", "government", "jss one", true);
            Teacher teacher1 = new Teacher("adefemi", "yoruba", "jss two", true);
        }
    }
    class Teacher
    {
        string Name;
        string subject;
        string Class;
        bool isActive;

        //shortcut for creating a constructor,  (CTOR WITH TAB BUTTON)
        public Teacher(string name, string Subject, string Class, bool isActive)
        {
            Name = name;
            subject = Subject;
            isActive = true;
        }
        
        public string Getname()
        {
            return Name;
        }

        public void SetName(string Name)
        {
            this.Name = Name;
        }


        public string Getsubject()
        {
            return subject;
        }

        public void Setsubject(string subject)
        {
            this.subject = subject;
        }

        public string GetClass()
        {
            return Class;
        }

        public void SetClass(string Class)
        {
            this.Class = Class;
        }

        public bool IsActive()
        {
            return isActive;
        }

        public void SetIsActive(bool IsActive)
        {
            this.isActive = IsActive;
        }

        public void PrintTeacherStatus()
        {
            if(isActive == true)
            {
               
                Console.WriteLine($"{Name} is an active teacher, and his teaching {Class}");
            }

            else
            {
                Console.WriteLine($"{Name} is not an active teacher, and is teaching {Class}.");
            }
        }



    }
}
