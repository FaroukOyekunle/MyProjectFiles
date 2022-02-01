using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CONSTRUCTOR__CLASSES_FOR_AN_ANIMAL_CLASS
{
    class TomCat: class_animal_oop
    {
        public TomCat(string name, int age, string gender) : base(name, age, gender)
        {

        }
        public override string PrintSound()
        {
            return "the tomcat sound i.e ahiunahununn";
        }
    }
}
