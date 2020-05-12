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
    public partial class Frm_ShowNewsForAllUser : Form
    {
        public Frm_ShowNewsForAllUser()
        {
            InitializeComponent();
        }
        private void ShowNews(string searchstring)
        {
            var query = DBCommon.Context.Database.SqlQuery<VW_News>("select * From VW_News where 1=1" + searchstring);
            var result = query.ToList();
            dgv_news.Rows.Clear();
            if (result.Count != 0)
            {
                dgv_news.RowCount = result.Count;
                for (int i = 0; i <= result.Count - 1; i++)
                {
                    dgv_news.Rows[i].Cells["NewsID"].Value = result[i].NewsID;
                    dgv_news.Rows[i].Cells["Subject"].Value = result[i].Subject;
                    dgv_news.Rows[i].Cells["MainText"].Value = result[i].MainText;
                    dgv_news.Rows[i].Cells["CreateDate"].Value = result[i].CreateDate;
                    dgv_news.Rows[i].Cells["FullName"].Value = result[i].FullName;
                    dgv_news.Rows[i].Cells["Attachment"].Value = result[i].FileName;



                }

                dgv_news.TopLeftHeaderCell.Value = "ردیف";
                for (int i = 0; i <= dgv_news.Rows.Count - 1; i++)
                {
                    dgv_news.Rows[i].HeaderCell.Value = (i + 1).ToString();
                }
                dgv_news.ScrollBars = ScrollBars.Both;


            }
            else
            {

                dgv_news.Rows.Clear();
            }
        }

        private void Frm_ShowNews_Load(object sender, EventArgs e)
        {
            this.Top = 135;
            this.Left = 1;
            ShowNews(Searchstring());
            timepicker_az.Value = DateTime.Now.AddDays(-1);
        }

      
        private void saveatachment(SaveFileDialog objsdf, DataGridView objgrid, int getLetterID)
        {
            string strid = objgrid.CurrentRow.Cells["Attachment"].Value.ToString();
            if (strid != "")
            {

                var query_atachment = (from af in DBCommon.Context.News where af.NewsID == getLetterID select af).ToList();
                byte[] objdata;
                objdata = (byte[])query_atachment[0].Atachment;
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
            string search = " and CreateDate between '" + dateaz + "'" + " and '" + dateta + "'";

            if (txtSubject.Text != "")
            {
                search += "and [Subject] like'%" + txtSubject.Text + "%'";
            }


            return search;
        }

        private void picboc_search_Click(object sender, EventArgs e)
        {
            ShowNews(Searchstring());
        }

        

        private void dgv_news_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (dgv_news.CurrentCell.ColumnIndex.Equals(5) && e.RowIndex != -1)
            {

                if (dgv_news.CurrentCell != null && dgv_news.CurrentCell.Value != null)
                {

                    int GetLetterID = Convert.ToInt32(dgv_news.CurrentRow.Cells["NewsID"].Value);
                    saveatachment(saveFileDialog1, dgv_news, GetLetterID);
                }
            }
        }

        private void dgv_news_DoubleClick(object sender, EventArgs e)
        {
            Frm_TextNews fm = new Frm_TextNews();
            fm.lbl_text.Text = dgv_news.CurrentRow.Cells["MainText"].Value.ToString();
            fm.lbl_subject.Text = dgv_news.CurrentRow.Cells["Subject"].Value.ToString();
            fm.TopMost = true;
            fm.ShowDialog();
        }
    }
}
