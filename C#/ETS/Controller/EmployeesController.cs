using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;
using DataAccess;

namespace Controller
{
    public class EmployeesController
    {
        private EmployeesDao empDao;

        public EmployeesController()
        {
            empDao = new EmployeesDao();
        }


        //add an employee
        public ResultEnum Add(Employees emp)
        {
            try
            {
                empDao.Insert(emp);
                return ResultEnum.Success;
            }
            catch (Exception ex)
            {
                //logging to the output window
                Console.WriteLine("error in EmployeesController/Add : " + ex.Message);
                //report
                return ResultEnum.Fail;
            }
        }

        //get all method
        public Result<Employees> GetAll()
        {
            Result<Employees> controllerResult = new Result<Employees>();
            try
            {
                controllerResult.Data = empDao.SelectAll();
                controllerResult.Status = ResultEnum.Success;

            }
            catch (Exception ex)
            {
                //logging to the output window
                Console.WriteLine("Error in EmployeeController/GetAll: " + ex.Message);
                //report
                controllerResult.Status = ResultEnum.Fail;
            }

            return controllerResult;
        }

        //update
        public ResultEnum Update(Employees emp)
        {
            try
            {
                empDao.Update(emp);
                return ResultEnum.Success;
            }
            catch (Exception ex)
            {
                //logging to the output window
                Console.WriteLine("Error in EmployeesController/Update: " + ex.Message);
                //report
                return ResultEnum.Fail;
            }
        }


        //get by id
        public Result<Employees> GetByID(int empID)
        {
            Result<Employees> result = new Result<Employees>();

            try
            {
                result.Data = empDao.SelectByID(empID);
                result.Status = ResultEnum.Success;
            }
            catch (Exception ex)
            {
                //logging to the output window
                Console.WriteLine("Error in EmployeeDao/SelectByID : " + ex.Message);
                //report
                result.Status = ResultEnum.Fail;
            }

            return result;
        }




        //get by email
        public Result<Employees> GetByEmail(string empEmail)
        {
            Result<Employees> result = new Result<Employees>();

            try
            {
                result.Data = empDao.SelectByEmail(empEmail);
                result.Status = ResultEnum.Success;
            }
            catch (Exception ex)
            {
                //logging to the output window
                Console.WriteLine("error in EmployeeDao/SelectByID : " + ex.Message);
                //report
                result.Status = ResultEnum.Fail;
            }

            return result;
        }

    }
}
