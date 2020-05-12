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
using DataModelLayer.Model;
using Automation_1.Modula;
using System.Transactions;
namespace Automation_1.User_forms
{
    public partial class Frm_CreateLetter : Form
    {
        public int getLetterID { get; set; }
        public byte getFormtype { get; set; }
        public string gLetterNum { get; set; }
        public byte gReplay { get; set; }/// <summary>
        /// /if Reply=1 --->Relplay LEtter
        /// </summary>
        public Frm_CreateLetter()
        {
            InitializeComponent();
        }

        private void Frm_CreateLetter_Load(object sender, EventArgs e)
        {
            if (gReplay == 1) {
                lbl_replay.Visible = true;
            }
            this.Top = 135;
            this.Left = 1;
            lbl_Date.Text = PublicVariebale.ToDayDate;
            if (getFormtype == 2)
            {
                var query = (from u in DBCommon.Context.AtachFile where u.LetterID == this.getLetterID select u).ToList();
                if (query.Count > 0)
                {
                    lbl_Atachment.Text = query[0].FileName;
                }
                showorginalinformation();
                btn_SendLetter.Text = "ویرایش نامه";
            }

        }

        private void showorginalinformation()
        {
            var query = (from u in DBCommon.Context.Letters where u.LetterID == getLetterID select u).ToList();
            if (query.Count > 0)
            {
                txt_Subject.Text = query[0].Subject;
                txt_Abstaract.Text = query[0].Abstract;
                advancedTextEditor.TextEditor.Text = query[0].Maintext;
                if (query[0].SecuretyType == 1)
                {
                    rdb_tabaghe_addi.Checked = true;
                }
                else if (query[0].SecuretyType == 2)
                {
                    rdb_tabaghe_mahramane.Checked = true;
                }
                else if (query[0].SecuretyType == 3)
                {
                    rdb_tabaghe_seri.Checked = true;
                }

                /////
                ///
                if (query[0].ForceType == 1)
                {
                    rdb_forieat_addi.Checked = true;
                }
                else if (query[0].ForceType == 2)
                {
                    rdb_forieat_fori.Checked = true;
                }
                else if (query[0].ForceType == 3)
                {
                    rdb_forieat_ani.Checked = true;
                }
                ///
              
                ///
                if (query[0].AttachmentType == 1)
                {
                    rdb_peyvast_darad.Checked = true;
                }
                else if (query[0].AttachmentType == 2)
                {
                    rdb_peyvast_nadarad.Checked = true;
                }
                /////
                ///
                if (query[0].AnswerType == 1)
                {
                    rdb_mohlat_darad.Checked = true;
                    timepicker_dedlineanaswer.Value = Convert.ToDateTime(query[0].Answerdeadline);

                }
                else if (query[0].AnswerType == 2)
                {
                    rdb_mohlat_nadarad.Checked = true;
                }
            }
        }

        private void rdb_peyvast_darad_CheckedChanged(object sender, EventArgs e)
        {
            if (rdb_peyvast_darad.Checked == true)
            {

                btn_atachment.Enabled = true;
            }
            else
            {
                btn_atachment.Enabled = false;
            }
        }

