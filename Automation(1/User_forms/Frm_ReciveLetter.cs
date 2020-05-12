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
using System.IO;
using Stimulsoft.Report;

namespace Automation_1.User_forms
{
    public partial class Frm_ReciveLetter : Form
    {
        public bool most = false;
        public Frm_ReciveLetter()
        {
            InitializeComponent();
        }

        private void Frm_ReciveLetter_Load(object sender, EventArgs e)
        {
            if (most == true)
            {
                this.TopMost = false;
            }
            this.Top = 135;
            this.Left = 1;
            timepicker_az.Value = DateTime.Now.AddDays(-10);


            ShowReciveLetter(Searchstring());
        }
        private void ShowReciveLetter(string Searchstring)
        {
            var query = DBCommon.Context.Database.SqlQuery<VW_ReciveLetter>("select * From VW_ReciveLetter where DraftyType=2 and User_Girande = " + PublicVariebale.gUserID + Searchstring);
            var result = query.ToList();
            dgv_ReciveLetter.Rows.Clear();
            if (result.Count != 0)
            {
                dgv_ReciveLetter.RowCount = result.Count;
                for (int i = 0; i <= result.Count - 1; i++)
                {
                    dgv_ReciveLetter.Rows[i].Cells["Letter_ID"].Value = result[i].LetterID;
                    dgv_ReciveLetter.Rows[i].Cells["UserSender"].Value = result[i].FullName;
                    dgv_ReciveLetter.Rows[i].Cells["LetterNumber"].Value = result[i].LetterNum;
                    dgv_ReciveLetter.Rows[i].Cells["forcet"].Value = result[i].ForceType;
                    dgv_ReciveLetter.Rows[i].Cells["Subject"].Value = result[i].Subject;
                    dgv_ReciveLetter.Rows[i].Cells["UserID"].Value = result[i].UserID;
                    dgv_ReciveLetter.Rows[i].Cells["tabaghebandi"].Value = result[i].FarsiSecuretyType;
                    dgv_ReciveLetter.Rows[i].Cells["bayganistatus"].Value = result[i].FarsiBayganiType;
                    dgv_ReciveLetter.Rows[i].Cells["foriat"].Value = result[i].FarsiForceType;
                    dgv_ReciveLetter.Rows[i].Cells["sanadtype"].Value = result[i].FarsiLetterType;
                    dgv_ReciveLetter.Rows[i].Cells["AnswerType"].Value = result[i].AnswerType;
                    dgv_ReciveLetter.Rows[i].Cells["mohlat"].Value = result[i].Answerdeadline;
                    dgv_ReciveLetter.Rows[i].Cells["ReadStatus"].Value = result[i].persianreadtype;
                    dgv_ReciveLetter.Rows[i].Cells["Atachment"].Value = result[i].FarsiAttachmentType;
                    dgv_ReciveLetter.Rows[i].Cells["Atachmentt"].Value = result[i].AttachmentType;
                    dgv_ReciveLetter.Rows[i].Cells["SendLetterDate"].Value = result[i].SendLetterDate;
                    //dgv_ReciveLetter.Rows[i].Cells["User_Girande"].Value = result[i].User_Girande;
                    if (Convert.ToInt16(dgv_ReciveLetter.Rows[i].Cells["Atachmentt"].Value) == 1)
                    {

                        dgv_ReciveLetter.Rows[i].Cells["DownloadAtachment"].Value = result[i].FileName;
                    }
                  

                }

                dgv_ReciveLetter.TopLeftHeaderCell.Value = "ردیف";
                for (int i = 0; i <= dgv_ReciveLetter.Rows.Count - 1; i++)
                {
                    dgv_ReciveLetter.Rows[i].HeaderCell.Value = (i + 1).ToString();
                }
                dgv_ReciveLetter.ScrollBars = ScrollBars.Both;


            }
            else
            {

                dgv_ReciveLetter.Rows.Clear();
            }
        }
        private void saveatachment(SaveFileDialog objsdf, DataGridView objgrid, int getLetterID)
        {
            string strid = objgrid.CurrentRow.Cells["DownloadAtachment"].Value.ToString();
            if (strid != "")
            {

                var query_atachment = (from af in DBCommon.Context.AtachFile where af.LetterID == getLetterID select af).ToList();
                byte[] objdata;
                objdata = (byte[])query_atachment[0].FileData;
                objsdf.FileName = query_atachment[0].FileName;
                if (objsdf.ShowDialog() != DialogResult.Cancel)
                {
                    string strfiletosave = objsdf.FileName;
                    FileStream objfilestream = new FileStream(strfiletosave, FileMode.Create, FileAccess.Write);
                    objfilestream.Write(objdata, 0, objdata.Length);
                    MessageBox.Show("فایل با موفقیت ذخیره شذ", "ذخیره", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
            }
        }

        private void dgv_ReciveLetter_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgv_ReciveLetter.CurrentCell.ColumnIndex.Equals(13) && e.RowIndex != -1)
            {

                if (dgv_ReciveLetter.CurrentCell != null && dgv_ReciveLetter.CurrentCell.Value != null)
                {

                    int GetLetterID = Convert.ToInt32(dgv_ReciveLetter.CurrentRow.Cells["Letter_ID"].Value);
                    saveatachment(saveFileDialog1, dgv_ReciveLetter, GetLetterID);
                }
            }
        }
        private string Searchstring()
        {
            string dateaz = String.Format("{0:yyyy/MM/dd }", Convert.ToDateTime(timepicker_az.Value.Year + "/" + timepicker_az.Value.Month + "/" + timepicker_az.Value.Day));
            string dateta = String.Format("{0:yyyy/MM/dd }", Convert.ToDateTime(timpepicker_ta.Value.Year + "/" + timpepicker_ta.Value.Month + "/" + timpepicker_ta.Value.Day));
            string search = " and SendLetterDate between '" + dateaz + "'" + " and '" + dateta + "'";
            if (txt_Sender.Text != "")
            {
                search += "and FullName like'%" + txt_Sender.Text + "%'";
            }
            if (txt_LetterNumber.Text != "")
            {
                search += "and LetterNum like'%" + txt_LetterNumber.Text + "%'";
            }
            //if (txt_Subject.Text != "")
            //{
            //    search += "and [Subject] like'%" + txt_Subject.Text + "%'";
            //}
            if (txt_atafbe.Text != "")
            {
                search += "and Refrence like'%" + txt_atafbe.Text + "%'";
            }
            ////seuritytypr
            if (rdb_tabaghe_addi.Checked == true)
            {

                search += "and SecuretyType=1";
            }
            else if (rdb_tabaghe_mahramane.Checked == true)
            {
                search += "and SecuretyType=2";
            }
            else if (rdb_tabaghe_seri.Checked == true)
            {
                search += "and SecuretyType=3";
            }
            ////force
            if (rdb_foriat_adi.Checked == true)
            {

                search += "and ForceType=1";
            }
            else if (rdb_foriat_fori.Checked == true)
            {
                search += "and ForceType=2";
            }
            else if (rdb_foriat_ani.Checked == true)
            {
                search += "and ForceType=3";
            }
            ///baygani
            ///
            if (rdb_baygani_shode.Checked == true)
            {

                search += "and BayganiType=2";
            }
            else if (rdb_baygani_nashode.Checked == true)
            {
                search += "and BayganiType=1";
            }
            ////noesanad
            ///
            if (rdb_Letter.Checked == true)
            {

                search += "and LetterType =1";
            }
            else if (rdb_Answer.Checked == true)
            {
                search += "and LetterType =2";
            }
            //////// readtype
            ///
            if (rdb_Read_shode.Checked == true)
            {

                search += "and LetterType =2";
            }
            else if (rdb_Read_Nashode.Checked == true)
            {
                search += "and LetterType =1";
            }
            //////////////atachment
            ///
            if (rdb_Peyvast_darad.Checked == true)
            {

                search += "and AttachmentType=1";
            }
            else if (rdb_Peyvast_narad.Checked == true)
            {

                search += "and AttachmentType=2";
            }
            ////////peygiri
            ///
            if (rdb_peygiri_darad.Checked == true)
            {

                search += "and PeygiriType =1";
            }
            else if (rdb_Peyvast_narad.Checked == true)
            {

                search += "and PeygiriType =2";
            }

            return search;
        }

        private void picboc_search_Click(object sender, EventArgs e)
        {
            ShowReciveLetter(Searchstring());
        }

        private void lbl_replayLetter_Click(object sender, EventArgs e)
        {
            Frm_CreateLetter fm = new Frm_CreateLetter();
            int item = dgv_ReciveLetter.SelectedCells.Count;
            if (item == 0)
            {
                MessageBox.Show("لطفا سطاری را انتخاب کنید", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (item > 0)
            {
                if (Convert.ToInt16(dgv_ReciveLetter.CurrentRow.Cells["AnswerType"].Value) == 1)
                {
                    if (Convert.ToDateTime(dgv_ReciveLetter.CurrentRow.Cells["mohlat"].Value.ToString()) < Convert.ToDateTime(PublicVariebale.ToDayDate))
                    {
                        MessageBox.Show("مهلت پاسخ نامه گذشته است", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }

                fm.getFormtype = 1;
                fm.gLetterNum = dgv_ReciveLetter.CurrentRow.Cells["LetterNumber"].Value.ToString();
                fm.getLetterID = Convert.ToInt32(dgv_ReciveLetter.CurrentRow.Cells["Letter_ID"].Value);
                fm.gReplay = 1;
                fm.TopMost = true;
                fm.lbl_replay.Text = "پاسخ نامه به شماره : " + dgv_ReciveLetter.CurrentRow.Cells["LetterNumber"].Value.ToString() + "مربوط به : " + dgv_ReciveLetter.CurrentRow.Cells["UserSender"].Value.ToString() + "می باشد";
                fm.ShowDialog();


            }
        }

        private void baygani_Click(object sender, EventArgs e)
        {
            int item = dgv_ReciveLetter.SelectedCells.Count;
            int getletterid = Convert.ToInt32(dgv_ReciveLetter.CurrentRow.Cells["Letter_ID"].Value);
            if (item > 0)
            {
                if (MessageBox.Show("آیا از بایگانی کردن این نامه مطمعن هستید ؟", "بایگانی", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    var query = (from l in DBCommon.Context.Letters where l.LetterID == getletterid select l).SingleOrDefault();
                    query.BayganiType = 2;
                    DBCommon.Context.SaveChanges();
                    MessageBox.Show("نامه با موفقیت باگانی شد", "بایگانی", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

            }
            else
            {
                MessageBox.Show("لطفا نامه ای را انتخاب کنید", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ارجاعنامهToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int item = dgv_ReciveLetter.SelectedCells.Count;
            int getletterid = Convert.ToInt32(dgv_ReciveLetter.CurrentRow.Cells["Letter_ID"].Value);
            int refrenceuser = Convert.ToInt32(dgv_ReciveLetter.CurrentRow.Cells["UserID"].Value);
            int UserId = PublicVariebale.gUserID;

            if (item > 0)
            {
                Frm_SelectedUserForSendLetter fm = new Frm_SelectedUserForSendLetter();
                fm.Refrencetype = 1;
                fm.GetLetterID = getletterid;
                fm.refrencekonande = UserId;
                fm.refrenceshode = refrenceuser;
                fm.TopMost = true;
                fm.Show();

            }
            else
            {

                MessageBox.Show("لطفا نامه ای را انتخاب کنید", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void خواندننامهToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int Letterid = Convert.ToInt32(dgv_ReciveLetter.CurrentRow.Cells["Letter_ID"].Value);
            stiReport1["letterid"] = Letterid;
            stiReport1.Dictionary.Variables["to"].Value = PublicVariebale.gUserFirstName + " " + PublicVariebale.gUserFamily;
            stiReport1.Dictionary.Variables["ReportDate"].Value = PublicVariebale.ToDayDate;
            stiReport1.Compile();
            stiReport1.Render();
            stiReport1.Show();
            Frm_ReadLetter(Letterid);
            most = true;
            Frm_ReciveLetter_Load(sender, e);


        }

        private void Frm_ReadLetter(int letterid)
        {
            var query = (from u in DBCommon.Context.SendLetter where u.LetterID == letterid select u).SingleOrDefault();
            query.ReadType = 2;
            DBCommon.Context.SaveChanges();
        }
    }
}




