using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates
{
  public  class Student
  {
        public string Name { get; set; }

        public int Age { get; set; }

        public string Gender { get; set; }

        public override string ToString() => $"Name: {Name}\n, Age:{Age}\n, Gender:{Gender}";
    }
}
