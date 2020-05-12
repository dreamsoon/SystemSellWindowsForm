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
using System.IO;

namespace Automation_1.User_forms
{
    public partial class lbl_newsandinformation : Form
    {
        Frm_ShowRememebr fm_sr;
        Frm_AddRememeber fm_ar;
        Frm_ShowDrafts fm_sd;
        Frm_CreateLetter fm_cl;
        Frm_ReciveLetter fm_rl;
        Frm_SendLetter fm_sl;
        Frm_CrateNote fm_cn;
        Frm_ShowSendNote fm_ss;
        Frm_ReciveNote fm_rn;
        Frm_UnReadLetter fm_un;
        Frm_ReadLetter fm_rel;
        ShowletterForce2 fm_sf2;
        Frm_Security2 fm_st;
        Frm_ShowNewsForAllUser fm_sa;
        SendRefrenceLetter fm_srl;
        Frm_ReciveRefrenceLEtter fm_rr;
        byte FormNumber = 7;
        public lbl_newsandinformation()
        {
            InitializeComponent();
        }

        private void labelX11_Click(object sender, EventArgs e)
        {
            System.Environment.Exit(0);
        }

        private void frm_MainUser_Load(object sender, EventArgs e)
        {
          
           
            ChekStatusLetter();
            ShowUserInfo();
            // ShowRememebr();

        }

        private void ChekStatusLetter()
        {
            var query = (from l in DBCommon.Context.SendLetter where l.UserID == PublicVariebale.gUserID where l.Status == 1 select l).ToList();
            int statuscount = query.Count;
            if (statuscount > 0)
            {
                Frm_LetterCount fm = new Frm_LetterCount();
                fm.TopMost = true;
                fm.glettercount = statuscount;
                fm.ShowDialog();
                
               
            }
            DBCommon.Context.setstatus(PublicVariebale.gUserID);

        }

       

        public void ShowRememebr()
        {
            FormNumber = 7;
            Frm_ShowRememebr fm = new Frm_ShowRememebr();
            fm.Show();
            fm.TopMost = true;
         //   fm.MdiParent = this;

        }
        public void ShowUserInfo()
        {

            var query = DBCommon.Context.SP_ShowUserAllInfo1(PublicVariebale.gUserID).ToList();
            if (query.Count == 1)
            {

                lbl_name.Text = query[0].UserFirstName;
                lbl_family.Text = query[0].UserFamily;
                lbl_persenolacode.Text = query[0].UserPersonalCode;
                lbl_birthdaydate.Text = query[0].UserBrithDay;
                //lbl_gender.Text = query[0].FarsiGender;
                lbl_entertime.Text = DateTime.Now.Hour + ":" + DateTime.Now.Minute + ":" + DateTime.Now.Second;
                lbl_enterdate.Text = PublicVariebale.ToDayDate;
                lbl_job.Text = query[0].JobsName;
                PublicVariebale.JobsDetermineLevel = query[0].JobsDetermineLevel;
                if (query[0].UserGender == 1)
                {

                    lbl_gender.Text = "مرد";

                }
                else
                {
                    lbl_gender.Text = "زن";
                }
                lbl_recivemail.Text = "5";
                lbl_sendmail.Text = "4";
                ////////////
                if (query[0].UserImage != null)
                {
                    var Data_UserImage = (Byte[])(query[0].UserImage);
                    var stream_UserImage = new MemoryStream(Data_UserImage);
                    pictureBox1.Image = Image.FromStream(stream_UserImage);
                }
            }

        }
        private void lbll_ShowRememebr_Click(object sender, EventArgs e)
        {
            formclosing();
            FormNumber = 7;
            fm_sr = new Frm_ShowRememebr();
            fm_sr.Show();
           // fm_sr.MdiParent = this;
            fm_sr.TopMost = true;
        }


