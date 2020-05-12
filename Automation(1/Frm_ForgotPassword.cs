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

namespace Automation_1
{
    public partial class Frm_ForgotPassword : Form
    {
        public Frm_ForgotPassword()
        {
            InitializeComponent();
        }

     

   

        private void button3_Click(object sender, EventArgs e)
        {
            var query = (from u in DBCommon.Context.Users where u.UserUserName==textBox1.Text.Trim() select u).ToList();
            if (query.Count == 0)
            {
                MessageBox.Show("کاربری یافت نشد", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
                string number = query[0].UserTell;
                string firstname = query[0].UserFirstName;
                string family = query[0].UserFamily;
                int guserid = query[0].UserID;
            
           
            smsService.SendReceive sms = new smsService.SendReceive();
            string message = "";
            smsService.SMSLineNumber[] smsline = sms.GetSMSLines("9353637894", "8D15C837", ref message);
            dataGridView1.DataSource = smsline;
           
            try
            {
                int smsLineID = 0;
                List<smsService.WebServiceSmsSend> sendDetails = new List<smsService.WebServiceSmsSend>();

                {
                    string messageBody = string.Empty;
                    long mobileNo = 0;
                    bool isFlash = false;
                    Random rand1 = new Random();
                    string newpassword = rand1.Next(9999).ToString();
                    SHA256CryptoServiceProvider newpass = new SHA256CryptoServiceProvider();
                    Byte[] b1_newpass;
                    Byte[] b2_newpass;
                    b1_newpass = UTF8Encoding.UTF8.GetBytes(newpassword);
                    b2_newpass = newpass.ComputeHash(b1_newpass);
                    string UserPaswordHashednew = BitConverter.ToString(b2_newpass);
                    var changepassword = (from u in DBCommon.Context.Users where u.UserID == guserid select u).SingleOrDefault();
                    changepassword.UserPassword = UserPaswordHashednew;
                    DBCommon.Context.SaveChanges();
                    //////////��� �?�� � ����� ���� �?����
                    messageBody = "سلام " + firstname + " " + family + " رمز عبور جدید شما : " + newpassword +"  است";
                    mobileNo = Convert.ToInt64(number);
                    isFlash = false;

                    sendDetails.Add(new smsService.WebServiceSmsSend()
                    {
                        IsFlash = isFlash,
                        MessageBody = messageBody,
                        MobileNo = mobileNo
                    });
                }

                smsService.SendReceive ws = new smsService.SendReceive();


                ////////�� ���� �? �? ��
                if (!int.TryParse(dataGridView1.CurrentRow.Cells[0].Value.ToString(), out smsLineID)) throw new Exception("آی دی اشتباه است");


                string messagee = string.Empty;


                ////////����� ������� �� �� ���?�
                long[] result = ws.SendMessage("9353637894", "8D15C837", sendDetails.ToArray(), smsLineID, null, ref messagee);
                if (!string.IsNullOrWhiteSpace(message))
                    throw new Exception(message);

                StringBuilder sbResult = new StringBuilder();
                foreach (long current in result)
                    sbResult.Append(current + ",");
                MessageBox.Show("کاربر گرامی رمز عبور شما با موفقیت تغیر کرد و از طریق پیام کوتاه برای شما ارسال گردید", "موفقیت", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
    }
}
