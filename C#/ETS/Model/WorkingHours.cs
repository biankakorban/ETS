using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class WorkingHours
    {
        //props
        public int EmpHoursID { get; set; }
        public string WorkDate { get; set; }
        public double Hours { get; set; }
        public int EmpID { get; set; }
        //public string FirstName { get; set; }
        //public string LastName { get; set; }


        //toString
        public override string ToString()
        {
            return "Working date: " + WorkDate + ", " +
                   "number of hours: " + Hours + ", " +
                   "employee ID: " + EmpID;       
        }

      


    }
}