        private void lbl_createremmeber_Click(object sender, EventArgs e)
        {
            var query = (from u in DBCommon.Context.UserAccess where u.UserID == PublicVariebale.gUserID where u.SystemPartID == 23 select u);
            var result = query.ToList();
            if (result.Count > 0)
            {
                formclosing();
                FormNumber = 14;
                fm_ar = new Frm_AddRememeber();
                fm_ar.Show();
                //  fm_ar.MdiParent = this;
                fm_ar.TopMost = true;
            }
            else
            {
                lbl_createremmeber.Text = "شما به این بخش دسترسی ندارید"; 

            }

        }
        private void formclosing()
        {
            if (FormNumber == 7)
            {
                fm_sr = new Frm_ShowRememebr();
                fm_sr.Close();
            }
            if (FormNumber == 14)
            {
                fm_ar = new Frm_AddRememeber();
                fm_ar.Close();
            }
            if (FormNumber == 15)
            {
                fm_sd = new Frm_ShowDrafts();
                fm_sd.Close();
            }
            if (FormNumber == 12)
            {
                //fm_cl = new Frm_CreateLetter();
                //fm_cl.Close();
            }
            if (FormNumber == 1)
            {
               fm_rl = new Frm_ReciveLetter();
                fm_rl.Close();
            }
            if (FormNumber == 8)
            {
                fm_sl = new Frm_SendLetter();
                fm_sl.Close();
            }
            if (FormNumber == 13) {
                fm_cn = new Frm_CrateNote();
                fm_cn.Close();
            }
            if (FormNumber == 10)
            {
               fm_ss = new Frm_ShowSendNote();
               fm_ss.Close();
            }
            if (FormNumber == 6)
            {
                fm_rn = new Frm_ReciveNote();
                fm_rn.Close();
            }
            if (FormNumber == 3)
            {
                fm_un = new Frm_UnReadLetter();
                fm_un.Close();
            }
            if (FormNumber == 2)
            {
                fm_rel = new Frm_ReadLetter();
                fm_rel.Close();
            }
            if (FormNumber == 4) {
                fm_sf2 = new ShowletterForce2();
                fm_sf2.Close();
            }
            if (FormNumber == 5)
            {
                fm_st = new Frm_Security2();
                fm_st.Close();
            }
            if (FormNumber == 16)
            {
                fm_sa = new Frm_ShowNewsForAllUser();
                fm_sa.Close();
            }
            if (FormNumber == 11)
            {
                fm_srl = new SendRefrenceLetter();
                fm_srl.Close();
            }
            if (FormNumber == 20)
            {
                fm_rr = new Frm_ReciveRefrenceLEtter();
                fm_rr.Close();
            }

        }

        private void lbl_Draft_Click(object sender, EventArgs e)
        {
            var query = (from u in DBCommon.Context.UserAccess where u.UserID == PublicVariebale.gUserID where u.SystemPartID == 24 select u);
            var result = query.ToList();
            if (result.Count > 0)
            {
                formclosing();
                FormNumber = 15;
                fm_sd = new Frm_ShowDrafts();
                fm_sd.Show();
                // fm_sd.MdiParent = this;
                fm_sd.TopMost = true;
            }
            lbl_Draft.Text = "شما به این بخش دسترسی ندارید";
        }

        private void lbl_insertletter_Click(object sender, EventArgs e)
        {
            var query = (from u in DBCommon.Context.UserAccess where u.UserID == PublicVariebale.gUserID where u.SystemPartID == 21 select u);
            var result = query.ToList();
            if (result.Count > 0)
            {
                formclosing();
                FormNumber = 12;
                fm_cl = new Frm_CreateLetter();
                fm_cl.getFormtype = 1;///insert
                fm_cl.Show();
                fm_cl.TopMost = true;
            }
            else {
                lbl_insertletter.Text = "شما به این بخش دسترسی ندارید"; 
            }
        }

        private void lbl_Recive_Letter_Click(object sender, EventArgs e)
        {
            var query = (from u in DBCommon.Context.UserAccess where u.UserID == PublicVariebale.gUserID where u.SystemPartID == 10 select u);
            var result = query.ToList();
            if (result.Count > 0)
            {
                formclosing();              
                FormNumber = 1;
                fm_rl = new Frm_ReciveLetter();
               
                fm_rl.TopMost = true;
                fm_rl.Show();
                 
            }
            else {
                lbl_Recive_Letter.Text = "شما به این بخش دسترسی ندارید"; 


            }
           
        }

        private void lbl_SendLetter_Click(object sender, EventArgs e)
        {
            var query = (from u in DBCommon.Context.UserAccess where u.UserID == PublicVariebale.gUserID where u.SystemPartID == 13 select u);
            var result = query.ToList();
            if (result.Count > 0)
            {
                formclosing();
                FormNumber = 1;
                fm_sl = new Frm_SendLetter();
                fm_sl.Show();
                // fm_sd.MdiParent = this;
                fm_sl.TopMost = true;
            }
            else {
                lbl_SendLetter.Text = "شما به این بخش دسترسی ندارید";
            }
        }

        private void lbl_CratreNote_Click(object sender, EventArgs e)
        {
            var query = (from u in DBCommon.Context.UserAccess where u.UserID == PublicVariebale.gUserID where u.SystemPartID == 22  select u);
            var result = query.ToList();
            if (result.Count > 0)
            {
                formclosing();
                FormNumber = 13;
                fm_cn = new Frm_CrateNote();
                fm_cn.Show();
                // fm_sd.MdiParent = this;
                fm_cn.TopMost = true;
            }
            else {
                lbl_CratreNote.Text = "شما به این بخش دسترسی ندارید"; 
            }
        }

        private void lbl_SendNote_Click(object sender, EventArgs e)
        {
            var query = (from u in DBCommon.Context.UserAccess where u.UserID == PublicVariebale.gUserID where u.SystemPartID == 14 select u);
            var result = query.ToList();
            if (result.Count > 0)
            {
                formclosing();
                FormNumber = 10;
                fm_ss = new Frm_ShowSendNote();
                fm_ss.Show();
                // fm_sd.MdiParent = this;
                fm_ss.TopMost = true;
            }
            else {
                lbl_SendNote.Text = "شما به این بخش دسترسی ندارید";
            }
        }

