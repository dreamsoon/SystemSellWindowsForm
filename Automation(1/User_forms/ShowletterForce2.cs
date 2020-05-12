using Automation_1.Modula;
using DataModelLayer.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Automation_1.User_forms
{
    public partial class ShowletterForce2 : Form
    {
        public ShowletterForce2()
        {
            InitializeComponent();
        }
        private void Frm_ReciveLetter_Load(object sender, EventArgs e)
        {
            this.Top = 135;
            this.Left = 1;
            timepicker_az.Value = DateTime.Now.AddDays(-10);


            ShowReciveLetter(Searchstring());
        }
        private void ShowReciveLetter(string Searchstring)
        {
            var query = DBCommon.Context.Database.SqlQuery<VW_ReciveLetter>("select * From VW_ReciveLetter where DraftyType=2 and ForceType=2 and User_Girande = " + PublicVariebale.gUserID + Searchstring);
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
                    dgv_ReciveLetter.Rows[i].Cells["Subject"].Value = result[i].Subject;
                    dgv_ReciveLetter.Rows[i].Cells["tabaghebandi"].Value = result[i].FarsiSecuretyType;
                    dgv_ReciveLetter.Rows[i].Cells["bayganistatus"].Value = result[i].FarsiBayganiType;
                    dgv_ReciveLetter.Rows[i].Cells["sanadtype"].Value = result[i].FarsiLetterType;
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

        
        private void dgv_ReciveLetter_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            if (dgv_ReciveLetter.CurrentCell.ColumnIndex.Equals(12) && e.RowIndex != -1)
            {

                if (dgv_ReciveLetter.CurrentCell != null && dgv_ReciveLetter.CurrentCell.Value != null)
                {

                    int GetLetterID = Convert.ToInt32(dgv_ReciveLetter.CurrentRow.Cells["Letter_ID"].Value);
                    saveatachment(saveFileDialog1, dgv_ReciveLetter, GetLetterID);
                }
            }
        }
    }
}

