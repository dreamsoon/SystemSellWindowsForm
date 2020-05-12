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
    public partial class frm_Jobs : Form
    {
        public frm_Jobs()
        {
            InitializeComponent();
        }
        public int GetLevel;
        private void btn_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void frm_ShowJobs_Activated(object sender, EventArgs e)
        {
            treeView_jobslist.Nodes.Clear();
            var query = (from u in DBCommon.Context.Jobs select u).ToList();
            string name = query[0].JobsName.ToString();
            TreeNode n = new TreeNode(name);
            n.ForeColor = Color.Red;
            n.Tag = "1";
            treeView_jobslist.Nodes.Add(n);
            LoadTreeviewNode(n);
            n.Expand();

        }

        private void LoadTreeviewNode(TreeNode TN)
        {
            int TagInt;
            TagInt = Convert.ToInt32(TN.Tag);
            var query = (from vw_j in DBCommon.Context.VW_Jobs where vw_j.JobsLevel == TagInt select vw_j).ToList();

            if (query.Count > 0)
            {
                for (int I = 0; I < query.Count; I++)
                {
                    TreeNode M = new TreeNode();
                    M.Tag = query[I].JobsID;
                    M.Text = query[I].JobsID + "-" + query[I].JobsName;


                    if (TN.Level < this.imageList1.Images.Count - 1)
                    {
                        M.ImageIndex = TN.Level + 1;
                        M.SelectedImageIndex = TN.Level + 1;
                    }
                    else
                    {
                        M.ImageIndex = this.imageList1.Images.Count - 1;
                        M.SelectedImageIndex = this.imageList1.Images.Count - 1;
                    }


                    TN.Nodes.Add(M);
                    int CH = Convert.ToInt32(query[I].ChildeCount);
                    if (CH > 0)
                    {
                        LoadTreeviewNode(M);
                    }
                    M = null;
                }
            }
        }
        private void btn_createjob_Click(object sender, EventArgs e)
        {
            if (treeView_jobslist.SelectedNode == null)
            {

                MessageBox.Show("لطفا ردیف شغلی را انتخاب کنید", "راهنمایی", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return;
            }
            frm_AddrEditJobs fm = new frm_AddrEditJobs();
            int tag = Convert.ToInt32(treeView_jobslist.SelectedNode.Tag);
            fm.getleveljobs = tag;
            fm.getdemitranionleveljobs = GetLevel;
            fm.FormType = 1;
            fm.ShowDialog();
            treeView_jobslist.Refresh();
        }
        private void treeView_jobslist_AfterSelect(object sender, TreeViewEventArgs e)
        {
            TreeNode node = treeView_jobslist.SelectedNode;
            GetLevel = e.Node.Level;
        }

        private void btn_editjob_Click(object sender, EventArgs e)
        {
            frm_AddrEditJobs fm = new frm_AddrEditJobs();
            fm.FormType = 2;
            int tagnumber = Convert.ToInt32(treeView_jobslist.SelectedNode.Tag);
            fm.JobsID = tagnumber;
            fm.ShowDialog();
        }
    }
}
