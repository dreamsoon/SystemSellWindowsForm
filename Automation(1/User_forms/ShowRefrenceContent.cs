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
   
    public partial class ShowRefrenceContent : Form
    {
        public int gletterid { get; set; }
        public byte type { get; set; }

        public ShowRefrenceContent()
        {
            InitializeComponent();
        }

        private void ShowRefrenceContent_Load(object sender, EventArgs e)
        {
            if (this.type == 1) {
                lbl_refrencebe.Visible = true;
                var query = (from l in DBCommon.Context.VW_RefrenceT where l.LetterID == this.gletterid select l).ToList();
                if (query.Count == 1)
                {

                    lbl_Subject.Text = query[0].Subject;
                    lbl_Sender.Text = query[0].erjashodename;
                    lbl_refrence.Text = query[0].rojoshodeName;
                    lbl_text.Text = query[0].Maintext;
                    lbl_number.Text = "نامه با شماره : " + query[0].LetterNum;
                }

            }
            else { 
            var query = (from l in DBCommon.Context.VW_RefrenceT where l.LetterID == this.gletterid select l).ToList();
                if (query.Count == 1)
                {

                    lbl_Subject.Text = query[0].Subject;
                    lbl_Sender.Text = query[0].erjashodename;
                    lbl_refrence.Text = query[0].erjakonandeName;
                    lbl_text.Text = query[0].Maintext;
                    lbl_number.Text = "نامه با شماره : " + query[0].LetterNum;
                }

            }
        }
    }
}
