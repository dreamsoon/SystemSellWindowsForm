using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Automation_1.User_forms
{
    
    public partial class Frm_LetterCount : Form
    {
        public int glettercount { get; set; }
        public Frm_LetterCount()
        {
            InitializeComponent();
        }

        private void Frm_LetterCount_Load(object sender, EventArgs e)
        {
            labelX1.Text = "شما" + glettercount + " نامه جدید دارید";
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
