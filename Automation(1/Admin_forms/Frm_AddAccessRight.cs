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
    public partial class Frm_AddAccessRight : Form
    {
        public int UserID { get; set; }
        public string FirstName { get; set; }
        public string LasttName { get; set; }
        public Frm_AddAccessRight()
        {
            InitializeComponent();
        }
        private void Frm_DefineSystemCommponent_Activated(object sender, EventArgs e)
        {
            trv_setuseraccess.Nodes.Clear();
            var query = (from u in DBCommon.Context.VW_SystemPart select u).ToList();
            string name = query[0].SystemPartName.ToString();
            TreeNode n = new TreeNode(name);
            n.ForeColor = Color.Red;
            n.Tag = "1";
            trv_setuseraccess.Nodes.Add(n);
            LoadTreeView(n);
            n.Expand();
        }
        private void LoadTreeView(TreeNode TN)
        {
            int TagInt;
            TagInt = Convert.ToInt32(TN.Tag);

            var query = from SPF in DBCommon.Context.VW_SystemPart
                        where SPF.SystemPartLevel == TagInt
                        select SPF;
            var users = query.ToList();

            if (users.Count > 0)
            {
                int get_sysPartFormId;

                for (int I = 0; I < users.Count; I++)
                {
                    TreeNode M = new TreeNode();
                    M.Tag = users[I].SystemPartID;
                    M.Text = M.Tag + " - " + users[I].SystemPartName;
                    M.ToolTipText = "" + M.Tag;
                    get_sysPartFormId = Convert.ToInt32(M.Tag);
                    var query1 = from UA in DBCommon.Context.UserAccess
                                 where UA.UserID == this.UserID
                                 where UA.SystemPartID == get_sysPartFormId
                                 select UA;
                    var users1 = query1.ToList();
                    if (users1.Count > 0)
                        M.Checked = true;

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

        private void Frm_AddAccessRight_Load(object sender, EventArgs e)
        {
            lbl_name.Text = "فرم تایین دسترسی برای کاربر " + this.FirstName + " " + this.LasttName;
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void treeView_SystemPart_AfterCheck(object sender, TreeViewEventArgs e)
        {
            CheckTreeViewChild(e.Node, e.Node.Checked);
        }

        private void CheckTreeViewChild(TreeNode node, bool Ischecked)
        {
            foreach (TreeNode item in node.Nodes)
            {
                item.Checked = Ischecked;
                if (item.Nodes.Count > 0) {
                    this.CheckTreeViewChild(item, Ischecked);
                }
            }
        }

        private void btn_createjob_Click(object sender, EventArgs e)
        {
            GetArrayofCheckedNodes();
            MessageBox.Show(" ثبت دسترسی با موفقیت انجام شد", "موفقیت", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private string GetArrayofCheckedNodes()
        {
            return string.Join(" , ", GetCheckedNodes(trv_setuseraccess.Nodes));
        }
        public List<string> GetCheckedNodes(TreeNodeCollection nodes)
        {
            List<string> nodeList = new List<string>();
            if (nodes == null)
            {
                return nodeList;
            }

            foreach (TreeNode childNode in nodes)
            {
                if (childNode.Checked)
                {

                    UserAccess UserAccess = new UserAccess();
                    UserAccess.UserID = this.UserID;
                    UserAccess.SystemPartID = Convert.ToInt32(childNode.Tag);


                    var query = from SPF in DBCommon.Context.UserAccess
                                where SPF.UserID == UserAccess.UserID
                                where SPF.SystemPartID == UserAccess.SystemPartID
                                select SPF;
                    var users = query.ToList();

                    if (users.Count == 0)
                    {
                        DBCommon.Context.UserAccess.Add(UserAccess);
                        DBCommon.Context.SaveChanges();
                    }
                }
                else if (childNode.Checked == false && (childNode.Tag) != "1")
                {
                    try
                    {
                        DBCommon.Context.sp_Del_UserAccess(this.UserID, Convert.ToInt32(childNode.Tag));
                        DBCommon.Context.SaveChanges();
                    }
                    catch
                    {
                        MessageBox.Show("در ثبت اطلاعات مشکلی پیش آمده است","خطا",MessageBoxButtons.OK,MessageBoxIcon.Error);
                    }
                }
                nodeList.AddRange(GetCheckedNodes(childNode.Nodes));
            }
            return nodeList;
        }
    }
}
