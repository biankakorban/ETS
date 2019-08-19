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
    public partial class SelectAllEmployees : Form
    {
        public SelectAllEmployees()
        {
            InitializeComponent();
        }

        private void SelectAllEmployee_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dB_Employee_Work_HoursDataSet.Employees' table. You can move, or remove it, as needed.
            this.employeesTableAdapter.Fill(this.dB_Employee_Work_HoursDataSet.Employees);

        }


    }
}
