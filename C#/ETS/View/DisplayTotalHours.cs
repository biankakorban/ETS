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
    public partial class DisplayTotalHours : Form
    {
        public DisplayTotalHours()
        {
            InitializeComponent();
        }


        private string CountTotalHours(List<WorkingHours> workHours)
        {
            double count = 0;
            foreach (var hours in workHours)
            {
                count += hours.Hours;
            }
            return count.ToString();
        }

        private void btnDisplayTotalHours_Click(object sender, EventArgs e)
        {


           if (!ValidationHelper.NumberOnly(txtID.Text))
            {
                MessageBox.Show("Only numbers");
                return;
            }

            int empID;
            if (txtID.Text != "")
            {
                empID = int.Parse(txtID.Text);
                WorkingHoursController controller = new WorkingHoursController();
                Result<WorkingHours> result = controller.GetWorkDateHours(empID);

                switch (result.Status)
                {
                    case ResultEnum.Success:
                        List<WorkingHours> hours = result.Data; 
                        lblTotalHours.Text = CountTotalHours(hours);
                        break;
                    case ResultEnum.Fail:
                        MessageBox.Show("Error, cannot show total hours worked");
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
    
            



         
