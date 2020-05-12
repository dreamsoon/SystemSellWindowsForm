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
namespace Automation_1.Admin_forms
{
    public partial class Frm_AddSystemPart : Form
    {
        public int GetSystemPartid { get; set;
        } 
        public Frm_AddSystemPart()
        {
            InitializeComponent();
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_createjob_Click(object sender, EventArgs e)
        {
            SystemPart s = new SystemPart();
            s.SystemPartName = txt_name.Text.Trim();
            s.SystemPartDeatiles = txt_deatiles.Text.Trim();
            s.SystemPartLevel = this.GetSystemPartid;
            DBCommon.Context.SystemPart.Add(s);
            DBCommon.Context.SaveChanges();
            MessageBox.Show("بخش جدید با موفقیت اضافه شد", "موفقیت", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }
    }
}
