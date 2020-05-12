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
using System.Windows.Forms;

namespace Automation_1.User_forms
{
    public partial class Frm_ShowDrafts : Form
    {
        public lbl_newsandinformation mainuser;
        public Frm_ShowDrafts(/*frm_MainUser inparent */)
        {
           // mainuser = inparent;
            InitializeComponent();
        }

        private void Frm_ShowDrafts_Load(object sender, EventArgs e)
        {
            this.Top = 135;
            this.Left = 1;
            showdrafts(SearchDrafts());
        }
        private void showdrafts(string SearchStatmnet)
        {
            var query = DBCommon.Context.Database.SqlQuery<VW_Letters>("select * From VW_Letters where DraftyType=1 and UserID="+PublicVariebale.gUserID + SearchStatmnet);
            var result = query.ToList();
            dgv_Drafts.Rows.Clear();
            if (result.Count != 0)
            {
                dgv_Drafts.RowCount = result.Count;
                for (int i = 0; i <= result.Count - 1; i++)
                {
                    dgv_Drafts.Rows[i].Cells["LetterID"].Value = result[i].LetterID;
                    dgv_Drafts.Rows[i].Cells["forcet"].Value = result[i].ForceType;
                    dgv_Drafts.Rows[i].Cells["LetterNumber"].Value = result[i].LetterNum;
                    dgv_Drafts.Rows[i].Cells["subject"].Value = result[i].Subject;
                    dgv_Drafts.Rows[i].Cells["lettertype"].Value = result[i].FarsiLetterType;
                    dgv_Drafts.Rows[i].Cells["lettertypet"].Value = result[i].LetterType;
                    dgv_Drafts.Rows[i].Cells["AnswerType"].Value = result[i].AnswerType;
                    dgv_Drafts.Rows[i].Cells["forieat"].Value = result[i].FarsiForceType;
                    dgv_Drafts.Rows[i].Cells["tabaghebandi"].Value = result[i].FarsiSecuretyType;
                    dgv_Drafts.Rows[i].Cells["ReplayLetterID"].Value = result[i].ReplayLetterID;
                    dgv_Drafts.Rows[i].Cells["peygiri"].Value = result[i].FarsiPeygiriType;
                    dgv_Drafts.Rows[i].Cells["peyvast"].Value = result[i].FarsiAttachmentType;
                    dgv_Drafts.Rows[i].Cells["pasokh"].Value = result[i].FarsiAnswerType;
                    dgv_Drafts.Rows[i].Cells["tarikhepasokh"].Value = result[i].Answerdeadline;
                    if (Convert.ToInt32(dgv_Drafts.Rows[i].Cells["forcet"].Value) == 2) {
                        dgv_Drafts.Rows[i].Cells["forieat"].Style.BackColor = Color.Yellow;
                    }
                    if (Convert.ToInt32(dgv_Drafts.Rows[i].Cells["forcet"].Value) == 3)
                    {
                        dgv_Drafts.Rows[i].Cells["forieat"].Style.BackColor = Color.Red;
                    }


                }
                dgv_Drafts.ScrollBars = ScrollBars.Both;


            }
            else
            {

                dgv_Drafts.Rows.Clear();
            }
        }
        private string SearchDrafts()
        {

            string search = "";
            if (txt_Subject.Text != "")
            {
                search += "and Subject like'%" + txt_Subject.Text + "%'";
            }
            if (rdb_addi_force.Checked) {
                search += "and ForceType=1";
            }
            if (rdb_fori.Checked)
            {
                search += "and ForceType=2";
            }
            if (rdb_ani.Checked)
            {
                search += "and ForceType=3";
            }
            if (rdb_addi_sec.Checked)
            {
                search += "and SecuretyType=1";
            }
            if (rdb_mahramane.Checked)
            {
                search += "and SecuretyType=2";
            }
            if (rdb_seri.Checked)
            {
                search += "and SecuretyType=3";
            }
            return search;

        }

        private void btn_Search_Click(object sender, EventArgs e)
        {
            showdrafts(SearchDrafts());
        }

        private void btn_Clsoe_Click(object sender, EventArgs e)
        {
            int item = dgv_Drafts.SelectedCells.Count;
            if (item > 0)
            {
                if (MessageBox.Show("آیا از حذف اطلاعات مطمعن هستید ", "حذف", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    int letterid = Convert.ToInt32(dgv_Drafts.CurrentRow.Cells["LetterID"].Value);
                    var query = (from l in DBCommon.Context.Letters where l.LetterID == letterid select l).SingleOrDefault();
                    
                    var query2 = (from at in DBCommon.Context.AtachFile where at.LetterID == letterid select at).SingleOrDefault();
                    if (query2 != null)
                    {

                        DBCommon.Context.AtachFile.Remove(query2);
                    }
                    DBCommon.Context.Letters.Remove(query);
                    DBCommon.Context.SaveChanges();
                    MessageBox.Show("اطلاعات با موقیت حذف شد", "حذف", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    showdrafts(SearchDrafts());
                }
            }
            else {
                MessageBox.Show("لطفا ابتدا سطری را انتخاب کنید", "حذف", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void btn_InsertUser_Click(object sender, EventArgs e)
        {
         
            int item = dgv_Drafts.SelectedCells.Count;
            int getCreatorLetter;
          
            if (item > 0)
            {
                if (Convert.ToInt16(dgv_Drafts.CurrentRow.Cells["lettertypet"].Value) == 2)
                {
                    int GetReplayLetterID = Convert.ToInt32(dgv_Drafts.CurrentRow.Cells["ReplayLetterID"].Value);
                    var query = (from l in DBCommon.Context.Letters where l.LetterID == GetReplayLetterID select l).ToList();
                    if (query.Count > 0)
                    {
                        getCreatorLetter = query[0].UserID;
                        Frm_SelectedUserForSendLetter fm = new Frm_SelectedUserForSendLetter();
                        fm.GetLetterID = Convert.ToInt32(dgv_Drafts.CurrentRow.Cells["LetterID"].Value);
                        fm.GuserID = getCreatorLetter;
                        fm.Replayid = 1;
                        fm.TopMost = true;
                        fm.Show();
                    }
                }
                else
                {
                    Frm_SelectedUserForSendLetter fm = new Frm_SelectedUserForSendLetter();
                    fm.GetLetterID = Convert.ToInt32(dgv_Drafts.CurrentRow.Cells["LetterID"].Value);
                    fm.TopMost = true;
                    fm.Show();
                    showdrafts(SearchDrafts());

                }

                

                
                showdrafts(SearchDrafts());
            }
            else {
                MessageBox.Show("لطفا ابتدا ردیفی را انتخاب کنید", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void Edit_Letter_Click(object sender, EventArgs e)
        {
            int item=dgv_Drafts.SelectedCells.Count;
            if (item > 0)
            {
                Frm_CreateLetter fm = new Frm_CreateLetter();
                //fm.MdiParent = mainuser;
                fm.TopMost = true;
                fm.getFormtype = 2;///edit
                fm.getLetterID = Convert.ToInt32(dgv_Drafts.CurrentRow.Cells["LetterID"].Value);
                this.Close();
                fm.Show();
                showdrafts(SearchDrafts());


            }
            else {

                MessageBox.Show("برای ویرایش نامه ابتدا نامه ای را انتخاب کنید", "ویرایش", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
           
        }
    }
}
