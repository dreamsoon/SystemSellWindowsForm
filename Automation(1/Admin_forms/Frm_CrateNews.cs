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
using Automation_1.Modula;
using DataModelLayer.Model;

namespace Automation_1.Admin_forms
{
    public partial class Frm_CrateNews : Form
    {
        public Frm_CrateNews()
        {
            InitializeComponent();
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Frm_CrateNews_Load(object sender, EventArgs e)
        {
            lbl_Date.Text = PublicVariebale.ToDayDate;
            lbl_UserName.Text = PublicVariebale.gUserFirstName + " " + PublicVariebale.gUserFamily;
        }
        private void btn_atachment_Click(object sender, EventArgs e)
        {
            var file = "";
            openFiledlg_Atachment.Filter = "All Files (*.*) | *.*";
            openFiledlg_Atachment.Multiselect = false;
            if (openFiledlg_Atachment.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                var lst = new string[] { ".jpg", ".bmp", ".png", ".rar", ".zip", ".pdf", ".doc", ".docx", ".xls", ".xlsx" };
                file = openFiledlg_Atachment.FileName;
                if (!lst.Contains(Path.GetExtension(file)))
                {
                    MessageBox.Show("فرمت فایل صحیح نمیباشد", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                lbl_Atachment.Text = file;
            }
            else
            {
                return;
            }
        }

        private void btn_createjob_Click(object sender, EventArgs e)
        {
            if (txt_Subject.Text == "" && txt_text.Text == "")
            {

                MessageBox.Show("لطفا متن نامه یا موضوع نامه را وارد بفرمایید", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            News n = new News();
            n.Subject = txt_Subject.Text.Trim();
            n.MainText = txt_text.Text.Trim();
            n.UserID = PublicVariebale.gUserID;
            n.CreateDate = lbl_Date.Text;

            if (lbl_Atachment.Text != "")
            {

                FileStream objFileStream = new FileStream(lbl_Atachment.Text, FileMode.Open, FileAccess.Read);
                int intlenght = Convert.ToInt32(objFileStream.Length);
                byte[] objdata;
                objdata = new byte[intlenght];
                string[] strpatch = lbl_Atachment.Text.Split(Convert.ToChar(@"\"));
                objFileStream.Read(objdata, 0, intlenght);
                objFileStream.Close();
                ///
                n.Atachment = objdata;
                n.FileSize = intlenght / 1024;//KB
                n.FileName = strpatch[strpatch.Length - 1];

            }

            DBCommon.Context.News.Add(n);
            DBCommon.Context.SaveChanges();
            MessageBox.Show("خبر با موفقیت ایجاد شد", "ایجاد خبر", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }

        private void btn_ShowNews_Click(object sender, EventArgs e)
        {
            Frm_ShowNews fm = new Frm_ShowNews();
            fm.ShowDialog();
        }
    }
}
