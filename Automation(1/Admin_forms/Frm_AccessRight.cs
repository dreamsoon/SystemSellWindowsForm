using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Automation_1.Admin_forms
{
    public partial class Frm_AccessRight : Form
    {
        public Frm_AccessRight()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Frm_DefineSystemCommponent fm = new Frm_DefineSystemCommponent();
            fm.ShowDialog();
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_accessRight_Click(object sender, EventArgs e)
        {
            frm_ShowUserscs fm = new frm_ShowUserscs();
            fm.btn_accesright.Visible = true;
            fm.btn_InsertUser.Visible = false;
            fm.btn_EditUser.Visible = false;
            fm.btn_DeactiveUser.Visible = false;
            fm.btn_Clsoe.Visible = false;
            fm.ShowDialog();
        }

        private void btn_ChangePasswprd_Click(object sender, EventArgs e)
        {
            frm_ShowUserscs fm = new frm_ShowUserscs();
            fm.btn_password.Visible = true;
            fm.btn_InsertUser.Visible = false;
            fm.btn_EditUser.Visible = false;
            fm.btn_DeactiveUser.Visible = false;
            fm.btn_Clsoe.Visible = false;
            fm.ShowDialog();
        }
    }
}
