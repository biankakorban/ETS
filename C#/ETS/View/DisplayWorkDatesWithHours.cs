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
    public partial class DisplayHours : Form
    {
        public DisplayHours()
        {
            InitializeComponent();
        }

        private void btnSelectHours_Click(object sender, EventArgs e)
        {

            //validation 
            if (!ValidationHelper.NumberOnly(txtEmpIDispHours.Text))
            {
                MessageBox.Show("Only numbers");
                return;
            }



            //read input
            int empID;

            if (txtEmpIDispHours.Text != "")
            {
                empID = int.Parse(txtEmpIDispHours.Text);
                WorkingHoursController controller = new WorkingHoursController();
                Result<WorkingHours> result = controller.GetWorkDateHours(empID);

                switch (result.Status)
                {
                    case ResultEnum.Success:
                        //List<WorkingHours> hours = result.Data;
                        //listBoxShowHours.DataSource = hours;
                        //listBoxShowHours.DisplayMember = "WorkDate";
                        //listBoxShowHours.DataSource = hours;
                        //listBoxShowHours.DisplayMember = "Hours";

                        listBoxShowHours.DataSource = result.Data;

                        break;
                    case ResultEnum.Fail:
                        MessageBox.Show("Error, cannot show work date and hours");
                        break;
                    default:
                        break;
                }
            }
            else
            {
                MessageBox.Show("Error");
            }
        }
    }
}
