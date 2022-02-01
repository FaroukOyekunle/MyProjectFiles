using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CONSTRUCTOR__CLASSES_FOR_AN_ANIMAL_CLASS
{
    class class_animal_oop
    {
        protected string Name;
        protected int Age;
        protected string Gender;

        public class_animal_oop(string name, int age, string gender)
        {
            Name = name;
            Age = age;
            Gender = gender;
        }
        public virtual string PrintSound()
        {
            return "Animal sound";
        }
        public string PrintDetails()
        {
            return $"the name of the animal is {Name} and its of  age {Age} years old, and its sound is {PrintSound()} ";
        }
        public void SetName(string name)
        {
            Name = name;
        }
        public string GetName()
        {
            return Name;
        }
        public void SetAge(int age)
        {
            Age = age;
        }
        public int GetAge()
        {
            return Age;
        }
        public void SetGender(string gender)
        {
            Gender = gender;
        }
        public string GetGender()
        {
            return Gender;
        }

            
    }
}
