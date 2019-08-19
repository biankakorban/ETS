using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//ADO.NET provider
using System.Data.SqlClient;
using Model;

namespace DataAccess
{
    public class EmployeesDao
    {
        //method - insert a new employee
        public void Insert(Employees emp)
        {
            //1- connection
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = ConnectionHelper.getConnectionString();
            conn.Open();

            using (conn)
            {
                //2- command
                SqlCommand command = new SqlCommand("sp_Employees_InsertAnEmployee", conn);
                command.CommandType = System.Data.CommandType.StoredProcedure;
                //params
                command.Parameters.Add(new SqlParameter("@firstName", emp.FirstName));
                command.Parameters.Add(new SqlParameter("@lastName", emp.LastName));
                command.Parameters.Add(new SqlParameter("@email", emp.Email));
                command.Parameters.Add(new SqlParameter("@dob", emp.DOB));
                command.Parameters.Add(new SqlParameter("@phone", emp.Phone));

                //3- run command
                command.ExecuteNonQuery();
            }
        }


        //method to select all employees

        public List<Employees> SelectAll()
        {
            //1 - connection
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
                    emp.Email = Convert.ToString(reader["Email"]);
                    emp.DOB = Convert.ToString(reader["DOB"]);
                    emp.Phone = Convert.ToString(reader["Phone"]);
                    list.Add(emp);
                }//end loop
                return list;

                //map reader
            }
        }


        //update method
        public void Update(Employees emp)
        {
            //1 - connection
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = ConnectionHelper.getConnectionString();
            conn.Open();

            using (conn)
            {
                //2 - command
                SqlCommand command = new SqlCommand("sp_Employees_UpdateAnEmployee", conn);
                command.CommandType = System.Data.CommandType.StoredProcedure;
                //params
                command.Parameters.Add(new SqlParameter("@empID", emp.EmpID));
                command.Parameters.Add(new SqlParameter("@firstName", emp.FirstName));
                command.Parameters.Add(new SqlParameter("@lastName", emp.LastName));
                command.Parameters.Add(new SqlParameter("@email", emp.Email));
                command.Parameters.Add(new SqlParameter("@dob", emp.DOB));
                command.Parameters.Add(new SqlParameter("@phone", emp.Phone));

                //3 - run command
                command.ExecuteNonQuery();

            }
        }

        
        //method to select employee by ID
        public List<Employees> SelectByID(int empID)
        {
            //1 - connection
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = ConnectionHelper.getConnectionString();
            conn.Open();

            using (conn)
            {
                //2- command
                SqlCommand command = new SqlCommand("sp_Employees_SelectAnEmployeeByID", conn);
                command.CommandType = System.Data.CommandType.StoredProcedure;
                //param
                command.Parameters.Add(new SqlParameter("@empID", empID));


                //3 - run command
                SqlDataReader reader = command.ExecuteReader();

                //4 - map reader rows into category objects and add them to the list next row
                List<Employees> list = new List<Employees>();

                //read method return true /false move the reader pointer into the next row

                while (reader.Read())
                {
                    Employees emp = new Employees();
                    emp.EmpID = Convert.ToInt32(reader["EmpID"]);
                    emp.FirstName = Convert.ToString(reader["FirstName"]);
                    emp.LastName = Convert.ToString(reader["LastName"]);
                    emp.Email = Convert.ToString(reader["Email"]);
                    emp.DOB = Convert.ToString(reader["DOB"]);
                    emp.Phone = Convert.ToString(reader["Phone"]);
                    list.Add(emp);
                }//end loop
                return list;
            }
        }



            //method select employee by email
            public List<Employees> SelectByEmail(string empEmail)
        {
            //1 - connection
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = ConnectionHelper.getConnectionString();
            conn.Open();

            using (conn)
            {
                //2- command
                SqlCommand command = new SqlCommand("sp_Employees_SelectAnEmployeeByEmail", conn);
                command.CommandType = System.Data.CommandType.StoredProcedure;
                //param
                command.Parameters.Add(new SqlParameter("@empEmail", empEmail));


                //3- run command
                SqlDataReader reader = command.ExecuteReader();

                //4 map reader rows into category objects and add them to the list next row
                List<Employees> list = new List<Employees>();

                //read method return true /false move the reader pointer into the next row

                while (reader.Read())
                {
                    Employees emp = new Employees();
                    emp.EmpID = Convert.ToInt32(reader["EmpID"]);
                    emp.FirstName = Convert.ToString(reader["FirstName"]);
                    emp.LastName = Convert.ToString(reader["LastName"]);
                    emp.Email = Convert.ToString(reader["Email"]);
                    emp.DOB = Convert.ToString(reader["DOB"]);
                    emp.Phone = Convert.ToString(reader["Phone"]);
                    list.Add(emp);
                }//end loop
                return list;
            }
        }
    }
}

