using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DataModelLayer.Model;

namespace Automation_1.Admin_forms
{
    public partial class frm_selectedjobs : Form
    {
        public frm_selectedjobs()
        {
            InitializeComponent();
        }
        private string CrateStringSearch()
        {
            string searchstring = "";
            if (txt_Name.Text != "")
            {
                searchstring += " and UserFirstName like '%" + txt_Name.Text.Trim() + "%'";
            }
            if (txt_Family.Text != "")
            {
                searchstring += " and UserFamily like '%" + txt_Family.Text.Trim() + "%'";
            }
            if (txt_Family.Text != "")
            {
                searchstring += " and PersonalCode like '%" + txt_PersenoalCode.Text.Trim() + "%'";
            }



            return searchstring;
        }
        private void ShowUserInfo(string searchstatment)
        {
            var query = DBCommon.Context.Database.SqlQuery<VW_Users>("select * From VW_Users where 1=1 " + searchstatment);
            var result = query.ToList();
            if (result.Count != 0)
            {
                dgv_Showusers.RowCount = result.Count;
                for (int i = 0; i <= result.Count - 1; i++)
                {
                    dgv_Showusers.Rows[i].Cells["UserID"].Value = result[i].UserID;
                    dgv_Showusers.Rows[i].Cells["UserName"].Value = result[i].UserFirstName;
                    dgv_Showusers.Rows[i].Cells["UserFamily"].Value = result[i].UserFamily;


                    dgv_Showusers.Rows[i].Cells["Activity"].Value = result[i].FarsiUserActivity;

                    dgv_Showusers.Rows[i].Cells["persenalCode"].Value = result[i].UserPersonalCode;

                }
                dgv_Showusers.ScrollBars = ScrollBars.Both;

            }
            else
            {

                dgv_Showusers.Rows.Clear();
            }
        }

        private void frm_selectedjobs_Load(object sender, EventArgs e)
        {
            ShowUserInfo(CrateStringSearch());
        }

        private void btn_Search_Click(object sender, EventArgs e)
        {
            ShowUserInfo(CrateStringSearch());

        }

        private void btn_Clsoe_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_DeactiveUser_Click(object sender, EventArgs e)
        {
            frm_JobsHistory fm = new frm_JobsHistory();
            int item = dgv_Showusers.SelectedCells.Count;
            if (item > 0)
            {
                fm.GetUserID = Convert.ToInt32(dgv_Showusers.CurrentRow.Cells["UserID"].Value);
                fm.GetFullName = dgv_Showusers.CurrentRow.Cells["UserName"].Value + " " + dgv_Showusers.CurrentRow.Cells["UserFamily"].Value;

            }
            else {
                MessageBox.Show("لطفا ردیفی را انخاب کنید", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            fm.ShowDialog();
        }
    }
}
