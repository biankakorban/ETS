using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess;
using Model;

namespace Controller
{
    public class WorkingHoursController
    {
        private WorkingHoursDao workingHoursDao;

        public WorkingHoursController()
        {
            workingHoursDao = new WorkingHoursDao();
        }

        //add working hours
        public ResultEnum AddHours(WorkingHours workingHours)
        {
            try
            {
                workingHoursDao.InsertHours(workingHours);
                return ResultEnum.Success;
            }
            catch (Exception ex)
            {
                //logging to the output window
                Console.WriteLine("Error in WorkingHoursController/AddHours: " + ex.Message);
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
                controllerResult.Data = workingHoursDao.SelectAll();
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

        //display work dates and hours
        public Result<WorkingHours> GetWorkDateHours(int empID)
        {
            Result<WorkingHours> result = new Result<WorkingHours>();

            try
            {
                result.Data = workingHoursDao.SelectHours(empID);
                result.Status = ResultEnum.Success;
            }
            catch (Exception ex)
            {
                //logging to the output window
                Console.WriteLine("Error in WorkingHoursDao/SelectHours : " + ex.Message);
                //report
                result.Status = ResultEnum.Fail;

            }
            return result;
        }
    }
}
