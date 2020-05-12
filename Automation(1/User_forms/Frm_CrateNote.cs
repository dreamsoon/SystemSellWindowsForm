using Automation_1.Modula;
using DataModelLayer.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;
using System.Windows.Forms;

namespace Automation_1.User_forms
{
    public partial class Frm_CrateNote : Form
    {
        public Frm_CrateNote()
        {
            InitializeComponent();
        }
        private void ShowUser(string SearchStatmnet)
        {
            var query = DBCommon.Context.Database.SqlQuery<VW_UserJobs>("select * from VW_UserJobs where Status = 1 and JobsDetermineLevel >=" + PublicVariebale.JobsDetermineLevel + "-1" + SearchStatmnet + " except(select * from VW_UserJobs where UserID = " + PublicVariebale.gUserID + ")");
            var result = query.ToList();
            if (result.Count != 0)
            {
                dgvShowUser.RowCount = result.Count;
                for (int i = 0; i <= result.Count - 1; i++)
                {
                    dgvShowUser.Rows[i].Cells["UsersJobsID"].Value = result[i].UsersJobsID;
                    dgvShowUser.Rows[i].Cells["UserID"].Value = result[i].UserID;
                    dgvShowUser.Rows[i].Cells["FullName"].Value = result[i].UserFullName;
                    dgvShowUser.Rows[i].Cells["Job"].Value = result[i].JobsName;



                }
                dgvShowUser.ScrollBars = ScrollBars.Both;


            }
            else
            {

                dgvShowUser.Rows.Clear();
            }
        }
        private string SearchUser()
        {
            string search = "";


            if (txt_FullName.Text != "")
            {
                search += "and UserFullName like'%" + txt_FullName.Text + "%'";
            }
            return search;

        }

        private void Frm_CrateNote_Load(object sender, EventArgs e)
        {
            this.Top = 135;
            this.Left = 1;
            ShowUser(SearchUser());
            lbl_Date.Text = PublicVariebale.ToDayDate;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            ShowUser(SearchUser());
        }

        private void btn_Send_Click(object sender, EventArgs e)
        {
            if (txt_Subject.Text == "" && txt_Text.Text == "") {
                MessageBox.Show("لطفا موضوع یاداشت و متن یاداشت را وارد کنید", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_Subject.Focus();
                return;
                
            }
            int counter = 0;
            foreach (DataGridViewRow row in dgvShowUser.Rows) {
                if (Convert.ToBoolean(row.Cells["Select"].Value) == true) {
                    counter++;
                }

            }
            if (counter == 0) {
                MessageBox.Show("لطفا یک کاربر را انتخاب کنید", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            using (TransactionScope ts = new TransactionScope())
            {
                Note n = new Note();
                n.Subject = txt_Subject.Text.Trim();
                n.MainText = txt_Text.Text.Trim();
                n.CrateDate = lbl_Date.Text;
                n.UseriID = PublicVariebale.gUserID;
                DBCommon.Context.Note.Add(n);
                DBCommon.Context.SaveChanges();

                ///////////

                List<DataGridView> chek_User = new List<DataGridView>();
                foreach (DataGridViewRow row in dgvShowUser.Rows)
                {
                   
                    SenNote sn = new SenNote();


                    if (Convert.ToBoolean(row.Cells["Select"].Value) == true)
                    {
                        sn.UserID = Convert.ToInt32(row.Cells["UserID"].Value);
                        sn.NoteID = n.NoteID;
                        
                        DBCommon.Context.SenNote.Add(sn);
                    }
                }
                DBCommon.Context.SaveChanges();
                ts.Complete();
                MessageBox.Show("ارسال یاداشت با موفقیت انجام شد", "موفقیت", MessageBoxButtons.OK, MessageBoxIcon.Information);
        



            }
        }
    }
}
