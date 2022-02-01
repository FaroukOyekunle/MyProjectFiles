using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace constructorANDencapsulation_
{
    class OldStudent : STUDENT
    {

        private double CGPA;
        public OldStudent(decimal Payment, bool Iscleared) : base (Payment, Iscleared)
        {
            name = "kabirah";
            age = 20;
            state = "oyo state";
            Email = "adamkabirah606@gmail.com";
            CGPA = 3.8;
            matricNumber = 09066063487;
        }
    }
}
