using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace class_human_with_properties
{
    class Worker_inheriting_Human : Human
    {
        public double Wages;
        public int HoursWorked;
        public Worker_inheriting_Human(string firstname, string lastname, double wages, int hoursworked) : base (firstname,lastname)
        {
            Wages = wages;
            HoursWorked = hoursworked;
        }

        public void CalculateHourlyWages()
        {
            double hourlyPayRate = Wages / HoursWorked;
        }
    }
}
