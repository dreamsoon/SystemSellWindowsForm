namespace Automation_1.Admin_forms
{
    partial class Frm_CrateNews
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
            this.panelEx1 = new DevComponents.DotNetBar.PanelEx();
            this.btn_createjob = new DevComponents.DotNetBar.ButtonX();
            this.btn_exit = new DevComponents.DotNetBar.ButtonX();
            this.groupPanel1 = new DevComponents.DotNetBar.Controls.GroupPanel();
            this.lbl_Atachment = new DevComponents.DotNetBar.LabelX();
            this.btn_atachment = new DevComponents.DotNetBar.ButtonX();
            this.lbl_UserName = new DevComponents.DotNetBar.LabelX();
            this.labelX7 = new DevComponents.DotNetBar.LabelX();
            this.lbl_Date = new DevComponents.DotNetBar.LabelX();
            this.labelX4 = new DevComponents.DotNetBar.LabelX();
            this.txt_text = new System.Windows.Forms.TextBox();
            this.txt_Subject = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX3 = new DevComponents.DotNetBar.LabelX();
            this.labelX2 = new DevComponents.DotNetBar.LabelX();
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.openFiledlg_Atachment = new System.Windows.Forms.OpenFileDialog();
            this.btn_ShowNews = new DevComponents.DotNetBar.ButtonX();
            this.panelEx1.SuspendLayout();
            this.groupPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelEx1
            // 
            this.panelEx1.CanvasColor = System.Drawing.SystemColors.Control;
            this.panelEx1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.panelEx1.Controls.Add(this.btn_ShowNews);
            this.panelEx1.Controls.Add(this.btn_createjob);
            this.panelEx1.Controls.Add(this.btn_exit);
            this.panelEx1.Controls.Add(this.groupPanel1);
            this.panelEx1.Controls.Add(this.labelX1);
            this.panelEx1.DisabledBackColor = System.Drawing.Color.Empty;
            this.panelEx1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelEx1.Location = new System.Drawing.Point(0, 0);
            this.panelEx1.Name = "panelEx1";
            this.panelEx1.Size = new System.Drawing.Size(903, 376);
            this.panelEx1.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.panelEx1.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.panelEx1.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.panelEx1.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.panelEx1.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.panelEx1.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.panelEx1.Style.GradientAngle = 90;
            this.panelEx1.TabIndex = 0;
            // 
            // btn_createjob
            // 
            this.btn_createjob.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btn_createjob.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btn_createjob.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_createjob.Font = new System.Drawing.Font("B Mitra", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btn_createjob.Location = new System.Drawing.Point(368, 326);
            this.btn_createjob.Name = "btn_createjob";
            this.btn_createjob.Shape = new DevComponents.DotNetBar.RoundRectangleShapeDescriptor(10, 2, 2, 10);
            this.btn_createjob.Size = new System.Drawing.Size(136, 45);
            this.btn_createjob.Symbol = "";
            this.btn_createjob.TabIndex = 11;
            this.btn_createjob.Text = "ارسال خبر";
            this.btn_createjob.Click += new System.EventHandler(this.btn_createjob_Click);
            // 
            // btn_exit
            // 
            this.btn_exit.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btn_exit.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btn_exit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_exit.Font = new System.Drawing.Font("B Mitra", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btn_exit.Location = new System.Drawing.Point(212, 326);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Shape = new DevComponents.DotNetBar.RoundRectangleShapeDescriptor(10, 2, 2, 10);
            this.btn_exit.Size = new System.Drawing.Size(136, 45);
            this.btn_exit.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btn_exit.Symbol = "";
            this.btn_exit.TabIndex = 10;
            this.btn_exit.Text = "خروج";
            this.btn_exit.Click += new System.EventHandler(this.btn_exit_Click);
            // 
            // groupPanel1
            // 
            this.groupPanel1.CanvasColor = System.Drawing.SystemColors.Control;
            this.groupPanel1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.groupPanel1.Controls.Add(this.lbl_Atachment);
            this.groupPanel1.Controls.Add(this.btn_atachment);
            this.groupPanel1.Controls.Add(this.lbl_UserName);
            this.groupPanel1.Controls.Add(this.labelX7);
            this.groupPanel1.Controls.Add(this.lbl_Date);
            this.groupPanel1.Controls.Add(this.labelX4);
            this.groupPanel1.Controls.Add(this.txt_text);
            this.groupPanel1.Controls.Add(this.txt_Subject);
            this.groupPanel1.Controls.Add(this.labelX3);
            this.groupPanel1.Controls.Add(this.labelX2);
            this.groupPanel1.DisabledBackColor = System.Drawing.Color.Empty;
            this.groupPanel1.Location = new System.Drawing.Point(3, 72);
            this.groupPanel1.Name = "groupPanel1";
            this.groupPanel1.Size = new System.Drawing.Size(897, 248);
            // 
            // 
            // 
            this.groupPanel1.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.groupPanel1.Style.BackColorGradientAngle = 90;
            this.groupPanel1.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.groupPanel1.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel1.Style.BorderBottomWidth = 1;
            this.groupPanel1.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.groupPanel1.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel1.Style.BorderLeftWidth = 1;
            this.groupPanel1.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel1.Style.BorderRightWidth = 1;
            this.groupPanel1.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel1.Style.BorderTopWidth = 1;
            this.groupPanel1.Style.CornerDiameter = 4;
            this.groupPanel1.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded;
            this.groupPanel1.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center;
            this.groupPanel1.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.groupPanel1.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near;
            // 
            // 
            // 
            this.groupPanel1.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.groupPanel1.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.groupPanel1.TabIndex = 9;
            this.groupPanel1.Text = "مشخصات نامه";
            // 
            // lbl_Atachment
            // 
            this.lbl_Atachment.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.lbl_Atachment.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lbl_Atachment.FocusCuesEnabled = true;
            this.lbl_Atachment.Font = new System.Drawing.Font("B Mitra", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lbl_Atachment.Location = new System.Drawing.Point(18, 166);
            this.lbl_Atachment.Name = "lbl_Atachment";
            this.lbl_Atachment.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lbl_Atachment.Size = new System.Drawing.Size(436, 44);
            this.lbl_Atachment.TabIndex = 29;
            this.lbl_Atachment.WordWrap = true;
            // 
            // btn_atachment
            // 
            this.btn_atachment.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btn_atachment.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btn_atachment.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_atachment.Font = new System.Drawing.Font("B Mitra", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btn_atachment.Location = new System.Drawing.Point(232, 118);
            this.btn_atachment.Name = "btn_atachment";
            this.btn_atachment.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btn_atachment.Shape = new DevComponents.DotNetBar.RoundRectangleShapeDescriptor(10, 2, 2, 10);
            this.btn_atachment.Size = new System.Drawing.Size(222, 41);
            this.btn_atachment.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btn_atachment.Symbol = "";
            this.btn_atachment.TabIndex = 28;
            this.btn_atachment.Text = "الصاق فایل";
            this.btn_atachment.Click += new System.EventHandler(this.btn_atachment_Click);
            // 
            // lbl_UserName
            // 
            // 
            // 
            // 
            this.lbl_UserName.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lbl_UserName.Font = new System.Drawing.Font("B Mitra", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lbl_UserName.ForeColor = System.Drawing.Color.Red;
            this.lbl_UserName.Location = new System.Drawing.Point(178, 64);
            this.lbl_UserName.Name = "lbl_UserName";
            this.lbl_UserName.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lbl_UserName.Size = new System.Drawing.Size(164, 24);
            this.lbl_UserName.TabIndex = 27;
            this.lbl_UserName.Text = "علی حیدریان فرد";
            // 
            // labelX7
            // 
            // 
            // 
            // 
            this.labelX7.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX7.Font = new System.Drawing.Font("B Mitra", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.labelX7.Location = new System.Drawing.Point(346, 65);
            this.labelX7.Name = "labelX7";
            this.labelX7.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.labelX7.Size = new System.Drawing.Size(108, 24);
            this.labelX7.TabIndex = 26;
            this.labelX7.Text = "کاربر ارسال کننده :";
            // 
            // lbl_Date
            // 
            // 
            // 
            // 
            this.lbl_Date.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lbl_Date.Font = new System.Drawing.Font("B Mitra", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lbl_Date.ForeColor = System.Drawing.Color.Red;
            this.lbl_Date.Location = new System.Drawing.Point(142, 10);
            this.lbl_Date.Name = "lbl_Date";
            this.lbl_Date.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lbl_Date.Size = new System.Drawing.Size(164, 24);
            this.lbl_Date.TabIndex = 25;
            this.lbl_Date.Text = "1398/05/07";
            // 
            // labelX4
            // 
            // 
            // 
            // 
            this.labelX4.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX4.Font = new System.Drawing.Font("B Mitra", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.labelX4.Location = new System.Drawing.Point(310, 9);
            this.labelX4.Name = "labelX4";
            this.labelX4.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.labelX4.Size = new System.Drawing.Size(142, 24);
            this.labelX4.TabIndex = 24;
            this.labelX4.Text = "تاریخ ایجاد و ارسال خبر :";
            // 
            // txt_text
            // 
            this.txt_text.Location = new System.Drawing.Point(549, 65);
            this.txt_text.Multiline = true;
            this.txt_text.Name = "txt_text";
            this.txt_text.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txt_text.Size = new System.Drawing.Size(269, 145);
            this.txt_text.TabIndex = 23;
            // 
            // txt_Subject
            // 
            // 
            // 
            // 
            this.txt_Subject.Border.Class = "TextBoxBorder";
            this.txt_Subject.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txt_Subject.Location = new System.Drawing.Point(549, 3);
            this.txt_Subject.Name = "txt_Subject";
            this.txt_Subject.PreventEnterBeep = true;
            this.txt_Subject.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txt_Subject.Size = new System.Drawing.Size(269, 31);
            this.txt_Subject.TabIndex = 22;
            // 
            // labelX3
            // 
            // 
            // 
            // 
            this.labelX3.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX3.Font = new System.Drawing.Font("B Mitra", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.labelX3.Location = new System.Drawing.Point(824, 65);
            this.labelX3.Name = "labelX3";
            this.labelX3.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.labelX3.Size = new System.Drawing.Size(56, 24);
            this.labelX3.TabIndex = 1;
            this.labelX3.Text = "متن خبر :";
            // 
            // labelX2
            // 
            // 
            // 
            // 
            this.labelX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX2.Font = new System.Drawing.Font("B Mitra", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.labelX2.Location = new System.Drawing.Point(804, 3);
            this.labelX2.Name = "labelX2";
            this.labelX2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.labelX2.Size = new System.Drawing.Size(90, 24);
            this.labelX2.TabIndex = 0;
            this.labelX2.Text = "موضوع خبر :";
            // 
            // labelX1
            // 
            // 
            // 
            // 
            this.labelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX1.Font = new System.Drawing.Font("B Mitra", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.labelX1.ImageTextSpacing = 10;
            this.labelX1.Location = new System.Drawing.Point(288, 3);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(311, 33);
            this.labelX1.Symbol = "";
            this.labelX1.TabIndex = 8;
            this.labelX1.Text = "فرم ایجاد و ارسال خبر و اطلاعیه ها";
            // 
            // openFiledlg_Atachment
            // 
            this.openFiledlg_Atachment.FileName = "openFileDialog1";
            // 
            // btn_ShowNews
            // 
            this.btn_ShowNews.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btn_ShowNews.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btn_ShowNews.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_ShowNews.Font = new System.Drawing.Font("B Mitra", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btn_ShowNews.Location = new System.Drawing.Point(524, 326);
            this.btn_ShowNews.Name = "btn_ShowNews";
            this.btn_ShowNews.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btn_ShowNews.Shape = new DevComponents.DotNetBar.RoundRectangleShapeDescriptor(10, 2, 2, 10);
            this.btn_ShowNews.Size = new System.Drawing.Size(149, 41);
            this.btn_ShowNews.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btn_ShowNews.Symbol = "";
            this.btn_ShowNews.TabIndex = 17;
            this.btn_ShowNews.Text = "مشاهده خبر ها";
            this.btn_ShowNews.Click += new System.EventHandler(this.btn_ShowNews_Click);
            // 
            // Frm_CrateNews
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(903, 376);
            this.Controls.Add(this.panelEx1);
            this.Font = new System.Drawing.Font("B Mitra", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Frm_CrateNews";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Frm_CrateNews";
            this.Load += new System.EventHandler(this.Frm_CrateNews_Load);
            this.panelEx1.ResumeLayout(false);
            this.groupPanel1.ResumeLayout(false);
            this.groupPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.PanelEx panelEx1;
        private DevComponents.DotNetBar.Controls.GroupPanel groupPanel1;
        private DevComponents.DotNetBar.LabelX labelX1;
        private DevComponents.DotNetBar.ButtonX btn_createjob;
        private DevComponents.DotNetBar.ButtonX btn_exit;
        private DevComponents.DotNetBar.LabelX labelX3;
        private DevComponents.DotNetBar.LabelX labelX2;
        private DevComponents.DotNetBar.LabelX lbl_UserName;
        private DevComponents.DotNetBar.LabelX labelX7;
        private DevComponents.DotNetBar.LabelX lbl_Date;
        private DevComponents.DotNetBar.LabelX labelX4;
        private System.Windows.Forms.TextBox txt_text;
        private DevComponents.DotNetBar.Controls.TextBoxX txt_Subject;
        private DevComponents.DotNetBar.ButtonX btn_atachment;
        private DevComponents.DotNetBar.LabelX lbl_Atachment;
        private System.Windows.Forms.OpenFileDialog openFiledlg_Atachment;
        private DevComponents.DotNetBar.ButtonX btn_ShowNews;
    }
}