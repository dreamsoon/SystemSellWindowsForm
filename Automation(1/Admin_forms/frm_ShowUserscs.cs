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
    public partial class frm_ShowUserscs : Form
    {

        public frm_ShowUserscs()
        {
            InitializeComponent();
        }
        AutomationNewEntities DB = new AutomationNewEntities();
        private void btn_Clsoe_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frm_ShowUserscs_Load(object sender, EventArgs e)
        {
            UserInfo(CrateStringSearch());

        }

        private void UserInfo(string SearchStatment)
        {
            var query = DBCommon.Context.Database.SqlQuery<VW_Users>("select * From VW_Users where 1=1" + SearchStatment);
            var result = query.ToList();

            if (result.Count != 0)
            {
                dgv_ShowUserInfo.RowCount = result.Count;
                for (int i = 0; i <= result.Count - 1; i++)
                {

                    dgv_ShowUserInfo.Rows[i].Cells["col_UserID"].Value = result[i].UserID;
                    dgv_ShowUserInfo.Rows[i].Cells["col_Name"].Value = result[i].UserFirstName;
                    dgv_ShowUserInfo.Rows[i].Cells["col_Family"].Value = result[i].UserFamily;
                    dgv_ShowUserInfo.Rows[i].Cells["col_tell"].Value = result[i].UserTell;
                    dgv_ShowUserInfo.Rows[i].Cells["col_Gender"].Value = result[i].FarsiGender;
                    dgv_ShowUserInfo.Rows[i].Cells["col_BirthdayDate"].Value = result[i].UserBrithDay;
                    dgv_ShowUserInfo.Rows[i].Cells["col_status"].Value = result[i].FarsiUserActivity;
                    dgv_ShowUserInfo.Rows[i].Cells["col_Email"].Value = result[i].UserEmail;
                    dgv_ShowUserInfo.Rows[i].Cells["col_PersnolaCode"].Value = result[i].UserPersonalCode;
                    dgv_ShowUserInfo.Rows[i].Cells["col_UserName"].Value = result[i].UserUserName;
                    dgv_ShowUserInfo.Rows[i].Cells["Gender"].Value = result[i].UserGender;
                    dgv_ShowUserInfo.Rows[i].Cells["col_Password"].Value = result[i].UserPassword;
                }
                dgv_ShowUserInfo.ScrollBars = ScrollBars.Both;

            }
            else
            {

                dgv_ShowUserInfo.Rows.Clear();
            }
        }
        private string CrateStringSearch()
        {
            string searchstring = "";
            if (txt_Name.Text != "")
            {
                searchstring += " and UserFirstName like '%" + txt_Name.Text.Trim() + "%'";
            }
            if (txt_LastName.Text != "")
            {
                searchstring += " and UserFamily like '%" + txt_LastName.Text.Trim() + "%'";
            }
            if (rdb_active.Checked)
            {

                searchstring += " and UserActivity = 1";
                
            }
            if (rdb_deactive.Checked)
            {

                searchstring += " and UserActivity = 2";
            }
            if (rdb_Man.Checked)
            {

                searchstring += " and UserGender = 1";
            }
            if (rdb_Women.Checked)
            {

                searchstring += " and UserGender = 2";
            }

            return searchstring;
        }

        private void btn_Search_Click(object sender, EventArgs e)
        {
            UserInfo(CrateStringSearch());
        }

        private void btn_InsertUser_Click(object sender, EventArgs e)
        {

            frm_Add_Edit_Users fm = new frm_Add_Edit_Users();
            fm.formtype = 1;
            fm.ShowDialog();
            UserInfo(CrateStringSearch());
        }

        private void btn_EditUser_Click(object sender, EventArgs e)
        {
            int item = dgv_ShowUserInfo.SelectedCells.Count;
            if (item > 0)
            {
                frm_Add_Edit_Users fm = new frm_Add_Edit_Users();
                fm.formtype = 2;
                fm.UserID = Convert.ToInt32(dgv_ShowUserInfo.CurrentRow.Cells["col_UserID"].Value);
                fm.ShowDialog();
                UserInfo(CrateStringSearch());
            }
            else
            {

                MessageBox.Show("لطفا ردیفی را انخاب کنید", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void btn_DeactiveUser_Click(object sender, EventArgs e)
        {
            int item = dgv_ShowUserInfo.SelectedCells.Count;
            if (item > 0)
            {
                if ((MessageBox.Show("آیا از غیر فعال کردن " + dgv_ShowUserInfo.CurrentRow.Cells["col_Name"].Value.ToString() + " " + dgv_ShowUserInfo.CurrentRow.Cells["col_Family"].Value.ToString() + " " + "مطمعن هستید ؟", "غیر فعال کردن", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes))
                {
                    int UserID = Convert.ToInt32(dgv_ShowUserInfo.CurrentRow.Cells["col_UserID"].Value);
                    var query = (from u in DBCommon.Context.Users where u.UserID == UserID select u).SingleOrDefault();
                    query.UserActivity = 2;
                    DBCommon.Context.SaveChanges();
                    MessageBox.Show("کاربر مورد نظر غیر فعال گردید", "غیر فعال", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    UserInfo(CrateStringSearch());
                }

                else
                {
                    return;
                }
            }
            else
            {
                MessageBox.Show("لطفا ردیفی را انخاب کنید", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void mnuActive_Click(object sender, EventArgs e)
        {
            int item = dgv_ShowUserInfo.SelectedCells.Count;
            if (item > 0)
            {
                if ((MessageBox.Show("آیا از  فعال کردن " + dgv_ShowUserInfo.CurrentRow.Cells["col_Name"].Value.ToString() + " " + dgv_ShowUserInfo.CurrentRow.Cells["col_Family"].Value.ToString() + " " + "مطمعن هستید ؟", " فعال کردن", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes))
                {
                    int UserID = Convert.ToInt32(dgv_ShowUserInfo.CurrentRow.Cells["col_UserID"].Value);
                    var query = (from u in DBCommon.Context.Users where u.UserID == UserID select u).SingleOrDefault();
                    query.UserActivity = 1;
                    DBCommon.Context.SaveChanges();
                    MessageBox.Show("کاربر مورد نظر  فعال گردید", " فعال", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    UserInfo(CrateStringSearch());
                }

                else
                {
                    return;
                }
            }
            else
            {
                MessageBox.Show("لطفا ردیفی را انخاب کنید", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void dgv_ShowUserInfo_DoubleClick(object sender, EventArgs e)
        {
            frm_ShowUserInfo fm = new frm_ShowUserInfo();
            fm.UserID = Convert.ToInt32(dgv_ShowUserInfo.CurrentRow.Cells["col_UserID"].Value);
            fm.ShowDialog();
        }

        private void btn_accesright_Click(object sender, EventArgs e)
        {
            int item = dgv_ShowUserInfo.SelectedCells.Count;
            if (item > 0)
            {
                Frm_AddAccessRight fm = new Frm_AddAccessRight();
                fm.UserID = Convert.ToInt32(dgv_ShowUserInfo.CurrentRow.Cells["col_UserID"].Value);
                fm.FirstName = dgv_ShowUserInfo.CurrentRow.Cells["col_Name"].Value.ToString();
                fm.LasttName = dgv_ShowUserInfo.CurrentRow.Cells["col_Family"].Value.ToString();
                fm.ShowDialog();

            }
            else
            {
                MessageBox.Show("لطفا ردیفی را انخاب کنید", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void btn_password_Click(object sender, EventArgs e)
        {
           Frm_ChangePassword fm = new Frm_ChangePassword();
            fm.UserID = Convert.ToInt32(dgv_ShowUserInfo.CurrentRow.Cells["col_UserID"].Value);
            fm.FirstName = dgv_ShowUserInfo.CurrentRow.Cells["col_Name"].Value.ToString();
            fm.LastName = dgv_ShowUserInfo.CurrentRow.Cells["col_Family"].Value.ToString();
            fm.ShowDialog();
        }

        private void btn_Print_Click(object sender, EventArgs e)
        {
            stiReport1.Render(true);
            stiReport1.Show();
        }
    }
}
