namespace Automation_1.Admin_forms
{
    partial class frm_setjobs
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("Node1");
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("Node2");
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("Node3");
            System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("Node0", new System.Windows.Forms.TreeNode[] {
            treeNode1,
            treeNode2,
            treeNode3});
            System.Windows.Forms.TreeNode treeNode5 = new System.Windows.Forms.TreeNode("Node4");
            this.treeView_jobslist = new System.Windows.Forms.TreeView();
            this.panelEx1 = new DevComponents.DotNetBar.PanelEx();
            this.lbl_fulllnnameset = new DevComponents.DotNetBar.LabelX();
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.btn_Clsoe = new DevComponents.DotNetBar.ButtonX();
            this.btn_InsertUser = new DevComponents.DotNetBar.ButtonX();
            this.panelEx2 = new DevComponents.DotNetBar.PanelEx();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.panelEx1.SuspendLayout();
            this.panelEx2.SuspendLayout();
            this.SuspendLayout();
            // 
            // treeView_jobslist
            // 
            this.treeView_jobslist.CheckBoxes = true;
            this.treeView_jobslist.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treeView_jobslist.Font = new System.Drawing.Font("B Mitra", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.treeView_jobslist.Location = new System.Drawing.Point(0, 0);
            this.treeView_jobslist.Name = "treeView_jobslist";
            treeNode1.Name = "Node1";
            treeNode1.Text = "Node1";
            treeNode2.Name = "Node2";
            treeNode2.Text = "Node2";
            treeNode3.Name = "Node3";
            treeNode3.Text = "Node3";
            treeNode4.Name = "Node0";
            treeNode4.Text = "Node0";
            treeNode5.Name = "Node4";
            treeNode5.Text = "Node4";
            this.treeView_jobslist.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode4,
            treeNode5});
            this.treeView_jobslist.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.treeView_jobslist.RightToLeftLayout = true;
            this.treeView_jobslist.Size = new System.Drawing.Size(582, 316);
            this.treeView_jobslist.TabIndex = 0;
            // 
            // panelEx1
            // 
            this.panelEx1.CanvasColor = System.Drawing.SystemColors.Control;
            this.panelEx1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.panelEx1.Controls.Add(this.lbl_fulllnnameset);
            this.panelEx1.Controls.Add(this.labelX1);
            this.panelEx1.Controls.Add(this.btn_Clsoe);
            this.panelEx1.Controls.Add(this.btn_InsertUser);
            this.panelEx1.Controls.Add(this.panelEx2);
            this.panelEx1.DisabledBackColor = System.Drawing.Color.Empty;
            this.panelEx1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelEx1.Location = new System.Drawing.Point(0, 0);
            this.panelEx1.Name = "panelEx1";
            this.panelEx1.Size = new System.Drawing.Size(582, 443);
            this.panelEx1.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.panelEx1.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.panelEx1.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.panelEx1.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.panelEx1.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.panelEx1.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.panelEx1.Style.GradientAngle = 90;
            this.panelEx1.TabIndex = 4;
            // 
            // lbl_fulllnnameset
            // 
            // 
            // 
            // 
            this.lbl_fulllnnameset.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lbl_fulllnnameset.Location = new System.Drawing.Point(207, 12);
            this.lbl_fulllnnameset.Name = "lbl_fulllnnameset";
            this.lbl_fulllnnameset.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lbl_fulllnnameset.Size = new System.Drawing.Size(101, 41);
            this.lbl_fulllnnameset.TabIndex = 10;
            this.lbl_fulllnnameset.Text = ".............";
            // 
            // labelX1
            // 
            // 
            // 
            // 
            this.labelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX1.Location = new System.Drawing.Point(299, 13);
            this.labelX1.Name = "labelX1";
            this.labelX1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.labelX1.Size = new System.Drawing.Size(101, 41);
            this.labelX1.TabIndex = 9;
            this.labelX1.Text = "انتصاب شغل به ";
            // 
            // btn_Clsoe
            // 
            this.btn_Clsoe.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btn_Clsoe.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btn_Clsoe.Font = new System.Drawing.Font("B Mitra", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btn_Clsoe.ImageTextSpacing = 4;
            this.btn_Clsoe.Location = new System.Drawing.Point(137, 393);
            this.btn_Clsoe.Name = "btn_Clsoe";
            this.btn_Clsoe.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btn_Clsoe.Shape = new DevComponents.DotNetBar.RoundRectangleShapeDescriptor(10, 0, 0, 10);
            this.btn_Clsoe.Size = new System.Drawing.Size(128, 38);
            this.btn_Clsoe.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btn_Clsoe.Symbol = "";
            this.btn_Clsoe.TabIndex = 8;
            this.btn_Clsoe.Text = "خروج";
            this.btn_Clsoe.Click += new System.EventHandler(this.btn_Clsoe_Click);
            // 
            // btn_InsertUser
            // 
            this.btn_InsertUser.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btn_InsertUser.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btn_InsertUser.Font = new System.Drawing.Font("B Mitra", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btn_InsertUser.ImageTextSpacing = 4;
            this.btn_InsertUser.Location = new System.Drawing.Point(324, 393);
            this.btn_InsertUser.Name = "btn_InsertUser";
            this.btn_InsertUser.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btn_InsertUser.Shape = new DevComponents.DotNetBar.RoundRectangleShapeDescriptor(10, 0, 0, 10);
            this.btn_InsertUser.Size = new System.Drawing.Size(128, 38);
            this.btn_InsertUser.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btn_InsertUser.Symbol = "";
            this.btn_InsertUser.TabIndex = 7;
            this.btn_InsertUser.Text = "انتصاب پست";
            this.btn_InsertUser.Click += new System.EventHandler(this.btn_InsertUser_Click);
            // 
            // panelEx2
            // 
            this.panelEx2.CanvasColor = System.Drawing.SystemColors.Control;
            this.panelEx2.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.panelEx2.Controls.Add(this.treeView_jobslist);
            this.panelEx2.DisabledBackColor = System.Drawing.Color.Empty;
            this.panelEx2.Location = new System.Drawing.Point(0, 60);
            this.panelEx2.Name = "panelEx2";
            this.panelEx2.Size = new System.Drawing.Size(582, 316);
            this.panelEx2.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.panelEx2.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.panelEx2.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.panelEx2.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.panelEx2.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.panelEx2.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.panelEx2.Style.GradientAngle = 90;
            this.panelEx2.TabIndex = 0;
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // frm_setjobs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(582, 443);
            this.Controls.Add(this.panelEx1);
            this.Font = new System.Drawing.Font("B Mitra", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frm_setjobs";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "frm_setjobs";
            this.Activated += new System.EventHandler(this.frm_SetJobs_Activated);
            this.panelEx1.ResumeLayout(false);
            this.panelEx2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TreeView treeView_jobslist;
        private DevComponents.DotNetBar.PanelEx panelEx1;
        internal DevComponents.DotNetBar.LabelX lbl_fulllnnameset;
        private DevComponents.DotNetBar.LabelX labelX1;
        private DevComponents.DotNetBar.ButtonX btn_Clsoe;
        private DevComponents.DotNetBar.ButtonX btn_InsertUser;
        private DevComponents.DotNetBar.PanelEx panelEx2;
        private System.Windows.Forms.ImageList imageList1;
    }
}