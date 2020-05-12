﻿using Automation_1.Modula;
using DataModelLayer.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Automation_1.User_forms
{
    public partial class Frm_ReciveRefrenceLEtter : Form
    {
        public Frm_ReciveRefrenceLEtter()
        {
            InitializeComponent();
        }
        private void ShowRefrenceLetter()
        {
            var query = DBCommon.Context.Database.SqlQuery<VW_RefrenceT>("select * From VW_RefrenceT where ReciveRefrenceUserID=" + PublicVariebale.gUserID);
            var result = query.ToList();
            dgv_ReciveLetter.Rows.Clear();
            if (result.Count != 0)
            {
                dgv_ReciveLetter.RowCount = result.Count;
                for (int i = 0; i <= result.Count - 1; i++)
                {

                    dgv_ReciveLetter.Rows[i].Cells["RefrenceID"].Value = result[i].RefrenceID;
                    dgv_ReciveLetter.Rows[i].Cells["LetterID"].Value = result[i].LetterID;
                    dgv_ReciveLetter.Rows[i].Cells["UserSender"].Value = result[i].erjashodename;
                    dgv_ReciveLetter.Rows[i].Cells["LetterNumber"].Value = result[i].LetterNum;
                    dgv_ReciveLetter.Rows[i].Cells["Subject"].Value = result[i].Subject;
                    dgv_ReciveLetter.Rows[i].Cells["erjadahande"].Value = result[i].erjakonandeName;
                    dgv_ReciveLetter.Rows[i].Cells["tabaghebandi"].Value = result[i].FarsiSecuretyType;
                    dgv_ReciveLetter.Rows[i].Cells["bayganistatus"].Value = result[i].FarsiBayganiType;
                    dgv_ReciveLetter.Rows[i].Cells["foriat"].Value = result[i].FarsiForceType;
                    dgv_ReciveLetter.Rows[i].Cells["sanadtype"].Value = result[i].FarsiLetterType;
                    dgv_ReciveLetter.Rows[i].Cells["RefrenceTime"].Value = result[i].CreateDate;
                   
                    if (Convert.ToInt32(dgv_ReciveLetter.Rows[i].Cells["forcet"].Value) == 2)
                    {
                        dgv_ReciveLetter.Rows[i].Cells["forieat"].Style.BackColor = Color.Yellow;
                    }
                    if (Convert.ToInt32(dgv_ReciveLetter.Rows[i].Cells["forcet"].Value) == 3)
                    {
                        dgv_ReciveLetter.Rows[i].Cells["forieat"].Style.BackColor = Color.Red;
                    }


                }

                dgv_ReciveLetter.TopLeftHeaderCell.Value = "ردیف";
                for (int i = 0; i <= dgv_ReciveLetter.Rows.Count - 1; i++)
                {
                    dgv_ReciveLetter.Rows[i].HeaderCell.Value = (i + 1).ToString();
                }
                dgv_ReciveLetter.ScrollBars = ScrollBars.Both;


            }
            else
            {

                dgv_ReciveLetter.Rows.Clear();
            }
        }

        private void Frm_ReciveRefrenceLEtter_Load(object sender, EventArgs e)
        {
            ShowRefrenceLetter();
            this.Top = 135;
            this.Left = 1;
        }

        private void dgv_ReciveLetter_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            ShowRefrenceContent fm = new ShowRefrenceContent();
            fm.gletterid = Convert.ToInt32(dgv_ReciveLetter.CurrentRow.Cells["LetterID"].Value.ToString());
            fm.TopMost = true;
            fm.ShowDialog();
        }
    }
}
