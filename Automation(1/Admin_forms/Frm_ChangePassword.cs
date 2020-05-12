using Automation_1.Modula;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Automation_1.Admin_forms
{
    public partial class Frm_ChangePassword : Form
    {
        public int UserID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public Frm_ChangePassword()
        {
            InitializeComponent();
        }

        private void Frm_ChangePassword_Load(object sender, EventArgs e)
        {
            lbl_info.Text = "تغیر رمز عبور کاربر : " + FirstName + " " + LastName;
        }

        private void btn_createjob_Click(object sender, EventArgs e)
        {

            SHA256CryptoServiceProvider shaoldpass = new SHA256CryptoServiceProvider();
            Byte[] b1_new;
            Byte[] b2_new;
            Byte[] b1_rnew;
            Byte[] b2_rnew;
            b1_new = UTF8Encoding.UTF8.GetBytes(txt_new.Text.Trim());
            b2_new = shaoldpass.ComputeHash(b1_new);
            string UserPaswordHashednew = BitConverter.ToString(b2_new);  
            b1_new = UTF8Encoding.UTF8.GetBytes(txt_replaynew.Text.Trim());
            b2_new = shaoldpass.ComputeHash(b1_new);
            string UserPaswordHashedrnew = BitConverter.ToString(b2_new);
            if (UserPaswordHashednew == UserPaswordHashedrnew) {
                var query = (from u in DBCommon.Context.Users where u.UserID == this.UserID select u).SingleOrDefault();
                   query.UserPassword = UserPaswordHashednew;
                    DBCommon.Context.SaveChanges();

                MessageBox.Show("رمز عبور به روز رسانی شد", "موفقیت", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            else
            {
                MessageBox.Show("رمز عبور را با دقت وارد کنید", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;

            }




        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

