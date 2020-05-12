namespace Automation_1.User_forms
{
    partial class SendRefrenceLetter
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panelEx1 = new DevComponents.DotNetBar.PanelEx();
            this.dgv_ReciveLetter = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.groupPanel1 = new DevComponents.DotNetBar.Controls.GroupPanel();
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.panelEx2 = new DevComponents.DotNetBar.PanelEx();
            this.LetterNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LetterID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Subject = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UserSender = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.erjadahande = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabaghebandi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.foriat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RefrenceID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.erjadahandeid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.erjashodeid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bayganistatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sanadtype = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RefrenceTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AnswerType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UserID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ReciveLetter)).BeginInit();
            this.groupPanel1.SuspendLayout();
            this.panelEx2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelEx1
            // 
            this.panelEx1.CanvasColor = System.Drawing.SystemColors.Control;
            this.panelEx1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.panelEx1.DisabledBackColor = System.Drawing.Color.Empty;
            this.panelEx1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelEx1.Location = new System.Drawing.Point(0, 0);
            this.panelEx1.Name = "panelEx1";
            this.panelEx1.Size = new System.Drawing.Size(1247, 750);
            this.panelEx1.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.panelEx1.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.panelEx1.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.panelEx1.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.panelEx1.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.panelEx1.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.panelEx1.Style.GradientAngle = 90;
            this.panelEx1.TabIndex = 0;
            // 
            // dgv_ReciveLetter
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("B Mitra", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_ReciveLetter.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_ReciveLetter.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_ReciveLetter.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.LetterNumber,
            this.LetterID,
            this.Subject,
            this.UserSender,
            this.erjadahande,
            this.tabaghebandi,
            this.foriat,
            this.RefrenceID,
            this.erjadahandeid,
            this.erjashodeid,
            this.bayganistatus,
            this.sanadtype,
            this.RefrenceTime,
            this.AnswerType,
            this.UserID});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("B Mitra", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_ReciveLetter.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgv_ReciveLetter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_ReciveLetter.EnableHeadersVisualStyles = false;
            this.dgv_ReciveLetter.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.dgv_ReciveLetter.Location = new System.Drawing.Point(0, 0);
            this.dgv_ReciveLetter.Name = "dgv_ReciveLetter";
            this.dgv_ReciveLetter.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("B Mitra", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_ReciveLetter.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgv_ReciveLetter.RowTemplate.Height = 24;
            this.dgv_ReciveLetter.Size = new System.Drawing.Size(1235, 488);
            this.dgv_ReciveLetter.TabIndex = 0;
            this.dgv_ReciveLetter.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgv_ReciveLetter_CellMouseDoubleClick);
            // 
            // groupPanel1
            // 
            this.groupPanel1.CanvasColor = System.Drawing.SystemColors.Control;
            this.groupPanel1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.groupPanel1.Controls.Add(this.dgv_ReciveLetter);
            this.groupPanel1.DisabledBackColor = System.Drawing.Color.Empty;
            this.groupPanel1.Location = new System.Drawing.Point(3, 72);
            this.groupPanel1.Name = "groupPanel1";
            this.groupPanel1.Size = new System.Drawing.Size(1241, 494);
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
            this.groupPanel1.TabIndex = 8;
            // 
            // labelX1
            // 
            // 
            // 
            // 
            this.labelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX1.Font = new System.Drawing.Font("B Mitra", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.labelX1.ImageTextSpacing = 10;
            this.labelX1.Location = new System.Drawing.Point(527, 12);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(227, 33);
            this.labelX1.Symbol = "";
            this.labelX1.TabIndex = 7;
            this.labelX1.Text = "فرم نمایش نامه های ارجاع شده";
            // 
            // panelEx2
            // 
            this.panelEx2.CanvasColor = System.Drawing.SystemColors.Control;
            this.panelEx2.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.panelEx2.Controls.Add(this.groupPanel1);
            this.panelEx2.Controls.Add(this.labelX1);
            this.panelEx2.DisabledBackColor = System.Drawing.Color.Empty;
            this.panelEx2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelEx2.Location = new System.Drawing.Point(0, 0);
            this.panelEx2.Name = "panelEx2";
            this.panelEx2.Size = new System.Drawing.Size(1247, 750);
            this.panelEx2.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.panelEx2.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.panelEx2.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.panelEx2.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.panelEx2.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.panelEx2.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.panelEx2.Style.GradientAngle = 90;
            this.panelEx2.TabIndex = 8;
            // 
            // LetterNumber
            // 
            this.LetterNumber.Frozen = true;
            this.LetterNumber.HeaderText = "شماره نامه";
            this.LetterNumber.Name = "LetterNumber";
            this.LetterNumber.Width = 130;
            // 
            // LetterID
            // 
            this.LetterID.Frozen = true;
            this.LetterID.HeaderText = "LetterID";
            this.LetterID.Name = "LetterID";
            this.LetterID.Visible = false;
            // 
            // Subject
            // 
            this.Subject.Frozen = true;
            this.Subject.HeaderText = "موضوع";
            this.Subject.Name = "Subject";
            this.Subject.Width = 180;
            // 
            // UserSender
            // 
            this.UserSender.Frozen = true;
            this.UserSender.HeaderText = "فرسنده";
            this.UserSender.Name = "UserSender";
            this.UserSender.Width = 150;
            // 
            // erjadahande
            // 
            this.erjadahande.Frozen = true;
            this.erjadahande.HeaderText = "ارجاع شده به";
            this.erjadahande.Name = "erjadahande";
            this.erjadahande.Width = 150;
            // 
            // tabaghebandi
            // 
            this.tabaghebandi.Frozen = true;
            this.tabaghebandi.HeaderText = "طبقه بندی";
            this.tabaghebandi.Name = "tabaghebandi";
            this.tabaghebandi.Width = 110;
            // 
            // foriat
            // 
            this.foriat.Frozen = true;
            this.foriat.HeaderText = "فوریت";
            this.foriat.Name = "foriat";
            this.foriat.Width = 110;
            // 
            // RefrenceID
            // 
            this.RefrenceID.HeaderText = "Column1";
            this.RefrenceID.Name = "RefrenceID";
            this.RefrenceID.Visible = false;
            // 
            // erjadahandeid
            // 
            this.erjadahandeid.HeaderText = "Column1";
            this.erjadahandeid.Name = "erjadahandeid";
            this.erjadahandeid.Visible = false;
            // 
            // erjashodeid
            // 
            this.erjashodeid.HeaderText = "Column1";
            this.erjashodeid.Name = "erjashodeid";
            this.erjashodeid.Visible = false;
            // 
            // bayganistatus
            // 
            this.bayganistatus.HeaderText = "وضعیت بایگانی";
            this.bayganistatus.Name = "bayganistatus";
            this.bayganistatus.Width = 110;
            // 
            // sanadtype
            // 
            this.sanadtype.HeaderText = "نوع سند";
            this.sanadtype.Name = "sanadtype";
            // 
            // RefrenceTime
            // 
            this.RefrenceTime.HeaderText = "زمان ارجاع نامه";
            this.RefrenceTime.Name = "RefrenceTime";
            this.RefrenceTime.Width = 150;
            // 
            // AnswerType
            // 
            this.AnswerType.HeaderText = "AnswerType";
            this.AnswerType.Name = "AnswerType";
            this.AnswerType.Visible = false;
            // 
            // UserID
            // 
            this.UserID.HeaderText = "UserID";
            this.UserID.Name = "UserID";
            this.UserID.Visible = false;
            // 
            // SendRefrenceLetter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1247, 750);
            this.Controls.Add(this.panelEx2);
            this.Controls.Add(this.panelEx1);
            this.Font = new System.Drawing.Font("B Mitra", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "SendRefrenceLetter";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "a";
            this.Load += new System.EventHandler(this.SendRefrenceLetter_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ReciveLetter)).EndInit();
            this.groupPanel1.ResumeLayout(false);
            this.panelEx2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.PanelEx panelEx1;
        private DevComponents.DotNetBar.Controls.DataGridViewX dgv_ReciveLetter;
        private DevComponents.DotNetBar.Controls.GroupPanel groupPanel1;
        private DevComponents.DotNetBar.LabelX labelX1;
        private DevComponents.DotNetBar.PanelEx panelEx2;
        private System.Windows.Forms.DataGridViewTextBoxColumn LetterNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn LetterID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Subject;
        private System.Windows.Forms.DataGridViewTextBoxColumn UserSender;
        private System.Windows.Forms.DataGridViewTextBoxColumn erjadahande;
        private System.Windows.Forms.DataGridViewTextBoxColumn tabaghebandi;
        private System.Windows.Forms.DataGridViewTextBoxColumn foriat;
        private System.Windows.Forms.DataGridViewTextBoxColumn RefrenceID;
        private System.Windows.Forms.DataGridViewTextBoxColumn erjadahandeid;
        private System.Windows.Forms.DataGridViewTextBoxColumn erjashodeid;
        private System.Windows.Forms.DataGridViewTextBoxColumn bayganistatus;
        private System.Windows.Forms.DataGridViewTextBoxColumn sanadtype;
        private System.Windows.Forms.DataGridViewTextBoxColumn RefrenceTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn AnswerType;
        private System.Windows.Forms.DataGridViewTextBoxColumn UserID;
    }
}