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
using Automation_1.Modula;

namespace Automation_1.Admin_forms
{
    public partial class frm_JobsHistory : Form
    {
        public int GetUserID { set; get; }
        public string GetFullName { set; get; }

        public frm_JobsHistory()
        {
            InitializeComponent();
        }

        private void frm_JobsHistory_Load(object sender, EventArgs e)
        {
            lbl_Fullname.Text = GetFullName;
            ShowUserInfo();
        }

        private void ShowUserInfo()
        {
            var query = DBCommon.Context.Database.SqlQuery<VW_UserJobs>("select * From VW_UserJobs where UserID = " + this.GetUserID);
            var result = query.ToList();
            if (result.Count != 0)
            {
                dataGridViewX1.RowCount = result.Count;
                for (int i = 0; i <= result.Count - 1; i++)
                {
                    dataGridViewX1.Rows[i].Cells["FullName"].Value = result[i].UserFullName;
                    dataGridViewX1.Rows[i].Cells["JobName"].Value = result[i].JobsName;
                    dataGridViewX1.Rows[i].Cells["EnterJobDate"].Value = result[i].StartDate;
                    dataGridViewX1.Rows[i].Cells["ExitJobDate"].Value = result[i].EndDate;
                    dataGridViewX1.Rows[i].Cells["Status"].Value = result[i].FarsiStatus;
                }
                dataGridViewX1.ScrollBars = ScrollBars.Both;

            }
            else
            {

                dataGridViewX1.Rows.Clear();
            }
        }

        private void btn_Clsoe_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_InsertUser_Click(object sender, EventArgs e)
        {
            var query = (from u in DBCommon.Context.UsersJobs where u.UserID == this.GetUserID where u.Status == 1 select u).ToList();
            if (query.Count > 0)
            {

                MessageBox.Show("این کاربر در حال حاضر دارای شغل میباشد در ضورت انتصاب شغل جدید شغل فغلی وی باید عزل شود", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else {
                frm_setjobs fm = new frm_setjobs();
                fm.GetUserIDForSetJob = this.GetUserID;
                fm.lbl_fulllnnameset.Text = lbl_Fullname.Text;
                fm.ShowDialog();
                ShowUserInfo();
            }
         
        }

        private void btn_EditUser_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("آیا از عزل شغل مطمعن هستید", "عزل شغل", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                try
                {
                    var query = (from j in DBCommon.Context.UsersJobs

                                 where j.UserID == this.GetUserID
                                 where j.Status == 1
                                 select j).SingleOrDefault();
                    query.Status = 2;
                    query.EndDate = PublicVariebale.ToDayDate;
                    DBCommon.Context.SaveChanges();
                    MessageBox.Show("اطلاعات با موفقیت ویرایش شد");
                    ShowUserInfo();


                }
                catch (Exception)
                {

                    MessageBox.Show("در ارتباط با سرور مشکلی پیش آمده است");
                }
            }

        }
    }
}
