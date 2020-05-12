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
using Automation_1.Modula;
namespace Automation_1.User_forms
{
    public partial class Frm_ChangePassword : Form
    {
        public Frm_ChangePassword()
        {
            InitializeComponent();
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_createjob_Click(object sender, EventArgs e)
        {
            SHA256CryptoServiceProvider shaoldpass = new SHA256CryptoServiceProvider();
            Byte[] b1_oldpass;
            Byte[] b2_oldpass;
            b1_oldpass = UTF8Encoding.UTF8.GetBytes(txt_old.Text.Trim());
            b2_oldpass = shaoldpass.ComputeHash(b1_oldpass);
            string UserPaswordHashedold = BitConverter.ToString(b2_oldpass);
            var query = from User in DBCommon.Context.Users
                        where User.UserID == PublicVariebale.gUserID
                        where User.UserPassword == UserPaswordHashedold
                        select User;
            var result = query.ToList();
            if (result.Count == 0)
            {
                MessageBox.Show("رمز قدیمی اشتباه وارد شده است","خطا",MessageBoxButtons.OK,MessageBoxIcon.Error);
                return;
            }
            else if (result.Count == 1)
            {

                SHA256CryptoServiceProvider shnewpass = new SHA256CryptoServiceProvider();
                Byte[] b1_newpass;
                Byte[] b2_newpass;
                Byte[] b1_rnewpass;
                Byte[] b2_rnewpass;
                b1_newpass = UTF8Encoding.UTF8.GetBytes(txt_new.Text.Trim());
                b2_newpass = shaoldpass.ComputeHash(b1_newpass);
                b1_rnewpass = UTF8Encoding.UTF8.GetBytes(txt_replaynew.Text.Trim());
                b2_rnewpass = shaoldpass.ComputeHash(b1_rnewpass);
                string usernewpassword = BitConverter.ToString(b2_newpass);
                string rusernewpassword = BitConverter.ToString(b2_rnewpass);
                var updatepasswordquery = (from u in DBCommon.Context.Users where u.UserID == PublicVariebale.gUserID select u).SingleOrDefault();
                updatepasswordquery.UserPassword = usernewpassword;
                if (usernewpassword == rusernewpassword)
                {
                    DBCommon.Context.SaveChanges();
                    MessageBox.Show("رمز عبور به روز رسانی شد", "موفقیت", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    System.Environment.Exit(0);
                }
                else {
                    MessageBox.Show("رمز عبور را با دقت وارد کنید", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;

                }
            }
        }
    }
}
