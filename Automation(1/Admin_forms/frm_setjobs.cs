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

namespace Automation_1.Admin_forms
{
    public partial class frm_setjobs : Form
    {
        public int GetUserIDForSetJob { set; get; }

        public frm_setjobs()
        {
            InitializeComponent();
        }

        private void btn_InsertUser_Click(object sender, EventArgs e)
        {
            ChekedList(treeView_jobslist.Nodes);
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
        public List<string> ChekedList(TreeNodeCollection node)
        {

            List<string> nodelist = new List<string>();
            if (node == null)
            {
                return nodelist;
            }
            foreach (TreeNode chilednode in node)
            {

                if (chilednode.Checked)
                {
                    UsersJobs j = new UsersJobs();
                    j.UserID = this.GetUserIDForSetJob;
                    j.JobsID = Convert.ToInt32(chilednode.Tag);
                    j.StartDate = PublicVariebale.ToDayDate;
                    j.Status = 1;
                    DBCommon.Context.UsersJobs.Add(j);
                    DBCommon.Context.SaveChanges();
                    MessageBox.Show("انتصاب شغل با موفقیت ثبت شذ", "Succses", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();

                }
                nodelist.AddRange(ChekedList(chilednode.Nodes));



            }
            return nodelist;

        }
        private void frm_SetJobs_Activated(object sender, EventArgs e)
        {
            treeView_jobslist.Nodes.Clear();
            TreeNode n = new TreeNode("مدیر عامل");
            n.ForeColor = Color.Red;
            n.Tag = "1";
            treeView_jobslist.Nodes.Add(n);
            LoadTreeviewNode(n);
            n.Expand();

        }

        private void btn_Clsoe_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
