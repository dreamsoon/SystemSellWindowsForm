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
    public partial class Frm_SendLetter : Form
    {
        public Frm_SendLetter()
        {
            InitializeComponent();
        }

        private void Frm_SendLetter_Load(object sender, EventArgs e)
        {
            this.Top = 135;
            this.Left = 1;
            ShowSendLetter(Searchstring());
            timepicker_az.Value = DateTime.Now.AddDays(-10);
        }

        private void ShowSendLetter(string Searchstring)
        {
            var query = DBCommon.Context.Database.SqlQuery<VW_ReciveLetter>("select * From VW_ReciveLetter where DraftyType=2 and UserID = " + PublicVariebale.gUserID + Searchstring);
            var result = query.ToList();
            dgv_Sendetter.Rows.Clear();
            if (result.Count != 0)
            {
                dgv_Sendetter.RowCount = result.Count;
                for (int i = 0; i <= result.Count - 1; i++)
                {
                    dgv_Sendetter.Rows[i].Cells["Letter_ID"].Value = result[i].LetterID;
                   dgv_Sendetter.Rows[i].Cells["LetterNumber"].Value = result[i].LetterNum;                 
                    dgv_Sendetter.Rows[i].Cells["ReciverUser"].Value = result[i].GirandeName;                
                    dgv_Sendetter.Rows[i].Cells["Subject"].Value = result[i].Subject;
                    dgv_Sendetter.Rows[i].Cells["tabaghebandi"].Value = result[i].FarsiSecuretyType;
                    dgv_Sendetter.Rows[i].Cells["bayganistatus"].Value = result[i].FarsiBayganiType;
                    dgv_Sendetter.Rows[i].Cells["foriat"].Value = result[i].FarsiForceType;
                    dgv_Sendetter.Rows[i].Cells["sanadtype"].Value = result[i].FarsiLetterType;
                   
                    dgv_Sendetter.Rows[i].Cells["mohlat"].Value = result[i].Answerdeadline;                  
                    dgv_Sendetter.Rows[i].Cells["Atachment"].Value = result[i].FarsiAttachmentType;
                    dgv_Sendetter.Rows[i].Cells["Atachmentt"].Value = result[i].AttachmentType;
                    dgv_Sendetter.Rows[i].Cells["ReciveLetterDate"].Value = result[i].SendLetterDate;
                    //dgv_ReciveLetter.Rows[i].Cells["User_Girande"].Value = result[i].User_Girande;
                    if (Convert.ToInt16(dgv_Sendetter.Rows[i].Cells["Atachmentt"].Value) == 1)
                    {

                        dgv_Sendetter.Rows[i].Cells["DownloadAtachment"].Value = result[i].FileName;
                    }

                }

                dgv_Sendetter.TopLeftHeaderCell.Value = "ردیف";
                for (int i = 0; i <= dgv_Sendetter.Rows.Count - 1; i++)
                {
                    dgv_Sendetter.Rows[i].HeaderCell.Value = (i + 1).ToString();
                }
                dgv_Sendetter.ScrollBars = ScrollBars.Both;


            }
            else
            {

                dgv_Sendetter.Rows.Clear();
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

        private void panelEx1_Click(object sender, EventArgs e)
        {

        }
    }
}
