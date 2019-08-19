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
    public partial class DisplaySaveChangesEmp : Form
    {
        public DisplaySaveChangesEmp()
        {
            InitializeComponent();
        }

        private void DisplaySaveChangesEmp_Load(object sender, EventArgs e)
        {
            Reload();
        }

        private void listBoxDisplaySaveChanges_SelectedIndexChanged(object sender, EventArgs e)
        {
            Employees selectedEmployees = (Employees)listBoxDisplaySaveChanges.SelectedItem;
            //show
            lblIDSavEmp.Text = selectedEmployees.EmpID.ToString();
            txtFNameSav.Text = selectedEmployees.FirstName;
            txtLNameSav.Text = selectedEmployees.LastName;
            txtEmailSav.Text = selectedEmployees.Email;
            txtDOBSav.Text = selectedEmployees.DOB;
            txtPhoneSav.Text = selectedEmployees.Phone;
        }

        private void Reload()
        {
            EmployeesController controller = new EmployeesController();
            Result<Employees> result = controller.GetAll();
            if (result.Status == ResultEnum.Success)
            {
                listBoxDisplaySaveChanges.DataSource = result.Data;
                listBoxDisplaySaveChanges.DisplayMember = "LastName";
                lblNumOfEmpSav.Text = "Number of employees " + result.Data.Count;
            }
            else
            {
                MessageBox.Show("Cannot get the list of employees, please try again");
            }
        }

        private void btnSaveEmp_Click(object sender, EventArgs e)
        {

            //read the employees
            Employees updateEmployees = new Employees();
            updateEmployees.EmpID = int.Parse(lblIDSavEmp.Text);
            updateEmployees.FirstName = txtFNameSav.Text;
            updateEmployees.LastName = txtLNameSav.Text;
            updateEmployees.Email = txtEmailSav.Text;
            updateEmployees.DOB = txtDOBSav.Text;
            updateEmployees.Phone = txtPhoneSav.Text;

            //save to DB
            EmployeesController controller = new EmployeesController();
            ResultEnum result = controller.Update(updateEmployees);
            if (result == ResultEnum.Success)
            {
                //reload the list
                Reload();
                MessageBox.Show("Updated");
            }
            else
            {
                MessageBox.Show("Cannot update");
            }

        }
    }
}
