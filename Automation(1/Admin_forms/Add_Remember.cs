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

namespace Automation_1.Admin_forms
{
    public partial class Add_Remember : Form
    {
        public Add_Remember()
        {
            InitializeComponent();
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_submit_Click(object sender, EventArgs e)
        {
            ///Insert
            ///
            Remembers r = new Remembers();
            r.Subject = txtSubject.Text.Trim();
            r.Text = txtxtext.Text.Trim();
            r.CreateDate = lbltime.Text;
            r.RememberDate =String.Format("{0:yyyy/MM/dd}",Convert.ToDateTime(timepickerremember.Value.Year + "/" + timepickerremember.Value.Month + "/" + timepickerremember.Value.Day));
            r.IsRead = 1;
            r.UserID = 1;
            DBCommon.Context.Remembers.Add(r);
            DBCommon.Context.SaveChanges();
            MessageBox.Show("اطلاعات با موفقیت ثبت شد", "ثبت", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();

        }

        private void Add_Remember_Load(object sender, EventArgs e)
        {
            lbltime.Text = PublicVariebale.ToDayDate;
        }
    }
}
