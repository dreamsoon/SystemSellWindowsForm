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
using Automation_1.Modula;
namespace Automation_1.User_forms
{
    public partial class Frm_AddRememeber : Form
    {
        public Frm_AddRememeber()
        {
            InitializeComponent();
        }

        private void btn_submit_Click(object sender, EventArgs e)
        {
            Remembers r = new Remembers();
            r.Subject = txtSubject.Text.Trim();
            r.Text = txtxtext.Text.Trim();
            r.CreateDate = lbltime.Text;
            r.RememberDate = String.Format("{0:yyyy/MM/dd}", Convert.ToDateTime(timepickerremember.Value.Year + "/" + timepickerremember.Value.Month + "/" + timepickerremember.Value.Day));
            r.IsRead = 1;
            r.UserID = PublicVariebale.gUserID;
            DBCommon.Context.Remembers.Add(r);
            DBCommon.Context.SaveChanges();
            MessageBox.Show("اطلاعات با موفقیت ثبت شد", "ثبت", MessageBoxButtons.OK, MessageBoxIcon.Information);
          
        }

        private void Frm_AddRememeber_Load(object sender, EventArgs e)
        {
            lbltime.Text = PublicVariebale.ToDayDate;
            this.Top = 135;
            this.Left = 1;
        }
    }
}