        private void rdb_mohlat_darad_CheckedChanged(object sender, EventArgs e)
        {
            if (rdb_mohlat_darad.Checked == true)
            {

                timepicker_dedlineanaswer.Enabled = true;
            }
            else
            {

                timepicker_dedlineanaswer.Enabled = false;

            }

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

        private void btn_SendLetter_Click(object sender, EventArgs e)
        {
            if (txt_Subject.Text.Trim() == "" && txt_Abstaract.Text.Trim() == "" && advancedTextEditor.TextEditor.Text.Trim() == "")
            {
                MessageBox.Show("لطفا اطلاعات نامه را به صورت کامل وارد کنید", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (getFormtype == 1)
            { //insert
                using (TransactionScope ts = new TransactionScope())
                {



                    Letters l = new Letters();
                    l.Subject = txt_Subject.Text;
                    l.Abstract = txt_Abstaract.Text;
                    l.Maintext = advancedTextEditor.TextEditor.Text;
                    ////***//
                    ///
                    var lastLetterID = (from letter in DBCommon.Context.Letters orderby letter.LetterID descending select letter).First();
                    l.LetterNum = PublicVariebale.ToDayDate.Substring(0, 4).Substring(2, 2) + PublicVariebale.JobsDetermineLevel + "/" + lastLetterID.LetterID + 1;
                    //
                    l.CreateDate = lbl_Date.Text;
                    l.UserID = PublicVariebale.gUserID;
                    ///
                    if (rdb_tabaghe_addi.Checked == true)
                    {
                        l.SecuretyType = 1;
                    }
                    else if (rdb_tabaghe_mahramane.Checked == true)
                    {
                        l.SecuretyType = 2;
                    }
                    else if (rdb_tabaghe_seri.Checked == true)
                    {
                        l.SecuretyType = 3;
                    }
                    ///
                    if (rdb_forieat_addi.Checked == true)
                    {
                        l.ForceType = 1;
                    }
                    else if (rdb_forieat_fori.Checked == true)
                    {
                        l.ForceType = 2;
                    }
                    else if (rdb_forieat_ani.Checked == true)
                    {
                        l.ForceType = 3;
                    }
                    //
                    l.BayganiType = 1;
                    ////
                    
                        l.PeygiriType = 1;
                    
                    ///
                    if (rdb_peyvast_darad.Checked == true)
                    {
                        l.AttachmentType = 1;
                    }
                    else
                    {
                        l.AttachmentType = 2;
                    }
                    ////
                   
                    //
                    l.DraftyType = 1;
                    //
                    if (rdb_mohlat_darad.Checked == true)
                    {
                        l.AnswerType = 1;
                        l.Answerdeadline = String.Format("{0:yyyy/MM/dd}", Convert.ToDateTime(timepicker_dedlineanaswer.Value.Year + "/" + timepicker_dedlineanaswer.Value.Month + "/" + timepicker_dedlineanaswer.Value.Day));
                    }
                    else if (rdb_mohlat_nadarad.Checked == true)
                    {
                        l.AnswerType = 2;
                    }
                    if (this.gReplay == 1)
                    {
                        l.Refrence = this.gLetterNum;
                        l.ReplayLetterID = this.getLetterID;
                        l.LetterType = 2;
                    }
                    else {
                        l.LetterType = 1;
                        l.Refrence = "";
                        l.ReplayLetterID =-1;
                    }
                    DBCommon.Context.Letters.Add(l);

                    /////AtachFile
                    ///
                    if (rdb_peyvast_darad.Checked == true)
                    {

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
                            AtachFile af = new AtachFile();
                            af.FileSize = intlenght / 1024;//KB
                            af.FileName = strpatch[strpatch.Length - 1];
                            af.FileData = objdata;
                            af.LetterID = l.LetterID;
                            DBCommon.Context.AtachFile.Add(af);
                        }

                    }
                    DBCommon.Context.SaveChanges();
                    ts.Complete();
                    if (gReplay == 1)
                    {

                        MessageBox.Show("پاسخ نامه با موفقیت ایجاد شد و به بخش پیشنویس منقل گردید", "موفقیت", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else {
                        MessageBox.Show("نامه با موفقیت ایجاد شد و به بخش پیشنویس منقل گردید", "موفقیت", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }


            }
            if (getFormtype == 2)
            {///Update
                using (TransactionScope ts = new TransactionScope())
                {



                    var l = (from u in DBCommon.Context.Letters where u.LetterID == getLetterID where u.UserID == PublicVariebale.gUserID select u).SingleOrDefault();
                    l.Subject = txt_Subject.Text;
                    l.Abstract = txt_Abstaract.Text;
                    l.Maintext = advancedTextEditor.TextEditor.Text;
                    ////***//

                    l.CreateDate = lbl_Date.Text;
                    l.UserID = PublicVariebale.gUserID;
                    ///
                    if (rdb_tabaghe_addi.Checked == true)
                    {
                        l.SecuretyType = 1;
                    }
                    else if (rdb_tabaghe_mahramane.Checked == true)
                    {
                        l.SecuretyType = 2;
                    }
                    else if (rdb_tabaghe_seri.Checked == true)
                    {
                        l.SecuretyType = 3;
                    }
                    ///
                    if (rdb_forieat_addi.Checked == true)
                    {
                        l.ForceType = 1;
                    }
                    else if (rdb_forieat_fori.Checked == true)
                    {
                        l.ForceType = 2;
                    }
                    else if (rdb_forieat_ani.Checked == true)
                    {
                        l.ForceType = 3;
                    }
                    //

                    if (rdb_peyvast_darad.Checked == true)
                    {
                        l.PeygiriType = 1;
                    }
                    else
                    {
                        l.PeygiriType = 2;
                    }
                    ///
                    if (rdb_peyvast_darad.Checked == true)
                    {
                        l.AttachmentType = 1;
                    }
                    else
                    {
                        l.PeygiriType = 2;
                    }
                    ////


                    //
                    if (rdb_mohlat_darad.Checked == true)
                    {
                        l.AnswerType = 1;
                        l.Answerdeadline = String.Format("{0:yyyy/MM/dd}", Convert.ToDateTime(timepicker_dedlineanaswer.Value.Year + "/" + timepicker_dedlineanaswer.Value.Month + "/" + timepicker_dedlineanaswer.Value.Day));
                    }
                    else if (rdb_mohlat_nadarad.Checked == true)
                    {
                        l.AnswerType = 2;
                        l.Answerdeadline = "";

                    }



                    ///AtachFile

                    if (rdb_peyvast_darad.Checked == true)
                    {

                        if (lbl_Atachment.Text != "")
                        {
                            var query_chekatachment = (from u in DBCommon.Context.AtachFile where u.LetterID == this.getLetterID select u).ToList();
                            if (query_chekatachment.Count == 0)
                            {//نامه پیوست نداشته ولی بعد از ویرایش پیوست دارد
                                FileStream objFileStream = new FileStream(lbl_Atachment.Text, FileMode.Open, FileAccess.Read);
                                int intlenght = Convert.ToInt32(objFileStream.Length);
                                byte[] objdata;
                                objdata = new byte[intlenght];
                                string[] strpatch = lbl_Atachment.Text.Split(Convert.ToChar(@"\"));
                                objFileStream.Read(objdata, 0, intlenght);
                                objFileStream.Close();
                                ///
                                AtachFile af = new AtachFile();
                                af.FileSize = intlenght / 1024;//KB
                                af.FileName = strpatch[strpatch.Length - 1];
                                af.FileData = objdata;
                                af.LetterID = this.getLetterID;
                                DBCommon.Context.AtachFile.Add(af);

                            }
                            else if (query_chekatachment.Count == 1)
                            {//نامه پیوست داشته ولی بعد از پیوست تغیر کرده  است
                                if (lbl_Atachment.Text != query_chekatachment[0].FileName) { 
                                FileStream objFileStream = new FileStream(lbl_Atachment.Text, FileMode.Open, FileAccess.Read);
                                int intlenght = Convert.ToInt32(objFileStream.Length);
                                byte[] objdata;
                                objdata = new byte[intlenght];
                                string[] strpatch = lbl_Atachment.Text.Split(Convert.ToChar(@"\"));
                                objFileStream.Read(objdata, 0, intlenght);
                                objFileStream.Close();
                                ///
                                var query_chekatachment_edit = (from u in DBCommon.Context.AtachFile where u.LetterID == this.getLetterID select u).SingleOrDefault();
                                query_chekatachment_edit.FileSize = intlenght / 1024;//KB
                                query_chekatachment_edit.FileName = strpatch[strpatch.Length - 1];
                                query_chekatachment_edit.FileData = objdata;

                                DBCommon.Context.SaveChanges();
                                    }
                            }

                        }

                    }
                    DBCommon.Context.SaveChanges();
                    ts.Complete();
                    MessageBox.Show("نامه با موفقیت ویرایش شد و به بخش پیشنویس منقل گردید", "موفقیت", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }


        }
    }
}

