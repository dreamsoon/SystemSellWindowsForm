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
using System.Security.Cryptography;
using System.IO;
using Automation_1.Modula;


namespace Automation_1.Admin_forms
{
    public partial class frm_Add_Edit_Users : Form
    {
        string ImageName = "";
        string SignuctreName = "";
        public byte formtype { get; set; }
        public int UserID { get; set; }
    

        public frm_Add_Edit_Users()
        {
            InitializeComponent();
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void picbox_Picture_Click(object sender, EventArgs e)
        {
            openFileDlg.Filter = "Image File(*.jpg;*.bmp;*.png;) | *.jpg;*.bmp;*.png;";
            if (openFileDlg.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                ImageName = openFileDlg.FileName;
                picbox_Picture.Image = new Bitmap(ImageName);
            }
        }

        private void picboc_signutre_Click(object sender, EventArgs e)
        {
            openFileDlg.Filter = "Image File(*.jpg;*.bmp;) | *.jpg;*.bmp;";
            if (openFileDlg.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                SignuctreName = openFileDlg.FileName;
                picboc_signutre.Image = new Bitmap(SignuctreName);
            }
        }

        private void btn_submit_Click(object sender, EventArgs e)
        {
           
            if (this.formtype == 1) //Insert
            {
                var query_UserChek = (from u in DBCommon.Context.Users
                                      where u.UserUserName == txt_UserName.Text
                                      where u.UserActivity == 1
                                      select u).ToList();
                if (query_UserChek.Count == 1)
                {
                    MessageBox.Show("این نام کاربری قبلا در سیستم ثبت شده است", "خظا", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (!chekednotnull())
                {
                    return;

                }
                try
                {
                    string passwordbox = txt_Password.Text.Trim();
                    string password = HashString(passwordbox);
                    ///////
                    byte[] picturebyte = picturetoarry(ImageName);
                    byte[] signutrebyte = picturetoarry(SignuctreName);
                    //////////////////////////////
                    byte checkgender = chekinggender();
                    //////////////////////////////////
                    string Birthday = String.Format("{0:yyyy/MM/dd}", Convert.ToDateTime(persianDateTimePicker_Birthday.Value.Year.ToString() + "/" + persianDateTimePicker_Birthday.Value.Month.ToString() + "/" + persianDateTimePicker_Birthday.Value.Day.ToString()));
                    //////////
                    DBCommon.Context.sp_Insert_Users(txt_Name.Text.Trim(), txt_Family.Text.Trim(), txt_UserName.Text.Trim(), password, txt_PersenolaCode.Text.Trim(), checkgender, txt_Email.Text.Trim(), 1, txt_Tell.Text.Trim(), picturebyte, lbl_date.Text, signutrebyte, Birthday);
                    //////
                    MessageBox.Show("اطلاعات با موفقیت ثبت شد", "ثبت", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();

                }

                catch (Exception)
                {

                    MessageBox.Show("در ثبت اطلاعات خطایی رخ داده است ", "خظا", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else if (this.formtype == 2) //Update
            {
                if (!chekednotnull_ForUpdate())
                {
                    return;

                }
                byte[] picturebyte = null;
                if (ImageName != "")
                {
                    picturebyte = picturetoarry(ImageName);
                }
                byte checkgender = chekinggender();
                string Birthday = String.Format("{0:yyyy/MM/dd}", Convert.ToDateTime(persianDateTimePicker_Birthday.Value.Year.ToString() + "/" + persianDateTimePicker_Birthday.Value.Month.ToString() + "/" + persianDateTimePicker_Birthday.Value.Day.ToString()));
                if (ImageName != "")
                {
                    DBCommon.Context.sp_Update_Users(this.UserID, txt_Name.Text.Trim(), txt_Family.Text.Trim(), txt_PersenolaCode.Text.Trim(), checkgender, txt_Email.Text.Trim(), txt_Tell.Text.Trim(), picturebyte, Birthday);
                    DBCommon.Context.SaveChanges();
                    MessageBox.Show("اطلاعات با موفقیت به روز رسانی شد", "بروزرسانی", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                else {

                    DBCommon.Context.sp_Update_Users_NoImage(this.UserID, txt_Name.Text.Trim(), txt_Family.Text.Trim(), txt_PersenolaCode.Text.Trim(), checkgender, txt_Email.Text.Trim(), txt_Tell.Text.Trim(), Birthday);
                    DBCommon.Context.SaveChanges();
                    MessageBox.Show("اطلاعات با موفقیت به روز رسانی شد", "بروزرسانی", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
            }
        }
        private byte chekinggender()
        {
            byte checkgender = 0;
            if (rdb_men.Checked)
            {
                checkgender = 1;

            }
            if (rdb_woman.Checked)
            {
                checkgender = 2;

            }

            return checkgender;
        }

        private byte[] picturetoarry(string imgname)
        {

            FileStream fs = new FileStream(imgname, FileMode.Open, FileAccess.Read);
            byte[] imgbytearray = new byte[fs.Length];
            fs.Read(imgbytearray, 0, Convert.ToInt32(fs.Length));
            fs.Close();
            return imgbytearray;
        }

        private string HashString(string password)
        {
            SHA256CryptoServiceProvider SHA256 = new SHA256CryptoServiceProvider();
            Byte[] B1;
            Byte[] B2;
            B1 = UTF8Encoding.UTF8.GetBytes(password);
            B2 = SHA256.ComputeHash(B1);
            string hashedpassword = BitConverter.ToString(B2);
            return hashedpassword;
        }

        private void frm_Add_Edit_Users_Load(object sender, EventArgs e)
        {
            lbl_date.Text = PublicVariebale.ToDayDate;
            if (this.formtype == 2) {

                ShowInformation();
                txt_UserName.Enabled = false;
                txt_Password.Enabled = false;
                picboc_signutre.Enabled = false;

            }
        }
        private void ShowInformation()
        {


            var Query = (from U in DBCommon.Context.Users where U.UserID == this.UserID select U).ToList();
            if (Query.Count == 1)
            {

                txt_Name.Text = Query[0].UserFirstName;
                txt_Family.Text = Query[0].UserFamily;
                txt_Tell.Text = Query[0].UserTell;
                txt_UserName.Text = Query[0].UserUserName;
                txt_PersenolaCode.Text = Query[0].UserPersonalCode;
                persianDateTimePicker_Birthday.Value = Convert.ToDateTime(Query[0].UserBrithDay);
                txt_Email.Text = Query[0].UserEmail;
                txt_Password.Text = "*****";
                //
                if (Query[0].UserGender == 1)
                {

                    rdb_men.Checked = true;
                }
                else
                {
                    rdb_woman.Checked = true;
                }

                if (Query[0].UserImage != null)
                {
                    var Data_UserImage = (Byte[])(Query[0].UserImage);
                    var stream_UserImage = new MemoryStream(Data_UserImage);
                    picbox_Picture.Image = Image.FromStream(stream_UserImage);
                }
                if (Query[0].UserSignutre != null)
                {
                    var Data_UserImage = (Byte[])(Query[0].UserSignutre);
                    var stream_UserImage = new MemoryStream(Data_UserImage);
                    picboc_signutre.Image = Image.FromStream(stream_UserImage);
                }

            }
        }
        private bool chekednotnull()
        {
            if (txt_Name.Text.Trim() == "")
            {
                MessageBox.Show("لطفا نام را وارد کنید", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_Name.Focus();
                return false;

            }
            if (txt_Family.Text.Trim() == "")
            {
                MessageBox.Show("لطفا نام خانوادگی را وارد کنید", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_Family.Focus();
                return false;

            }
            if (txt_UserName.Text.Trim() == "")
            {
                MessageBox.Show("لطفا نام کاربری را وارد کنید", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_UserName.Focus();
                return false;

            }
            if (txt_Password.Text.Trim() == "")
            {
                MessageBox.Show("لطفا رمز عبور را وارد کنید", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_Password.Focus();
                return false;

            }
            if (txt_Tell.Text.Trim() == "")
            {
                MessageBox.Show("لطفا تلفن را وارد کنید", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_Tell.Focus();
                return false;

            }
            if (txt_PersenolaCode.Text.Trim() == "")
            {
                MessageBox.Show("لطفا شماره پرسنلی را وارد کنید", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_PersenolaCode.Focus();
                return false;

            }
            if (ImageName == "" && SignuctreName == "")
            {
                MessageBox.Show("عکس و امضا نمیتواند خالی باشد", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);

                return false;
            }

            return true;
        }
        private bool chekednotnull_ForUpdate()
        {
            if (txt_Name.Text.Trim() == "")
            {
                MessageBox.Show("لطفا نام را وارد کنید", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_Name.Focus();
                return false;

            }
            if (txt_Family.Text.Trim() == "")
            {
                MessageBox.Show("لطفا نام خانوادگی را وارد کنید", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_Family.Focus();
                return false;

            }
            
           
            if (txt_Tell.Text.Trim() == "")
            {
                MessageBox.Show("لطفا تلفن را وارد کنید", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_Tell.Focus();
                return false;

            }
            if (txt_PersenolaCode.Text.Trim() == "")
            {
                MessageBox.Show("لطفا شماره پرسنلی را وارد کنید", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_PersenolaCode.Focus();
                return false;

            }
         

            return true;
        }
    }
}
