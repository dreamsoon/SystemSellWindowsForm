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
    public partial class frm_AddrEditJobs : Form
    {
        public int getdemitranionleveljobs { set; get; }
        public int getleveljobs { get; set; }
        public int FormType { get; set; }
        public int JobsID { get; set; }
        public frm_AddrEditJobs()
        {
            InitializeComponent();
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_createjob_Click(object sender, EventArgs e)
        {
            if (FormType == 1)
            {
                Jobs j = new Jobs();
                j.JobsName = txt_Name.Text.Trim();
                j.JobsDeatiles = txt_Deatiels.Text.Trim();
                j.JobsLevel = getleveljobs;
                j.JobsDetermineLevel = getdemitranionleveljobs + 1;
                DBCommon.Context.Jobs.Add(j);
                DBCommon.Context.SaveChanges();
                MessageBox.Show("اطلاعات با موفقیت ثبت گردید", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            else if (FormType == 2)
            {


                var query = (from j in DBCommon.Context.Jobs where j.JobsID == this.JobsID select j).SingleOrDefault();
                query.JobsName = txt_Name.Text.Trim();
                query.JobsDeatiles = txt_Deatiels.Text.Trim();
                DBCommon.Context.SaveChanges();
                MessageBox.Show("اطلاعات با موفقیت ثبت گردید", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
        }
        private void frm_AddrEditJobs_Load(object sender, EventArgs e)
        {
            if (FormType == 2)
            {
                var query = (from j in DBCommon.Context.Jobs where j.JobsID == this.JobsID select j).ToList();
                if (query.Count == 1)
                {
                    txt_Name.Text = query[0].JobsName;
                    txt_Deatiels.Text = query[0].JobsDeatiles;
                }
            }
        }

    }


    }


    

