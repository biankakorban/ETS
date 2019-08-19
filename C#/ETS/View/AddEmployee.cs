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
    public partial class AddEmployee : Form
    {
        public AddEmployee()
        {
            InitializeComponent();
        }

        private void AddEmployee_Load(object sender, EventArgs e)
        {
            txtFName.Focus();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {

            //if (txtFName.Text == "")
            //{
            //    msg += "Text field cannot be empty";   
            //}
            //else
            //{
            //if (!ValidationHelper.LettersOnly(txtFName.Text))
            //{
            //        MessageBox.Show("Employee first name must contain letters only!");
            //        return;
            //    }
            ////}
            ////if (!ValidationHelper.LettersOnly(txtFName.Text))
            ////{
            ////    MessageBox.Show("Employee first name must contain letters only!");
            ////    return;
            ////}


            //if (!ValidationHelper.LettersOnly(txtLName.Text))
            //{
            //    MessageBox.Show("Employee last name must contain letters only!");
            //    return;
            //}





            //if (!ValidationHelper.IsPhoneValid(txtPhone.Text))
            //{
            //    MessageBox.Show("Employee phone number must contain letters only!");
            //    return;
            //}

            //if (!ValidationHelper.IsEmail(txtEmail.Text))
            //{
            //    MessageBox.Show("Employee email address is incorrect!");
            //    return;
            //}




            //validation

            if (!ValidationHelper.LettersOnly(txtFName.Text))
            {
                MessageBox.Show("Employee first name must contain letters only!");
                return;
            }

            if (!ValidationHelper.LettersOnly(txtLName.Text))
            {
                MessageBox.Show("Employee last name must contain letters only!");
                return;
            }

            if (!ValidationHelper.IsEmail(txtEmail.Text))
            {
                MessageBox.Show("Employee email address is incorrect!");
                return;
            }

            //if (!ValidationHelper.NumberOnly(txtDOB.Text))
            //{
            //    MessageBox.Show("Employee date of birth must contain letters only!");
            //    return;
            //}


            //if (!ValidationHelper.IsValidDate(txtDOB.Text))
            //{
            //    MessageBox.Show("Incorect date of birth!");
            //    return;
            //}


            //if (!ValidationHelper.NumberOnly(txtPhone.Text))
            //{
            //    MessageBox.Show("Employee phone number must contain letters only!");
            //    return;
            //}
            //if (txtDOB.Text == "" || txtPhone.Text == "")
            //{
            //    MessageBox.Show("The text field can not be empty");
            //}


            //read input
            Employees emp = new Employees();
            emp.FirstName = txtFName.Text;
            emp.LastName = txtLName.Text;
            emp.Email = txtEmail.Text;
            emp.DOB = txtDOB.Text;
            emp.Phone = txtPhone.Text;


            //call controller - save into db
            EmployeesController controller = new EmployeesController();
            ResultEnum result = controller.Add(emp);

                switch (result)
                {
                    case ResultEnum.Success:
                        MessageBox.Show("New employee added");
                        break;
                    case ResultEnum.Fail:
                        MessageBox.Show("Employee can not be added, please try again :-");
                        break;
                }

            //    if (result == ResultEnum.Success)
            //{
            //    //show output ...
            //    MessageBox.Show("New employee added");
            //}
            //else
            //{
            //    MessageBox.Show("Employee can not be added, please try again :-");
            //}
        }
    }
}
