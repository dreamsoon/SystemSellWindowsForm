using DataModelLayer.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Automation_1.Admin_forms
{
    public partial class frm_UserLog : Form
    {
        public frm_UserLog()
        {
            InitializeComponent();
        }

        private void frm_UserLog_Load(object sender, EventArgs e)
        {
            persianDate_az.Value = DateTime.Now.AddDays(-10);
            ShowUserLogInfo(SearchRemember());
        }
        private void ShowUserLogInfo(string SearchString)
        {
            var query = DBCommon.Context.Database.SqlQuery<VW_UserLog>("select * From VW_UserLog where 1=1" + SearchString);
            var result = query.ToList();
            if (result.Count != 0)
            {
                dgv_EnterAndExit.RowCount = result.Count;
                for (int i = 0; i <= result.Count - 1; i++)
                {
                    dgv_EnterAndExit.Rows[i].Cells["UserFullName"].Value = result[i].UserFullName;
                    dgv_EnterAndExit.Rows[i].Cells["ComputerName"].Value = result[i].ComputerName;
                    dgv_EnterAndExit.Rows[i].Cells["IP"].Value = result[i].IPAddres;
                    dgv_EnterAndExit.Rows[i].Cells["EnterDate"].Value = result[i].EnterDateTime;
                    dgv_EnterAndExit.Rows[i].Cells["ExitDate"].Value = result[i].ExitDateTime;

                }
                dgv_EnterAndExit.ScrollBars = ScrollBars.Both;

            }
            else
            {

                dgv_EnterAndExit.Rows.Clear();
            }
        }
        private string SearchRemember()
        {

            string SearchString = "";
            string DateAz = string.Format("{0:yyyy/MM/dd}", Convert.ToDateTime(persianDate_az.Value.Year.ToString() + "/" + persianDate_az.Value.Month.ToString() + "/" + persianDate_az.Value.Day.ToString())) + "-" + Time_Az.Value.ToString("HH:mm:ss");
            string DateTa = string.Format("{0:yyyy/MM/dd}", Convert.ToDateTime(persianDate_ta.Value.Year.ToString() + "/" + persianDate_ta.Value.Month.ToString() + "/" + persianDate_ta.Value.Day.ToString())) + "-" + Time_Ta.Value.ToString("HH:mm:ss");
            SearchString += " and EnterDateTime between '" + DateAz + "' and '" + DateTa + "'";
            if (txt_FullName.Text.Trim() != "")
            {

                SearchString += " and UserFullName Like '%" + txt_FullName.Text.Trim() + "%'";
            }
            if (txt_ComputerName.Text.Trim() != "")
            {

                SearchString += " and ComputerName Like '%" + txt_ComputerName.Text.Trim() + "%'";
            }
            if (txt_ip.Text.Trim() != "")
            {

                SearchString += " and IPAddres Like '%" + txt_ip.Text.Trim() + "%'";
            }


            return SearchString;

        }

        private void btn_Search_Click(object sender, EventArgs e)
        {
            ShowUserLogInfo(SearchRemember());
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
