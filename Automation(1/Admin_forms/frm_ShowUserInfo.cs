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

namespace Automation_1.Admin_forms
{
    public partial class frm_ShowUserInfo : Form
    {
        public int UserID { get; set; }
        public frm_ShowUserInfo()
        {
            InitializeComponent();
        }

        private void frm_ShowUserInfo_Load(object sender, EventArgs e)
        {
            ShowInformation();
        }
        private void ShowInformation()
        {


            var Query = (from U in DBCommon.Context.VW_Users where U.UserID == this.UserID select U).ToList();
            if (Query.Count == 1)
            {

                lbl_name.Text = Query[0].UserFirstName;
                lbl_fullname.Text = Query[0].UserFamily;
                lbl_number.Text = Query[0].UserTell;
                lbl_username.Text = Query[0].UserUserName;
                lbl_persenalnumber.Text = Query[0].UserPersonalCode;
                lbl_Datebirthday.Text = Query[0].UserBrithDay;
                lbl_email.Text = Query[0].UserEmail;
                lbl_gender.Text = Query[0].FarsiGender;
                lbl_activity.Text = Query[0].FarsiUserActivity;

                if (Query[0].UserImage != null)
                {
                    var Data_UserImage = (Byte[])(Query[0].UserImage);
                    var stream_UserImage = new MemoryStream(Data_UserImage);
                    pictureBox_userpicture.Image = Image.FromStream(stream_UserImage);
                }
                if (Query[0].UserSignutre != null)
                {
                    var Data_UserImage = (Byte[])(Query[0].UserSignutre);
                    var stream_UserImage = new MemoryStream(Data_UserImage);
                    pictureBox_signutre.Image = Image.FromStream(stream_UserImage);
                }

            }
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
