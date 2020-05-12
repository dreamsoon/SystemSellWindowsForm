namespace Automation_1.User_forms
{
    partial class Frm_SelectedUserForSendLetter
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panelEx1 = new DevComponents.DotNetBar.PanelEx();
            this.btn_Send = new DevComponents.DotNetBar.ButtonX();
            this.btn_Clsoe = new DevComponents.DotNetBar.ButtonX();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txt_FullName = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX3 = new DevComponents.DotNetBar.LabelX();
            this.labelX2 = new DevComponents.DotNetBar.LabelX();
            this.dgvShowUser = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.UserID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UsersJobsID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Select = new DevComponents.DotNetBar.Controls.DataGridViewCheckBoxXColumn();
            this.FullName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.job = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.panelEx1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvShowUser)).BeginInit();
            this.SuspendLayout();
            // 
            // panelEx1
            // 
            this.panelEx1.CanvasColor = System.Drawing.SystemColors.Control;
            this.panelEx1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.panelEx1.Controls.Add(this.btn_Send);
            this.panelEx1.Controls.Add(this.btn_Clsoe);
            this.panelEx1.Controls.Add(this.pictureBox1);
            this.panelEx1.Controls.Add(this.txt_FullName);
            this.panelEx1.Controls.Add(this.labelX3);
            this.panelEx1.Controls.Add(this.labelX2);
            this.panelEx1.Controls.Add(this.dgvShowUser);
            this.panelEx1.Controls.Add(this.labelX1);
            this.panelEx1.DisabledBackColor = System.Drawing.Color.Empty;
            this.panelEx1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelEx1.Location = new System.Drawing.Point(0, 0);
            this.panelEx1.Name = "panelEx1";
            this.panelEx1.Size = new System.Drawing.Size(482, 453);
            this.panelEx1.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.panelEx1.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.panelEx1.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.panelEx1.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.panelEx1.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.panelEx1.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.panelEx1.Style.GradientAngle = 90;
            this.panelEx1.TabIndex = 0;
            // 
            // btn_Send
            // 
            this.btn_Send.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btn_Send.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btn_Send.Font = new System.Drawing.Font("B Mitra", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btn_Send.ImageTextSpacing = 4;
            this.btn_Send.Location = new System.Drawing.Point(234, 393);
            this.btn_Send.Name = "btn_Send";
            this.btn_Send.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btn_Send.Shape = new DevComponents.DotNetBar.RoundRectangleShapeDescriptor(10, 2, 2, 10);
            this.btn_Send.Size = new System.Drawing.Size(128, 38);
            this.btn_Send.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btn_Send.Symbol = "";
            this.btn_Send.TabIndex = 6;
            this.btn_Send.Text = "ارسال نامه";
            this.btn_Send.Click += new System.EventHandler(this.btn_Send_Click);
            // 
            // btn_Clsoe
            // 
            this.btn_Clsoe.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btn_Clsoe.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btn_Clsoe.Font = new System.Drawing.Font("B Mitra", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btn_Clsoe.ImageTextSpacing = 4;
            this.btn_Clsoe.Location = new System.Drawing.Point(70, 393);
            this.btn_Clsoe.Name = "btn_Clsoe";
            this.btn_Clsoe.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btn_Clsoe.Shape = new DevComponents.DotNetBar.RoundRectangleShapeDescriptor(10, 0, 0, 10);
            this.btn_Clsoe.Size = new System.Drawing.Size(128, 38);
            this.btn_Clsoe.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btn_Clsoe.Symbol = "";
            this.btn_Clsoe.TabIndex = 7;
            this.btn_Clsoe.Text = "خروج";
            this.btn_Clsoe.Click += new System.EventHandler(this.btn_Clsoe_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Automation_1.Properties.Resources.search_icon;
            this.pictureBox1.Location = new System.Drawing.Point(11, 330);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(49, 50);
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // txt_FullName
            // 
            // 
            // 
            // 
            this.txt_FullName.Border.Class = "TextBoxBorder";
            this.txt_FullName.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txt_FullName.Location = new System.Drawing.Point(70, 338);
            this.txt_FullName.Name = "txt_FullName";
            this.txt_FullName.PreventEnterBeep = true;
            this.txt_FullName.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txt_FullName.Size = new System.Drawing.Size(292, 31);
            this.txt_FullName.TabIndex = 4;
            this.txt_FullName.WatermarkText = "نام و نام خانوادگی را وارد کنید";
            // 
            // labelX3
            // 
            // 
            // 
            // 
            this.labelX3.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX3.Font = new System.Drawing.Font("B Mitra", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.labelX3.Location = new System.Drawing.Point(359, 337);
            this.labelX3.Name = "labelX3";
            this.labelX3.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.labelX3.Size = new System.Drawing.Size(111, 32);
            this.labelX3.TabIndex = 3;
            this.labelX3.Text = "نام و نام خانوادگی :";
            // 
            // labelX2
            // 
            // 
            // 
            // 
            this.labelX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX2.Font = new System.Drawing.Font("B Mitra", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.labelX2.Location = new System.Drawing.Point(419, 287);
            this.labelX2.Name = "labelX2";
            this.labelX2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.labelX2.Size = new System.Drawing.Size(51, 32);
            this.labelX2.TabIndex = 2;
            this.labelX2.Text = "جستجو :";
            // 
            // dgvShowUser
            // 
            this.dgvShowUser.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dgvShowUser.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvShowUser.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.UserID,
            this.UsersJobsID,
            this.Select,
            this.FullName,
            this.job});
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("B Mitra", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvShowUser.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgvShowUser.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.dgvShowUser.Location = new System.Drawing.Point(0, 77);
            this.dgvShowUser.Name = "dgvShowUser";
            this.dgvShowUser.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dgvShowUser.RowTemplate.Height = 24;
            this.dgvShowUser.Size = new System.Drawing.Size(479, 204);
            this.dgvShowUser.TabIndex = 1;
            // 
            // UserID
            // 
            this.UserID.HeaderText = "Column1";
            this.UserID.Name = "UserID";
            this.UserID.Visible = false;
            // 
            // UsersJobsID
            // 
            this.UsersJobsID.HeaderText = "UserJobID";
            this.UsersJobsID.Name = "UsersJobsID";
            this.UsersJobsID.Visible = false;
            // 
            // Select
            // 
            this.Select.Checked = true;
            this.Select.CheckState = System.Windows.Forms.CheckState.Indeterminate;
            this.Select.CheckValue = null;
            this.Select.HeaderText = "انتخاب";
            this.Select.Name = "Select";
            this.Select.Width = 50;
            // 
            // FullName
            // 
            this.FullName.HeaderText = "نام و نام خانوادگی";
            this.FullName.Name = "FullName";
            this.FullName.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.FullName.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.FullName.Width = 200;
            // 
            // job
            // 
            this.job.HeaderText = "شغل";
            this.job.Name = "job";
            this.job.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.job.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.job.Width = 180;
            // 
            // labelX1
            // 
            // 
            // 
            // 
            this.labelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX1.Font = new System.Drawing.Font("B Mitra", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.labelX1.ImageTextSpacing = 8;
            this.labelX1.Location = new System.Drawing.Point(154, 12);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(157, 44);
            this.labelX1.Symbol = "";
            this.labelX1.TabIndex = 0;
            this.labelX1.Text = "فرم ارسال نامه";
            // 
            // Frm_SelectedUserForSendLetter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(482, 453);
            this.Controls.Add(this.panelEx1);
            this.Font = new System.Drawing.Font("B Mitra", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Frm_SelectedUserForSendLetter";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Frm_SelectedUserForSendLetter";
            this.Load += new System.EventHandler(this.Frm_SelectedUserForSendLetter_Load);
            this.panelEx1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvShowUser)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.PanelEx panelEx1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private DevComponents.DotNetBar.Controls.TextBoxX txt_FullName;
        private DevComponents.DotNetBar.LabelX labelX3;
        private DevComponents.DotNetBar.LabelX labelX2;
        private DevComponents.DotNetBar.Controls.DataGridViewX dgvShowUser;
        private DevComponents.DotNetBar.LabelX labelX1;
        private DevComponents.DotNetBar.ButtonX btn_Send;
        private DevComponents.DotNetBar.ButtonX btn_Clsoe;
        private System.Windows.Forms.DataGridViewTextBoxColumn UserID;
        private System.Windows.Forms.DataGridViewTextBoxColumn UsersJobsID;
        private DevComponents.DotNetBar.Controls.DataGridViewCheckBoxXColumn Select;
        private System.Windows.Forms.DataGridViewTextBoxColumn FullName;
        private System.Windows.Forms.DataGridViewTextBoxColumn job;
    }
}