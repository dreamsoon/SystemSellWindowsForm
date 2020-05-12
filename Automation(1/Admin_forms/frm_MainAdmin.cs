using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Automation_1.Modula;
using DataModelLayer.Model;

namespace Automation_1.Admin_forms
{
    public partial class frm_MainAdmin : Form
    {
        public frm_MainAdmin()
        {
            InitializeComponent();
        }

      private void RemembersInfo( string searchstring)
        {
            var query = DBCommon.Context.Database.SqlQuery<VW_Remembers>("select * From VW_Remembers where 1=1 and"+searchstring);
            var result = query.ToList();

            if (result.Count != 0)
            {
                dgv_Remembers.RowCount = result.Count;
                for (int i = 0; i <= result.Count - 1; i++)
                {
              
                    dgv_Remembers.Rows[i].Cells["a"].Value = result[i].RememberID;
                    dgv_Remembers.Rows[i].Cells["b"].Value = result[i].Subject;
                    dgv_Remembers.Rows[i].Cells["d"].Value = result[i].CreateDate;
                    dgv_Remembers.Rows[i].Cells["c"].Value = result[i].Text;
                    dgv_Remembers.Rows[i].Cells["e"].Value = result[i].RememberDate;
                    dgv_Remembers.Rows[i].Cells["f"].Value = result[i].FarsiIsRead;
                    dgv_Remembers.Rows[i].Cells["g"].Value = result[i].UserID;
                    dgv_Remembers.Rows[i].Cells["h"].Value = result[i].IsRead;

                    if (Convert.ToInt16(dgv_Remembers.Rows[i].Cells["h"].Value) == 1)
                    {
                        dgv_Remembers.Rows[i].DefaultCellStyle.BackColor = Color.LightGreen;
                    }
                    else {
                        dgv_Remembers.Rows[i].DefaultCellStyle.BackColor = Color.LightPink;
                    }
                }
                dgv_Remembers.ScrollBars = ScrollBars.Both;

            }
            else
            {

                dgv_Remembers.Rows.Clear();
            }
        }

        private void btn_ManengmentUsers_Click(object sender, EventArgs e)
        {
            frm_ShowUserscs fm = new frm_ShowUserscs();
            fm.ShowDialog();
        }

        private void frm_MainAdmin_Load(object sender, EventArgs e)
        {
            persianDateTimePickerta.Value = DateTime.Now.AddDays(1);
            RemembersInfo(Searchstring());
            
        }
        private string Searchstring() {
            string dateaz = String.Format("{0:yyyy/MM/dd }",Convert.ToDateTime(persianDateTimePickeraz.Value.Year + "/" + persianDateTimePickeraz.Value.Month + "/" + persianDateTimePickeraz.Value.Day));
            string dateta= String.Format("{0:yyyy/MM/dd }", Convert.ToDateTime(persianDateTimePickerta.Value.Year + "/" + persianDateTimePickerta.Value.Month + "/" + persianDateTimePickerta.Value.Day));
            string search = " RememberDate between '" + dateaz + "'" + "and '" + dateta + "'";
            if (txtsubject.Text != "") {
                search += "and Subject like'%" + txtsubject.Text + "%'";
            }
            return search;
        }

        private void searchpicture_Click(object sender, EventArgs e)
        {
            RemembersInfo(Searchstring());
          
        }

        private void dgv_Remembers_DoubleClick(object sender, EventArgs e)
        {
            MessageBox.Show(dgv_Remembers.CurrentRow.Cells["c"].Value.ToString(), dgv_Remembers.CurrentRow.Cells["b"].Value.ToString(), MessageBoxButtons.OK, MessageBoxIcon.Information);
            int RememberID = Convert.ToInt32(dgv_Remembers.CurrentRow.Cells["a"].Value);
            var UpdateQuery = (from R in DBCommon.Context.Remembers where R.RememberID == RememberID select R).SingleOrDefault();
            UpdateQuery.IsRead = 2;
            DBCommon.Context.SaveChanges();
            RemembersInfo(Searchstring());
        }

        private void btn_Add_Rememebr_Click(object sender, EventArgs e)
        {
            Add_Remember fm = new Add_Remember();
            fm.ShowDialog();
            RemembersInfo(Searchstring());
        }

        private void frm_MainAdmin_FormClosing(object sender, FormClosingEventArgs e)
        {
            DBCommon.Context.SP_Update_ExitDateTime(PublicVariebale.gUserID, PublicVariebale.ToDayDate + "-" + string.Format("{0:HH:mm:ss}", Convert.ToDateTime(DateTime.Now.Hour + ":" + DateTime.Now.Minute + ":" + DateTime.Now.Second)));
            DBCommon.Context.SaveChanges();
        }

        private void btn_ContoroEnterAndExitUsers_Click(object sender, EventArgs e)
        {
            frm_UserLog fm = new frm_UserLog();
            fm.ShowDialog();
        }

        private void btn_Jobs_Click(object sender, EventArgs e)
        {
            frm_Jobs fm = new frm_Jobs();
            fm.ShowDialog();
        }

        private void btn__SetJob_Click(object sender, EventArgs e)
        {
            frm_selectedjobs fm = new frm_selectedjobs();
            fm.ShowDialog();
        }

        private void btn_remembres_Click(object sender, EventArgs e)
        {
            Frm_CrateNews fm = new Frm_CrateNews();
            fm.ShowDialog();
        }

        private void buttonItem2_Click(object sender, EventArgs e)
        {
            Frm_AccessRight fm = new Frm_AccessRight();
            fm.ShowDialog();
        }
    }
}
