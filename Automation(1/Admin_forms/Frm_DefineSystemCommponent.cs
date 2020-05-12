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
    public partial class Frm_DefineSystemCommponent : Form
    {
        public Frm_DefineSystemCommponent()
        {
            InitializeComponent();
        }

        private void Frm_DefineSystemCommponent_Activated(object sender, EventArgs e)
        {
            treeView_SystemPart.Nodes.Clear();
            var query = (from u in DBCommon.Context.VW_SystemPart select u).ToList();
            string name = query[0].SystemPartName.ToString();
            TreeNode n = new TreeNode(name);
            n.ForeColor = Color.Red;
            n.Tag = "1";
            treeView_SystemPart.Nodes.Add(n);
            LoadTreeView(n);
            n.Expand();
        }
        private void LoadTreeView(TreeNode TN)
        {

            int TagInt;
            TagInt = Convert.ToInt32(TN.Tag);
            /////////////////////////////////////////////////////////////////////////
            var query = from SPF in DBCommon.Context.VW_SystemPart
                        where SPF.SystemPartLevel == TagInt
                        select SPF;
            var users = query.ToList();

            if (users.Count > 0)
            {
                for (int I = 0; I < users.Count; I++)
                {
                    TreeNode M = new TreeNode();
                    M.Tag = users[I].SystemPartID;
                    M.Text = M.Tag + " - " + users[I].SystemPartName;
                    M.ToolTipText = "" + M.Tag;

                    if (TN.Level < this.imageList.Images.Count - 1)
                    {
                        M.ImageIndex = TN.Level + 1;
                        M.SelectedImageIndex = TN.Level + 1;
                    }
                    else
                    {
                        M.ImageIndex = this.imageList.Images.Count - 1;
                        M.SelectedImageIndex = this.imageList.Images.Count - 1;
                    }
                    TN.Nodes.Add(M);
                    int CH = Convert.ToInt32(users[I].childecount);
                    if (CH > 0)
                    {
                        LoadTreeView(M);
                    }
                    M = null;
                }
            }

        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_createjob_Click(object sender, EventArgs e)
        {
            if (treeView_SystemPart.SelectedNode == null) {
                MessageBox.Show("لطفا ابتدا یک اجزای سیستم را انتخاب کنید", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            int getTag =Convert.ToInt32(treeView_SystemPart.SelectedNode.Tag);
            Frm_AddSystemPart fm = new Frm_AddSystemPart();
            fm.GetSystemPartid = getTag;
            fm.ShowDialog();
            

        }
    }
}
