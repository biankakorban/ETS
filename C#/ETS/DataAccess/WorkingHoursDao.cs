using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Model;

namespace DataAccess
{
    public class WorkingHoursDao
    {
        //method to insert working hours
        public void InsertHours(WorkingHours workingHours)
        {
            //1-connection
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = ConnectionHelper.getConnectionString();
            conn.Open();

            using (conn)
            {
                //2-command
                SqlCommand command = new SqlCommand("sp_EmpHours_InsertHours", conn);
                command.CommandType = System.Data.CommandType.StoredProcedure;
                //params
                command.Parameters.Add(new SqlParameter("@workDate", workingHours.WorkDate));
                command.Parameters.Add(new SqlParameter("@hours", workingHours.Hours));
                command.Parameters.Add(new SqlParameter("@empID", workingHours.EmpID));

                //3-run command 
                command.ExecuteNonQuery();

            }
        }

        //method to select all employees
        public List<Employees> SelectAll()
        {
            //1 = connection
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = ConnectionHelper.getConnectionString();
            conn.Open();

            using (conn)
            {
                //2 - command
                SqlCommand command = new SqlCommand("sp_Employees_SelectAllEmployees", conn);
                command.CommandType = System.Data.CommandType.StoredProcedure;


                //3 - run command 
                SqlDataReader reader = command.ExecuteReader();

                //4 - map reader
                List<Employees> list = new List<Employees>();
                //read method
                while (reader.Read())
                {
                    Employees emp = new Employees();
                    emp.EmpID = Convert.ToInt32(reader["EmpID"]);
                    emp.FirstName = Convert.ToString(reader["FirstName"]);
                    emp.LastName = Convert.ToString(reader["LastName"]);
                    list.Add(emp);


                }//end loop
                return list;

                //map reader

            }
        }

        //method to select work dates and hours worked by employee
        public List<WorkingHours> SelectHours(int empID)
        {
            //1 = connection
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = ConnectionHelper.getConnectionString();
            conn.Open();

            using (conn)
            {
                SqlCommand command = new SqlCommand("sp_EmpHours_SelectEmployeeWorkDateHoursByEmpID", conn);
                command.CommandType = System.Data.CommandType.StoredProcedure;
                //param
                command.Parameters.Add(new SqlParameter("@empID", empID));

                //3 - run command 
                SqlDataReader reader = command.ExecuteReader();

                //4 - map reader rows into workingHours objects and add them to the list next row

                List<WorkingHours> list = new List<WorkingHours>();
         

                while (reader.Read())
                {
                    WorkingHours workHours = new WorkingHours();
                    //workHours.EmpHoursID = Convert.ToInt32(reader["EmpHoursID"]);
                    workHours.WorkDate = Convert.ToString(reader["WorkDate"]);
                    workHours.Hours = Convert.ToDouble(reader["Hours"]);
                    workHours.EmpID = Convert.ToInt32(reader["EmpID"]);
                    list.Add(workHours);
                }//end loop
                return list;

            }
        }


       
    }
}
