using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndexerAssessment
{
    class Record
    {
        List<string> names { get; set; }
        string FirstName { get; set; }

        public object this[int i]
        {
            get { return names[i]; }
            set { names[i] = FirstName; }
        }


    }
}
