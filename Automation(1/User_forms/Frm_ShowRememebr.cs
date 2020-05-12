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

namespace Automation_1.User_forms
{
    public partial class Frm_ShowRememebr : Form
    {
        public Frm_ShowRememebr()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Frm_ShowRememebr_Load(object sender, EventArgs e)
        {
            this.Top = 135;
            this.Left =1;
            dateTimePickerta.Value = DateTime.Now.AddDays(1);
            ShowRemember(SearchRemember());
        }


         private void ShowRemember(string SearchStatmnet)
        {
            var query = DBCommon.Context.Database.SqlQuery<VW_Remembers>("select * From VW_Remembers where 1=1 and UserID=" + PublicVariebale.gUserID+"and"+ SearchStatmnet);
            var result = query.ToList();
            if (result.Count != 0)
            {
                DGV_Remember.RowCount = result.Count;
                for (int i = 0; i <= result.Count - 1; i++)
                {
                    DGV_Remember.Rows[i].Cells["RememeberID"].Value = result[i].RememberID;
                    DGV_Remember.Rows[i].Cells["Subject"].Value = result[i].Subject;
                    DGV_Remember.Rows[i].Cells["Dateinsert"].Value = result[i].CreateDate;
                    DGV_Remember.Rows[i].Cells["MainText"].Value = result[i].Text;
                    DGV_Remember.Rows[i].Cells["DateRemeber"].Value = result[i].RememberDate;
                    DGV_Remember.Rows[i].Cells["Status"].Value = result[i].FarsiIsRead;
                    DGV_Remember.Rows[i].Cells["UserID"].Value = result[i].UserID;
                    DGV_Remember.Rows[i].Cells["IsRead"].Value = result[i].IsRead;

                    if (Convert.ToInt16(DGV_Remember.Rows[i].Cells["IsRead"].Value) == 1)
                    {
                        DGV_Remember.Rows[i].DefaultCellStyle.BackColor = Color.LightGreen;
                    }
                    else
                    {
                        DGV_Remember.Rows[i].DefaultCellStyle.BackColor = Color.LightPink;
                    }
                }
                DGV_Remember.ScrollBars = ScrollBars.Both;
               

            }
            else
            {

                DGV_Remember.Rows.Clear();
            }
        }
        private string SearchRemember()
        {

            string dateaz = String.Format("{0:yyyy/MM/dd }", Convert.ToDateTime(dateTimePickeraz.Value.Year + "/" + dateTimePickeraz.Value.Month + "/" + dateTimePickeraz.Value.Day));
            string dateta = String.Format("{0:yyyy/MM/dd }", Convert.ToDateTime(dateTimePickerta.Value.Year + "/" + dateTimePickerta.Value.Month + "/" + dateTimePickerta.Value.Day));
            string search = " RememberDate between '" + dateaz + "'" + "and '" + dateta + "'";
            if (txtSubject.Text != "")
            {
                search += "and Subject like'%" + txtSubject.Text + "%'";
            }
            return search;

        }

        private void DGV_Remember_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            MessageBox.Show(DGV_Remember.CurrentRow.Cells["MainText"].Value.ToString(), DGV_Remember.CurrentRow.Cells["Subject"].Value.ToString(), MessageBoxButtons.OK, MessageBoxIcon.Information);
            int RememberID = Convert.ToInt32(DGV_Remember.CurrentRow.Cells["RememeberID"].Value);
            var UpdateQuery = (from R in DBCommon.Context.Remembers where R.RememberID == RememberID select R).SingleOrDefault();
            UpdateQuery.IsRead = 2;
            DBCommon.Context.SaveChanges();
            ShowRemember(SearchRemember());
        }
    }
}
