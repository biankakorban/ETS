using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Employees
    {
        //props
        public int EmpID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string DOB { get; set; }
        public string Phone { get; set; }

        //toString
        public override string ToString()
        {
            return "Employee ID: " +  EmpID + ", " + 
                   "first name: " + FirstName + ", " + 
                   "last name: " + LastName + ", " +
                   "email: " + Email + ", " +
                   "date of birth: " + DOB + ", " + 
                   "phone number: " + Phone + ".";
        }

    
    }
}