        private void lbl_reciveNote_Click(object sender, EventArgs e)
        {
            var query = (from u in DBCommon.Context.UserAccess where u.UserID == PublicVariebale.gUserID where u.SystemPartID == 19 select u);
            var result = query.ToList();
            if (result.Count > 0)
            {
                formclosing();
                FormNumber = 6;
                fm_rn = new Frm_ReciveNote();
                fm_rn.Show();
                // fm_sd.MdiParent = this;
                fm_rn.TopMost = true;
            }
            else {
                lbl_reciveNote.Text = "شما به این بخش دسترسی ندارید"; 
            }
        }

        private void lbl_UnreadLetter_Click(object sender, EventArgs e)
        {
            var query = (from u in DBCommon.Context.UserAccess where u.UserID == PublicVariebale.gUserID where u.SystemPartID == 12 select u);
            var result = query.ToList();
            if (result.Count > 0)
            {
                formclosing();
                FormNumber = 3;
                fm_un = new Frm_UnReadLetter();
                fm_un.Show();
                // fm_sd.MdiParent = this;
                fm_un.TopMost = true;
            }
            else {
                lbl_UnreadLetter.Text = "شما به این بخش دسترسی ندارید"; 
            }
        }

        private void lbl_ReadLetter_Click(object sender, EventArgs e)
        {
            var query = (from u in DBCommon.Context.UserAccess where u.UserID == PublicVariebale.gUserID where u.SystemPartID == 11 select u);
            var result = query.ToList();
            if (result.Count > 0)
            {
                formclosing();
                FormNumber = 2;
                fm_rel = new Frm_ReadLetter();
                fm_rel.Show();
                // fm_sd.MdiParent = this;
                fm_rel.TopMost = true;
            }
            lbl_ReadLetter.Text = "شما به این بخش دسترسی ندارید";
        }

        private void lbl_force2_Click(object sender, EventArgs e)
        {
            var query = (from u in DBCommon.Context.UserAccess where u.UserID == PublicVariebale.gUserID where u.SystemPartID == 16 select u);
            var result = query.ToList();
            if (result.Count > 0)
            {
                formclosing();
                FormNumber = 4;
                fm_sf2 = new ShowletterForce2();
                fm_sf2.Show();
                // fm_sd.MdiParent = this;
                fm_sf2.TopMost = true;
            }
            else {
                lbl_force2.Text = "شما به این بخش دسترسی ندارید"; 
            }
        }

        private void lbl_Security2_Click(object sender, EventArgs e)
        {
            var query = (from u in DBCommon.Context.UserAccess where u.UserID == PublicVariebale.gUserID where u.SystemPartID == 17 select u);
            var result = query.ToList();
            if (result.Count > 0)
            {
                formclosing();
                FormNumber = 5;
                fm_st = new Frm_Security2();
                fm_st.Show();
                // fm_sd.MdiParent = this;
                fm_st.TopMost = true;
            }
            else {
                lbl_Security2.Text = "شما به این بخش دسترسی ندارید";
            }
        }

        private void labelItem16_Click(object sender, EventArgs e)
        {
            var query = (from u in DBCommon.Context.UserAccess where u.UserID == PublicVariebale.gUserID where u.SystemPartID == 25 select u);
            var result = query.ToList();
            if (result.Count > 0)
            {
                formclosing();
                FormNumber = 16;
                fm_sa = new Frm_ShowNewsForAllUser();
                fm_sa.Show();
                // fm_sd.MdiParent = this;
                fm_sa.TopMost = true;
            }
            else {
                lbl_information.Text = "شما به این بخش دسترسی ندارید";
              
            }
        }

        private void labelItem10_Click(object sender, EventArgs e)
        {
            var query = (from u in DBCommon.Context.UserAccess where u.UserID == PublicVariebale.gUserID where u.SystemPartID == 20 select u);
            var result = query.ToList();
            if (result.Count > 0)
            {
                formclosing();
                FormNumber = 11;
                fm_srl = new SendRefrenceLetter();
                fm_srl.Show();
                // fm_sd.MdiParent = this;
                fm_srl.TopMost = true;
            }
            else
                {
                labelItem10.Text = "شما به این بخش دسترسی ندارید";
            }
        }

        private void lbl_ReciveREfrenceLetter_Click(object sender, EventArgs e)
        {
            var query = (from u in DBCommon.Context.UserAccess where u.UserID == PublicVariebale.gUserID where u.SystemPartID == 18 select u);
            var result = query.ToList();
            if (result.Count > 0)
            {
                formclosing();
                FormNumber = 20;
                fm_rr = new Frm_ReciveRefrenceLEtter();
                fm_rr.Show();
                // fm_sd.MdiParent = this;
                fm_rr.TopMost = true;
            }
            else
            {

                lbl_ReciveREfrenceLetter.Text = "شما به این بخش دسترسی ندارید"; 
            }
        }

        private void lbl_changePassword_Click(object sender, EventArgs e)
        {
            Frm_ChangePassword fm = new Frm_ChangePassword();
            fm.TopMost = true;
            fm.ShowDialog();
        }
    }
}


