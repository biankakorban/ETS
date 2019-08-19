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
    public partial class Display : Form
    {
        public Display()
        {
            InitializeComponent();
        }

        private void Display_Load(object sender, EventArgs e)
        {
            Reload();
        }


        //SelectedIndexChanged
        private void listBoxEmployees_SelectedIndexChanged(object sender, EventArgs e)
        {
            Employees selectedEmployees = (Employees)listBoxEmployees.SelectedItem;
            //show
            lblIDDis.Text = selectedEmployees.EmpID.ToString();
            txtFNameDis.Text = selectedEmployees.FirstName;
            txtLNameDis.Text = selectedEmployees.LastName;
            txtEmailDis.Text = selectedEmployees.Email;
            txtDOBDis.Text = selectedEmployees.DOB;
            txtPhoneDis.Text = selectedEmployees.Phone;
        }


        private void Reload()
        {
            EmployeesController controller = new EmployeesController();
            Result<Employees> result = controller.GetAll();
            if (result.Status == ResultEnum.Success)
            {
                listBoxEmployees.DataSource = result.Data;
                listBoxEmployees.DisplayMember = "LastName";
                lblNumberOfEmp.Text = "Number of employees " + result.Data.Count;
            }
            else
            {
                MessageBox.Show("Cannot get the list of employees, please try again");
            }
        }
    }
}
