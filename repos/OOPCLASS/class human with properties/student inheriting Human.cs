using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace class_human_with_properties
{
    class student_inheriting_Human : Human
    {
        public int Mark;

        public student_inheriting_Human(string firstname, string lastname, int mark) : base (firstname,lastname)
        {
            Mark = mark;
        }
    }
}
