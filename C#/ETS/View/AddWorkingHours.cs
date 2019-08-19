using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Model;
using Controller;

namespace View
{
    public partial class AddWorkingHours : Form
    {
        public AddWorkingHours()
        {
            InitializeComponent();
        }

        private void AddWorkingHours_Load(object sender, EventArgs e)
        {
            Reload();
        }

        //SelectedIndexChanged
        private void listBoxNumOfEmpWorkHours_SelectedIndexChanged(object sender, EventArgs e)
        {
            Employees selectedEmployees = (Employees)listBoxNumOfEmpWorkHours.SelectedItem;
            lblIDHours.Text = selectedEmployees.EmpID.ToString();
            txtFName.Text = selectedEmployees.FirstName;
            txtLName.Text = selectedEmployees.LastName;
        }

        private void Reload()
        {
            EmployeesController controller = new EmployeesController();
            Result<Employees> result = controller.GetAll();
            if (result.Status == ResultEnum.Success)
            {
                listBoxNumOfEmpWorkHours.DataSource = result.Data;
                listBoxNumOfEmpWorkHours.DisplayMember = "LastName";
                lblListOfEmpHours.Text = "Number of employees" + result.Data.Count;
            }
            else
            {
                MessageBox.Show("Cannot get the list of employees, please try again");
            }
        }

        private void btnRecord_Click(object sender, EventArgs e)
        {
            //read input 
            WorkingHours workingHours = new WorkingHours();
            workingHours.WorkDate = txtWorkDate.Text;
            workingHours.Hours = double.Parse(txtHours.Text);
            workingHours.EmpID = int.Parse(lblIDHours.Text);

            lblIDHours.Text = workingHours.EmpID.ToString();

            //call controller
            WorkingHoursController controller = new WorkingHoursController();
            ResultEnum result = controller.AddHours(workingHours);


            switch (result)
            {
                case ResultEnum.Success:
                    MessageBox.Show("Work date and hours added");
                    break;
                case ResultEnum.Fail:
                    MessageBox.Show("Work date and hours can not be added, please try again :-");
                    break;
                default:
                    break;
            }

            //if (result == ResultEnum.Success)
            //    {
            //        //show output ...
            //        MessageBox.Show("Work date and hours added");
            //    }
            //    else
            //    {
            //        MessageBox.Show("Work date and hours can not be added, please try again :-");
            //    }
            //}


        }
    }
}

