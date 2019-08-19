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
    public partial class SelectEmployeeByID_Email : Form
    {
        public SelectEmployeeByID_Email()
        {
            InitializeComponent();
        }

        private void SelectEmployeeByID_Email_Load(object sender, EventArgs e)
        {
            //rdoID.Checked = true;
            //rdoEmail.Checked = true;
            //Reload();
        }

        private void btnSearchBy_Click(object sender, EventArgs e)
        {
            //read input
            int id;
            string email;


            //controller
            if (txtSearchByID.Text != "")
            {
                //validation 
                if (!ValidationHelper.NumberOnly(txtSearchByID.Text))
                {
                    MessageBox.Show("Only numbers");
                    return;
                }

                id = int.Parse(txtSearchByID.Text);
                EmployeesController controller = new EmployeesController();
                Result<Employees> result = controller.GetByID(id);
                
          
                switch (result.Status)
                {
                    case ResultEnum.Success:
                        listBoxEmployeeSearchBy.DataSource = result.Data;
                        break;
                    case ResultEnum.Fail:
                        MessageBox.Show("Error, cannot show list of employees");
                        break;
                }
            }
            else if (txtSearchByEmail.Text != "")
            {
                if (!ValidationHelper.IsEmail(txtSearchByEmail.Text))
                {
                    MessageBox.Show("Incorrect email address");
                    return;
                }


                email = txtSearchByEmail.Text;
                EmployeesController controller = new EmployeesController();
                Result<Employees> result = controller.GetByEmail(email);
                
                switch (result.Status)
                {
                    case ResultEnum.Success:
                        listBoxEmployeeSearchBy.DataSource = result.Data;


                        //show

                        break;
                    case ResultEnum.Fail:
                        MessageBox.Show("Error, cannot display");
                        break;
                }
            }
            else
            {
                MessageBox.Show("The text field can not be empty");
            }
           
        }

        private void rdoID_CheckedChanged(object sender, EventArgs e)
        {
            //Employee emp = new Employee();
            if (rdoID.Checked == true)
            {
                txtSearchByEmail.Enabled = false;
                txtSearchByID.Enabled = true;
            }
        }

        private void rdoEmail_CheckedChanged(object sender, EventArgs e)
        {
            if (rdoEmail.Checked == true)
            {
                txtSearchByID.Enabled = false;
                txtSearchByEmail.Enabled = true;
            }
        }

        
    }
}
