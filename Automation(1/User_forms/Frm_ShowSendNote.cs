﻿using System;
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

namespace Automation_1.User_forms
{
    public partial class Frm_ShowSendNote : Form
    {
        public Frm_ShowSendNote()
        {
            InitializeComponent();
        }
        private void ShowUser(string search)
        {
            var query = DBCommon.Context.Database.SqlQuery<VW_ReciveNote>("select * from VW_ReciveNote where UserID_Sender="+PublicVariebale.gUserID+ search);
            var result = query.ToList();
            if (result.Count != 0)
            {
                dgv_SendNote.RowCount = result.Count;
                for (int i = 0; i <= result.Count - 1; i++)
                {
                    dgv_SendNote.Rows[i].Cells["Note_ID"].Value = result[i].NoteID;
                    dgv_SendNote.Rows[i].Cells["Userid_Recive"].Value = result[i].User_Reciver;
                    dgv_SendNote.Rows[i].Cells["TextNote"].Value = result[i].MainText;
                    dgv_SendNote.Rows[i].Cells["Subject"].Value = result[i].Subject;
                    dgv_SendNote.Rows[i].Cells["NoteDate"].Value = result[i].CrateDate;
                    dgv_SendNote.Rows[i].Cells["ReciverUser"].Value = result[i].User_Reciver;



                }
                dgv_SendNote.ScrollBars = ScrollBars.Both;


            }
            else
            {

                dgv_SendNote.Rows.Clear();
            }
        }

        private void Frm_ShowSendNote_Load(object sender, EventArgs e)
        {
            timepicker_az.Value = DateTime.Now.AddDays(-10);
            ShowUser(Searchstring());
           
            this.Top = 135;
            this.Left = 1;
        }
        private string Searchstring()
        {
            string dateaz = String.Format("{0:yyyy/MM/dd }", Convert.ToDateTime(timepicker_az.Value.Year + "/" + timepicker_az.Value.Month + "/" + timepicker_az.Value.Day));
            string dateta = String.Format("{0:yyyy/MM/dd }", Convert.ToDateTime(timpepicker_ta.Value.Year + "/" + timpepicker_ta.Value.Month + "/" + timpepicker_ta.Value.Day));
            string search = " and CrateDate between '" + dateaz + "'" + " and '" + dateta + "'";
            if (txt_Sender.Text != "")
            {
                search += "and User_Reciver like'%" + txt_Sender.Text + "%'";
            }
           
            if (txtSubject.Text != "")
            {
                search += "and [Subject] like'%" + txt_Subject.Text + "%'";
            }


            return search;
        }

        private void picboc_search_Click(object sender, EventArgs e)
        {
            ShowUser(Searchstring());
        }
    }
}
