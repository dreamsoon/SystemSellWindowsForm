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
using System.Transactions;

namespace Automation_1.User_forms
{
    public partial class Frm_SelectedUserForSendLetter : Form
    {
        public int GetLetterID { set; get; }
        public int GuserID { get; set; }
        public byte Replayid { get; set; }
        public byte Refrencetype { get; set; }
        public int refrencekonande { get; set; }
        public int refrenceshode{get;set;}
        public Frm_SelectedUserForSendLetter()
        {
            InitializeComponent();
        }

        private void Frm_SelectedUserForSendLetter_Load(object sender, EventArgs e)
        {
            if (Replayid == 1)
            {
                ShowUserforreplay(SearchUser());
            }
            else
            {
                ShowUser(SearchUser());
            }
        }
        private void ShowUser(string SearchStatmnet)
        {
            var query = DBCommon.Context.Database.SqlQuery<VW_UserJobs>("select * from VW_UserJobs where Status = 1 and JobsDetermineLevel >=" + PublicVariebale.JobsDetermineLevel + "-1"+ SearchStatmnet+ " except(select * from VW_UserJobs where UserID = " + PublicVariebale.gUserID +")");
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
        private void ShowUserforreplay(string SearchStatmnet)
        {
            var query = DBCommon.Context.Database.SqlQuery<VW_UserJobs>("select * from VW_UserJobs where UserID="+this.GuserID+"and Status = 1 and JobsDetermineLevel >=" + PublicVariebale.JobsDetermineLevel + "-1" + SearchStatmnet );
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
            string search="";


            if (txt_FullName.Text != "")
            {
                search += "and UserFullName like'%" + txt_FullName.Text + "%'";
            }
            return search;

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            ShowUser(SearchUser());
        }

        private void btn_Clsoe_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_Send_Click(object sender, EventArgs e)
        {
            if (Refrencetype == 1) {


                using (TransactionScope ts = new TransactionScope())
                {
                    
                    List<DataGridView> chek_User = new List<DataGridView>();
                    foreach (DataGridViewRow row in dgvShowUser.Rows)
                    {
                        //Insertsenddate();
                        Refrences rf = new Refrences();


                        if (Convert.ToBoolean(row.Cells["Select"].Value) == true)
                        {
                            rf.LetterID = this.GetLetterID;
                            rf.UserID = this.refrencekonande;
                            rf.RefrenceUserID = this.refrenceshode;
                            rf.ReciveRefrenceUserID= Convert.ToInt32(row.Cells["UserID"].Value);
                            rf.CreateDate = PublicVariebale.ToDayDate;
                            DBCommon.Context.Refrences.Add(rf);
                            DBCommon.Context.SaveChanges();
                        }
                    }
                    DBCommon.Context.SaveChanges();
                    ts.Complete();
                    MessageBox.Show("ارجاع نامه با موفقیت انجام شد", "موفقیت", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();



                }

            }
            else {
                using (TransactionScope ts = new TransactionScope())
                {
                    ///Exit to Draft
                    ///
                    var query_Update = (from u in DBCommon.Context.Letters where u.LetterID == this.GetLetterID select u).SingleOrDefault();
                    query_Update.DraftyType = 2;
                    query_Update.SendLetterDate = PublicVariebale.ToDayDate;
                    DBCommon.Context.SaveChanges();
                    /////
                    ///
                    List<DataGridView> chek_User = new List<DataGridView>();
                    foreach (DataGridViewRow row in dgvShowUser.Rows)
                    {
                        //Insertsenddate();
                        SendLetter sl = new SendLetter();


                        if (Convert.ToBoolean(row.Cells["Select"].Value) == true)
                        {
                            sl.UserID = Convert.ToInt32(row.Cells["UserID"].Value);
                            sl.LetterID = this.GetLetterID;
                            sl.ReadType = 1;
                            sl.Status = 1;
                            DBCommon.Context.SendLetter.Add(sl);
                        }
                    }
                    DBCommon.Context.SaveChanges();
                    ts.Complete();
                    MessageBox.Show("ارسال نامه با موفقیت انجام شد", "موفقیت", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();

                }

            }
        }

        private void Insertsenddate()
        {
            Letters ls = new Letters();
            var query_update = (from lt in DBCommon.Context.Letters where lt.LetterID == GetLetterID select lt).SingleOrDefault();
            query_update.SendLetterDate = PublicVariebale.ToDayDate;
            query_update.DraftyType = 2;
            DBCommon.Context.SaveChanges();
        }
    }
}
