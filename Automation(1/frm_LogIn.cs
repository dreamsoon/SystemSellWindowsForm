using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Net;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Automation_1.Admin_forms;
using Automation_1.Modula;
using DataModelLayer.Model;


namespace Automation_1
{
    public partial class frm_LogIn : Form
    {
        public frm_LogIn()
        {
            InitializeComponent();
        }

        private void btn_Exit_Click(object sender, EventArgs e)
        {
           
            System.Environment.Exit(0);
        }

        private void frm_LogIn_Load(object sender, EventArgs e)
        {
            //ShowDate
            PersianCalendar pc = new PersianCalendar();
            lbl_Date.Text = string.Format("{0:yyyy/MM/dd}",Convert.ToDateTime((pc.GetYear(DateTime.Now) + "/" + pc.GetMonth(DateTime.Now) + "/" + pc.GetDayOfMonth(DateTime.Now))));
            PublicVariebale.ToDayDate = lbl_Date.Text;

            //ShowIP
            string ComputerName = System.Environment.MachineName;
            string IP = "";
            IPHostEntry ipe = Dns.GetHostByName(ComputerName);
            IPAddress[] Ipaddres = ipe.AddressList;
            lbl_IP.Text = Ipaddres[0].ToString();

            ///ShowTime
            timer1_Tick(sender,e);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            timer1.Interval = 1000;
            lbl_Time.Text = DateTime.Now.Hour + ":" + DateTime.Now.Minute + ":" + DateTime.Now.Second;
            lbl_Time.Refresh();
        }

        private void btn_LogIn_Click(object sender, EventArgs e)
        {
            try
            {
                string password = HashString(txt_Password.Text.Trim());
                var Login_Query = (from u in DBCommon.Context.Users
                                   where u.UserUserName == txt_UserName.Text.Trim()
                                   where u.UserPassword == password
                                   where u.UserActivity == 1
                                   select u).ToList();
                if (Login_Query.Count == 1)
                {
                    /////////////
                    PublicVariebale.gUserFirstName = Login_Query[0].UserFirstName;
                    PublicVariebale.gUserFamily = Login_Query[0].UserFamily;
                    PublicVariebale.gUserID = Login_Query[0].UserID;
                    /////////UserLOg
                    string ComputerName = System.Environment.MachineName;
                    UserLog u = new UserLog();
                    u.ComputerName = ComputerName;
                    u.IPAddres = lbl_IP.Text;
                    u.EnterDateTime = lbl_Date.Text + "-" + string.Format("{0:HH:mm:ss}", Convert.ToDateTime(DateTime.Now.Hour + ":" + DateTime.Now.Minute + ":" + DateTime.Now.Second));
                    u.UserID=PublicVariebale.gUserID;
                    DBCommon.Context.UserLog.Add(u);
                    DBCommon.Context.SaveChanges();

                    if (rdb_Admin.Checked)
                    {
                        if (Login_Query[0].UserUserName == "admin")
                        {

                            PublicVariebale.gSetUser = 1;
                        }
                        else
                        {

                            MessageBox.Show("کاربری با این مشخصات یافت نشد", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                    }
                    this.Close();
                }
               
            
                else
                {
                    MessageBox.Show("کاربری با این مشخصات یافت نشد","خطا",MessageBoxButtons.OK,MessageBoxIcon.Error);
                }
                
            }
            
            catch (Exception)
            {

                MessageBox.Show("conecting to server is failed");
            }
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

        private void lbl_forgotpassword_Click(object sender, EventArgs e)
        {
            Frm_ForgotPassword fm = new Frm_ForgotPassword();
            fm.ShowDialog();
        }
    }
}
