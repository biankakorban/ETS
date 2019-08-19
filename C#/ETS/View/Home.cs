using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace View
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void addToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            AddEmployee frm = new AddEmployee();
            frm.ShowDialog();
        }

        private void displayToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Display frm = new Display();
            frm.ShowDialog();
        }

        private void displayAndUpdateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DisplaySaveChangesEmp frm = new DisplaySaveChangesEmp();
            frm.ShowDialog();
        }

        private void displayAndRecordHoursToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddWorkingHours frm = new AddWorkingHours();
            frm.ShowDialog();
        }

        private void displayAllInformationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SelectAllEmployees frm = new SelectAllEmployees();
            frm.ShowDialog();
        }

        private void findAnEmployeeByIDOrEmailToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SelectEmployeeByID_Email frm = new SelectEmployeeByID_Email();
            frm.ShowDialog();
        }

        private void displayWorkDateAndHoursSearchByIDToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DisplayHours frm = new DisplayHours();
            frm.ShowDialog();
        }

        private void displayTotalHoursWorkedByEmployeeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DisplayTotalHours frm = new DisplayTotalHours();
            frm.ShowDialog();
        }

       
    }
}
 